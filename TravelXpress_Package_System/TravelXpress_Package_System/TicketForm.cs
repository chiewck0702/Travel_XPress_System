using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelXpress_Package_System.Module;

namespace TravelXpress_Package_System
{
    public partial class TicketForm : Form
    {
        SqlConnection connection;
        ConnectionClass connClass;

        TemporaryBusDetailsStore previousDateStore;
        SeatDetail seatDetail = new SeatDetail();
        public TicketForm(TemporaryBusDetailsStore previousDateStore, SeatDetail seatDetail)
        {
            InitializeComponent();

            this.previousDateStore = previousDateStore;

            connClass = new ConnectionClass();
            connection = new SqlConnection(connClass.connectionString);
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            TicketBookingForm ticketBookingForm = new TicketBookingForm(seatDetail);
            this.Hide();
            ticketBookingForm.busFrom = previousDateStore.busFrom;
            ticketBookingForm.busTo = previousDateStore.busTo;
            ticketBookingForm.busDepartDate = previousDateStore.departDate;
            ticketBookingForm.busReturnDate = previousDateStore.reDate;
            ticketBookingForm.ShowDialog();
        }
        private void chooseBt1_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            string selectedTicketID = "";
            if (clickedButton != null && clickedButton.Tag != null)
            {
                selectedTicketID = clickedButton.Tag.ToString();
                previousDateStore.ticketID = selectedTicketID;

                TicketSeat ticketSeat = new TicketSeat(previousDateStore, seatDetail);
                this.Hide(); // Hide current form while modal shows
                ticketSeat.ShowDialog(); // Show TicketSeat and wait until it's closed
            }
        }

        private void TicketForm_Load(object sender, EventArgs e)
        {
            busFromTb.Text = previousDateStore.busFrom;
            busToTb.Text = previousDateStore.busTo;
            departDateLb.Location = new Point(391, 108);
            departTb.Location = new Point(570, 112);
            departTb.Text = previousDateStore.departDate.ToString("dd MMMM yyyy");

            if (previousDateStore.roundTrip)
            {
                departDateLb.Location = new Point(121, 104);
                departTb.Location = new Point(300, 108);
                returnDateLb.Visible = true;
                returnTb.Visible = true;
                returnTb.Text = previousDateStore.reDate.ToString("dd MMMM yyyy");
            }
            else
            {
                departDateLb.Location = new Point(391, 108);
                departTb.Location = new Point(570, 112);
                returnDateLb.Visible = false;
                returnTb.Visible = false;
            }

            returnTb.Text = previousDateStore.reDate.ToString("dd MMMM yyyy");

            string sqlPullTrip = "SELECT t.*, r.*, ticket.*, bus.* " +
                                 "FROM Trip t " +
                                 "INNER JOIN RoutePath r ON t.RouteID = r.RouteID " +
                                 "INNER JOIN Ticket ticket ON t.TripID = ticket.TripID " +
                                 "INNER JOIN BusDetails bus ON t.BusID = bus.BusID " +
                                 "WHERE r.Origin LIKE @origin AND r.Destination LIKE @destination AND t.DepartureDate = @departDate " +
                                 "ORDER BY t.DepartureTime";

            List<Dictionary<string, object>> tickets = new List<Dictionary<string, object>>();

            using (SqlCommand cmd = new SqlCommand(sqlPullTrip, connection))
            {
                cmd.Parameters.AddWithValue("@origin", "%" + busFromTb.Text + "%");
                cmd.Parameters.AddWithValue("@destination", "%" + busToTb.Text + "%");
                cmd.Parameters.AddWithValue("@departDate", previousDateStore.departDate.Date);

                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ticketData = new Dictionary<string, object>();

                        for (int i = 0; i < reader.FieldCount; i++)
                            ticketData[reader.GetName(i)] = reader[i];

                        tickets.Add(ticketData);
                    }
                }

                // Now loop the stored tickets
                foreach (var row in tickets)
                {
                    string ticketID = row["TicketID"].ToString();
                    int totalSeats = Convert.ToInt32(row["TotalSeats"]);
                    int bookedSeats = 0;

                    string sqlCheckSeatAvailability = "SELECT COUNT(*) FROM Seats WHERE TicketID = @ticketID";
                    using (SqlCommand checkCmd = new SqlCommand(sqlCheckSeatAvailability, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@ticketID", ticketID);
                        bookedSeats = (int)checkCmd.ExecuteScalar();
                    }

                    if (bookedSeats >= totalSeats)
                        continue;

                    string BusID = row["BusID"].ToString();
                    string Bus = row["Bus"].ToString();
                    string Origin = row["Origin"].ToString();
                    string Destination = row["Destination"].ToString();
                    string Price = row["Price"].ToString();
                    string busImagePath = row["BusUpload"].ToString();
                    string boarding = row["BoardingPoint"].ToString();
                    string dropoff = row["DropOffPoint"].ToString();

                    DateTime DepartureDate = Convert.ToDateTime(row["DepartureDate"]);
                    DateTime DepartureTime = Convert.ToDateTime(row["DepartureTime"]);
                    DateTime arrivalTime = Convert.ToDateTime(row["ArrivalTime"]);

                    TimeSpan duration = arrivalTime - DepartureTime;
                    string durationFormatted = $"{(int)duration.TotalHours}h {duration.Minutes}m";

                    // Build UI panel like before using `row[...]`
                    Panel panel = CloneTicketPanel();

                    panel.Controls["label5"].Text = DepartureTime.ToString("hh:mm tt");
                    panel.Controls["label6"].Text = Bus;
                    panel.Controls["label30"].Text = totalSeats.ToString();
                    panel.Controls["label11"].Text = boarding;
                    panel.Controls["label15"].Text = Origin;
                    panel.Controls["label12"].Text = durationFormatted;
                    panel.Controls["label14"].Text = dropoff;
                    panel.Controls["label16"].Text = Destination;
                    panel.Controls["label10"].Text = Convert.ToDouble(Price).ToString("N2");
                    panel.Controls["label7"].Text = (totalSeats - bookedSeats).ToString();


                    PictureBox pic = panel.Controls["pictureBox1"] as PictureBox;
                    string imgPath = row["BusUpload"].ToString();
                    if (File.Exists(imgPath))
                        pic.Image = Image.FromFile(imgPath);
                    else
                        pic.Image = Image.FromFile("NoImageUploaded.png");

                    Button chooseButton = panel.Controls["chooseBt1"] as Button;
                    if (chooseButton != null)
                    {
                        chooseButton.Tag = ticketID;
                        chooseButton.Click -= chooseBt1_Click; // remove if exists (safe to call)
                        chooseButton.Click += chooseBt1_Click;
                    }

                    flowTicket1.Controls.Add(panel);
                }

                connection.Close();
            }
        }

        private Panel CloneTicketPanel()
        {
            Panel template = ticket1;
            Panel clone = new Panel
            {
                Size = template.Size,
                BackColor = template.BackColor,
                Font = template.Font,
                Margin = template.Margin,
                Padding = template.Padding
            };

            foreach (Control ctrl in template.Controls)
            {
                Control newCtrl = (Control)Activator.CreateInstance(ctrl.GetType());

                newCtrl.Size = ctrl.Size;
                newCtrl.Location = ctrl.Location;
                newCtrl.Font = ctrl.Font;
                newCtrl.Text = ctrl.Text;
                newCtrl.BackColor = ctrl.BackColor;
                newCtrl.ForeColor = ctrl.ForeColor;
                newCtrl.Name = ctrl.Name;

                if (ctrl is PictureBox pic && newCtrl is PictureBox newPic)
                {
                    newPic.Image = pic.Image;
                    newPic.SizeMode = pic.SizeMode;
                }

                if (ctrl is Button btn && newCtrl is Button newBtn)
                {
                    newBtn.Click += chooseBt1_Click; // attach event
                }

                clone.Controls.Add(newCtrl);
            }

            return clone;
        }

    }
}

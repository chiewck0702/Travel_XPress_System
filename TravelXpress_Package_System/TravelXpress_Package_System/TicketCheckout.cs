using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelXpress_Package_System.Module;
using System.IO;


namespace TravelXpress_Package_System
{
    public partial class TicketCheckout : Form
    {
        SqlConnection connection;
        ConnectionClass connClass;

        TemporaryBusDetailsStore previousDateStore;
        SeatDetail previousSeatDetails;
        CustomerDetails userDetails = new CustomerDetails();
        public TicketCheckout(TemporaryBusDetailsStore previousDateStore, SeatDetail previousSeatDetails, CustomerDetails userDetails)
        {
            InitializeComponent();
            this.previousDateStore = previousDateStore;
            this.previousSeatDetails = previousSeatDetails;
            this.userDetails = userDetails;

            connClass = new ConnectionClass();
            connection = new SqlConnection(connClass.connectionString);

        }

        public string cusName { get { return nameTb.Text; } set { nameTb.Text = userDetails.Name; } }

        public string cusContact { get { return contactTb.Text; } set { contactTb.Text = userDetails.Contact; } }

        public string cusIC { get { return icTb.Text; } set { icTb.Text = userDetails.IC; } }

        public string cusEmail { get { return emailTb.Text; } set { emailTb.Text = userDetails.Email; } }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backBt_Click(object sender, EventArgs e)
        {
            TicketSeat ticketSeat = new TicketSeat(previousDateStore, previousSeatDetails);
            this.Hide();
            ticketSeat.numSeats = previousSeatDetails.NumberOfSeats;
            ticketSeat.seatNumber = previousSeatDetails.SeatNumber;
            ticketSeat.nextBt.Visible = false;
            ticketSeat.ShowDialog();
        }

        private void TicketCheckout_Load(object sender, EventArgs e)
        {
            string sqlPullTicket = "SELECT t.*, r.*, ticket.*, bus.* " +
                                 "FROM Ticket ticket " +
                                 "INNER JOIN Trip t ON ticket.TripID = t.TripID " +
                                 "INNER JOIN RoutePath r ON t.RouteID = r.RouteID " +
                                 "INNER JOIN BusDetails bus ON t.BusID = bus.BusID " +
                                 "WHERE ticket.TicketID = @ticketID";

            using (SqlCommand cmd = new SqlCommand(sqlPullTicket, connection))
            {
                cmd.Parameters.AddWithValue("@ticketID", previousDateStore.ticketID);

                connection.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string BusID = reader["BusID"].ToString();
                        string Bus = reader["Bus"].ToString();
                        string Origin = reader["Origin"].ToString();
                        string Destination = reader["Destination"].ToString();
                        string Price = reader["Price"].ToString();
                        string busImagePath = reader["BusUpload"].ToString();
                        string totalSeats = reader["TotalSeats"].ToString();
                        string boarding = reader["BoardingPoint"].ToString();
                        string dropoff = reader["DropOffPoint"].ToString();

                        DateTime DepartureDate = Convert.ToDateTime(reader["DepartureDate"]);
                        DateTime DepartureTime = Convert.ToDateTime(reader["DepartureTime"]);
                        DateTime arrivalTime = Convert.ToDateTime(reader["arrivalTime"]);

                        TimeSpan duration = arrivalTime - DepartureTime;
                        string durationFormatted = $"{(int)duration.TotalHours}h {duration.Minutes}m";


                        Panel panel = CloneTicketSummaryPanel();

                        // Now set values in the cloned panel using control names
                        panel.Controls["label4"].Text = DepartureTime.ToString("hh:mm tt");
                        panel.Controls["label5"].Text = DepartureDate.ToString("dd MMMM yyyy");
                        panel.Controls["label13"].Text = previousSeatDetails.NumberOfSeats.ToString();
                        panel.Controls["label34"].Text = Price;
                        panel.Controls["label12"].Text = Bus;
                        panel.Controls["label8"].Text = Origin;
                        panel.Controls["label23"].Text = Destination;
                        panel.Controls["label24"].Text = dropoff;
                        panel.Controls["label11"].Text = boarding;
                        panel.Controls["label25"].Text = previousSeatDetails.TotalFees.ToString("N2");

                        ticketFlowPanel.Controls.Add(panel);
                    }
                }
                connection.Close();
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void proceedBt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTb.Text)) 
            {
                MessageBox.Show("Name Cannot Be Null!", "NULL ERROR!");
                return;
            }

            if (string.IsNullOrWhiteSpace(contactTb.Text))
            {
                MessageBox.Show("Contact Number Cannot Be Null!", "NULL ERROR!");
                return;
            }

            if (string.IsNullOrWhiteSpace(icTb.Text))
            {
                MessageBox.Show("IC Number Cannot Be Null!", "NULL ERROR!");
                return;
            }

            if (!maleRb.Checked && !femaleRb.Checked)
            {
                MessageBox.Show("Gender Cannot Be Null!", "NULL ERROR!");
                return;
            }
            
            if (string.IsNullOrWhiteSpace(emailTb.Text))
            {
                MessageBox.Show("Email Cannot Be Null!", "NULL ERROR!");
                return;
            }

            userDetails.Name = nameTb.Text;
            userDetails.Contact = contactTb.Text;
            userDetails.IC = icTb.Text;
            userDetails.Email = emailTb.Text;

            if (maleRb.Checked)
            {
                userDetails.gender = maleRb.Text;
            } else
            {
                userDetails.gender = femaleRb.Text;
            }

            TicketPayment ticketPayment = new TicketPayment(userDetails, previousDateStore, previousSeatDetails);
            this.Hide();
            ticketPayment.ShowDialog();

        }

        private Panel CloneTicketSummaryPanel()
        {
            Panel clonedPanel = new Panel
            {
                BackColor = Color.FromArgb(224, 224, 224),
                Size = new Size(1124, 193),
                Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular),
                Location = new Point(42, 172),
                Name = "ticketSummaryClone",
                Margin = new Padding(10)
            };

            foreach (Control ctrl in ticketSummary.Controls)
            {
                Control clonedControl = null;

                if (ctrl is Label originalLabel)
                {
                    clonedControl = new Label
                    {
                        Text = originalLabel.Text,
                        Location = originalLabel.Location,
                        Size = originalLabel.Size,
                        Font = originalLabel.Font,
                        ForeColor = originalLabel.ForeColor,
                        BackColor = originalLabel.BackColor,
                        Name = originalLabel.Name,
                        AutoSize = false, 
                        TextAlign = originalLabel.TextAlign 
                    };
                }
                else if (ctrl is PictureBox originalPic)
                {
                    clonedControl = new PictureBox
                    {
                        Image = originalPic.Image,
                        Location = originalPic.Location,
                        Size = originalPic.Size,
                        SizeMode = originalPic.SizeMode,
                        Name = originalPic.Name
                    };
                }
                else if (ctrl is Button originalButton)
                {
                    clonedControl = new Button
                    {
                        Text = originalButton.Text,
                        Location = originalButton.Location,
                        Size = originalButton.Size,
                        Font = originalButton.Font,
                        Name = originalButton.Name
                    };
                    // You can add the same event handler if needed
                    // ((Button)clonedControl).Click += originalButton.Click;
                }

                if (clonedControl != null)
                {
                    clonedPanel.Controls.Add(clonedControl);
                }
            }

            return clonedPanel;
        }

    }
}

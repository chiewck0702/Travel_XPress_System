using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using TravelXpress_Package_System.Module;

namespace TravelXpress_Package_System
{
    public partial class TicketReceipt : Form
    {
        SqlConnection connection;
        ConnectionClass connClass;

        private TemporaryBusDetailsStore previousDateStore;
        private SeatDetail previousSeatDetails;
        private CustomerDetails userDetails;
        public TicketReceipt(TemporaryBusDetailsStore previousDateStore, SeatDetail previousSeatDetails, CustomerDetails userDetails)
        {
            InitializeComponent();

            this.previousDateStore = previousDateStore;
            this.previousSeatDetails = previousSeatDetails;
            this.userDetails = userDetails;

            connClass = new ConnectionClass();
            connection = new SqlConnection(connClass.connectionString);

        }

        private void TicketReceipt_Load(object sender, EventArgs e)
        {

            string sqlPullBooking = "SELECT b.*, t.*, ticket.*, bus.*, r.*, c.* " +
                                    "FROM Booking b " +
                                    "INNER JOIN Ticket ticket ON b.TicketID = ticket.TicketID " +
                                    "INNER JOIN Trip t ON ticket.TripID = t.TripID " +
                                    "INNER JOIN BusDetails bus ON t.BusID = bus.BusID " +
                                    "INNER JOIN RoutePath r ON t.RouteID = r.RouteID " +
                                    "INNER JOIN Customer c ON c.CusID = b.CusID " +
                                    "WHERE b.BookingID = @bookingID";
            using (SqlCommand cmd = new SqlCommand(sqlPullBooking, connection))
            {
                cmd.Parameters.AddWithValue("@bookingID", previousDateStore.bookingID);

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
                        string paymentMethod = reader["PaymentMethod"].ToString();
                        string cusName = reader["cusName"].ToString();
                        string cusContact = reader["cusContact"].ToString();
                        string cusEmail = reader["cusEmail"].ToString();

                        DateTime DepartureDate = Convert.ToDateTime(reader["DepartureDate"]);
                        DateTime DepartureTime = Convert.ToDateTime(reader["DepartureTime"]);
                        DateTime arrivalTime = Convert.ToDateTime(reader["arrivalTime"]);
                        DateTime bookingDate = Convert.ToDateTime(reader["BookingDate"]);

                        string seatNumberJoined = string.Join(", ", previousSeatDetails.SeatNumberArray);

                        string receiptNumber = GenerateReceiptNumber();

                        // Now set values in the cloned panel using control names
                        label5.Text = cusName;
                        label6.Text = cusContact;
                        label8.Text = cusEmail;
                        label12.Text = bookingDate.ToString("dd MMMM yyyy");
                        label14.Text = receiptNumber;
                        label58.Text = DepartureDate.ToString("dd MMMM yyyy");
                        label56.Text = DepartureTime.ToString("hh:mm tt");
                        label54.Text = previousSeatDetails.NumberOfSeats.ToString();
                        label60.Text = Price;
                        label52.Text = Bus;
                        label50.Text = Origin;
                        label48.Text = Destination;
                        label16.Text = Price;
                        label18.Text = previousSeatDetails.TotalFees.ToString("C2");
                        label23.Text = paymentMethod;
                        label22.Text = previousSeatDetails.TotalFees.ToString("C2");
                        label44.Text = previousSeatDetails.TotalFees.ToString("C2");
                        label26.Text = seatNumberJoined;


                    }
                }
                connection.Close();
            }
        }

        private string GenerateReceiptNumber()
        {
            Random random = new Random();
            string digits = "";

            for (int i = 0; i < 10; i++)
            {
                digits += random.Next(0, 10); // generate a digit between 0-9
            }

            return "R" + digits;
        }

    
        private void confirmBt_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                 "Your ticket has been successfully booked!\nWould you like to return to the main page?",
                 "Booking Confirmation",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question
             );

            if (result == DialogResult.Yes)
            {
                CustomerMainPage customerMainPage = new CustomerMainPage();
                this.Hide(); // hides the current form
                customerMainPage.ShowDialog();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("Thank you for using our service!", "Goodbye", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit(); // closes the whole application
            }
        }
    }
}

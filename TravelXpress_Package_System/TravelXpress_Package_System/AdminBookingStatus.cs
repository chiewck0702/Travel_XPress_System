using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelXpress_Package_System.Module;

namespace TravelXpress_Package_System
{
    public partial class AdminBookingStatus : Form
    {
        public ConnectionClass connectionClass;
        public AdminBookingStatus()
        {
            InitializeComponent();
            connectionClass = new ConnectionClass();
        }

        private void AdminBookingStatus_Load(object sender, EventArgs e)
        {
            string connectionString = connectionClass.connectionString;
            cbBookingType.Items.AddRange(new string[] { "All", "Ticket", "Package", "Accommodation" });
            cbBookingType.SelectedIndex = 0; 

            LoadBookingData("All");

        }

        private void cbBookingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedType = cbBookingType.SelectedItem.ToString();
            LoadBookingData(selectedType);
        }
        private void LoadBookingData(string bookingType)
        {
            string query;

            if (bookingType == "All")
            {
                query = "SELECT BookingID,BookingType," +
                    "BookingDate,NumPax,TotalAmount,PaymentMethod FROM Booking";
            }
            else if(bookingType == "Ticket")
            {
                query = "SELECT BookingID,BookingType," +
                    "BookingDate,NumPax,TotalAmount,PaymentMethod FROM Booking WHERE BookingType = @Type";
            }
            else if(bookingType == "Package")
            {
                query = "SELECT BookingID,BookingType,BookingDate,StartDate," +
                    "EndDate,NumPax,TotalAmount,PaymentMethod FROM Booking WHERE BookingType = @Type";
            }
            else 
            {
                query = "SELECT BookingID,BookingType,BookingDate,StartDate," +
                    "EndDate,NumPax,TotalAmount,PaymentMethod FROM Booking WHERE BookingType = @Type";
            }
           

            using (SqlConnection conn = new SqlConnection(connectionClass.connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);

                    if (bookingType != "All")
                    {
                        cmd.Parameters.AddWithValue("@Type", bookingType);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    
                    dataGridViewBooking.Columns.Clear();
                    dataGridViewBooking.DataSource = dt;

                    

                    decimal totalAmount = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        if (decimal.TryParse(row["TotalAmount"].ToString(), out decimal value))
                        {
                            totalAmount += value;
                        }
                    }

                    tbAmount.Text = "RM " + totalAmount.ToString("0.00");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading booking data: " + ex.Message);
                }
            }
        }


    }
}

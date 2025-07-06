using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelXpress_Package_System.Module;

namespace TravelXpress_Package_System
{
    public partial class TicketSeat : Form
    {
        SqlConnection connection;
        ConnectionClass connClass;

        TemporaryBusDetailsStore previousDateStore;
        SeatDetail seatDetail = new SeatDetail();
        CustomerDetails userDetails = new CustomerDetails();
        public TicketSeat(TemporaryBusDetailsStore previousDateStore, SeatDetail seatDetails)
        {
            InitializeComponent();

            this.previousDateStore = previousDateStore;
            this.seatDetail = seatDetails;

            numSeatTb.Value = seatDetails.NumberOfSeats;
            seatsTb.Text = seatDetails.SeatNumber;
            numSeatLb.Text = seatDetails.NumberOfSeats.ToString();
            totalFeesLb.Text = seatDetails.TotalFees.ToString("N2");

            if (numSeatTb.Value != 0 && seatsTb.Text != string.Empty)
            {
                nextBt.Visible = true;
            }

            connClass = new ConnectionClass();
            connection = new SqlConnection(connClass.connectionString);

        }

        public int numSeats { get { return (int)numSeatTb.Value; } set { 
                seatDetail.NumberOfSeats = value;
                numSeatTb.Value = value; 
            } }

        public string seatNumber { get { return seatsTb.Text; } set { 
                seatDetail.SeatNumber = value;
                seatsTb.Text = value; 
            } }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void backBt_Click(object sender, EventArgs e)
        {
            TicketForm ticketForm = new TicketForm(previousDateStore, seatDetail);
            this.Hide();
            ticketForm.ShowDialog();
        }

        private void nextBt_Click(object sender, EventArgs e)
        {
            TicketCheckout ticketCheckout = new TicketCheckout(previousDateStore, seatDetail, userDetails);
            this.Hide();
            ticketCheckout.ShowDialog();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void confirmBt_Click(object sender, EventArgs e)
        {
            bool error = false;

            if (numSeatTb.Value <= 0 || numSeatTb == null)
            {
                MessageBox.Show("Number of Seat Cannot Less Than or Equal To Zero", "NUMBER INPUT ERROR");
                return;
            }

            if (string.IsNullOrWhiteSpace(seatsTb.Text))
            {
                MessageBox.Show("Seat Number Cannot Be Empty", "NULL WARNING");
                return;
            }

            seatDetail.SeatNumberArray = seatsTb.Text.Split(',')
                                     .Select(s => s.Trim())
                                     .Where(s => !string.IsNullOrEmpty(s))
                                     .ToArray();

            if (seatDetail.SeatNumberArray.Length != (int)numSeatTb.Value)
            {
                MessageBox.Show("The Seats You Choose Must Match With The Number Of Seats You Enter!!", "INPUT ERROR");
                error = true;
                clearInput();
                return;
            } 

            string sqlCheckSeatAvailability = "SELECT s.seat " +
                                              "FROM Seats s " +
                                              "INNER JOIN Ticket t ON t.TicketID = s.TicketID " +
                                              "WHERE s.TicketID = @ticketID";

            List<string> bookedSeats = new List<string>();

            using (SqlCommand cmdCheck = new SqlCommand(sqlCheckSeatAvailability, connection))
            {
                cmdCheck.Parameters.AddWithValue("@ticketID", previousDateStore.ticketID);

                connection.Open();
                using (SqlDataReader reader = cmdCheck.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bookedSeats.Add(reader["seat"].ToString().Trim());
                    }
                }
                connection.Close();
            }

            // Check for conflicts
            foreach (string seat in seatDetail.SeatNumberArray)
            {
                if (bookedSeats.Contains(seat))
                {
                    MessageBox.Show($"Seat {seat} is already booked!", "Seat Conflict", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    error = true;
                    clearInput();
                    return;
                }
            }

            if (error == false)
            {
                seatDetail.NumberOfSeats = (int)numSeatTb.Value;
                numSeatLb.Text = numSeatTb.Value.ToString();

                seatDetail.SeatNumber = seatsTb.Text;

                double totalFees = 0;
                double price = 0;
                string sqlPullTrip = "SELECT * " +
                                     "FROM Ticket " +
                                     "WHERE TicketID = @ticketID";
                using (SqlCommand cmd = new SqlCommand(sqlPullTrip, connection))
                {
                    cmd.Parameters.AddWithValue("@ticketID", previousDateStore.ticketID);

                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            price = Convert.ToDouble(reader["Price"]);

                            totalFees = (int)numSeatTb.Value * price;
                            seatDetail.TotalFees = (decimal)totalFees;

                            totalFeesLb.Text = totalFees.ToString("N2");
                            nextBt.Visible = true;
                        }
                    }
                    connection.Close();
                }

            }
            else
            {
                clearInput();
            }


        }

        private void clearBt_Click(object sender, EventArgs e)
        {
            numSeatTb.Value = 0;
            seatsTb.Text = string.Empty;
            clearInput();
        }

        private void clearInput()
        {
            numSeatLb.Text = string.Empty;
            totalFeesLb.Text = string.Empty;
            nextBt.Visible = false;
        }

        private void TicketSeat_Load(object sender, EventArgs e)
        {

        }
    }

}

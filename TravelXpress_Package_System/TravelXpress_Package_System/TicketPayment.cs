using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelXpress_Package_System.Module;
using static TravelXpress_Package_System.TicketCheckout;
using System.Data.SqlClient;

namespace TravelXpress_Package_System
{
    public partial class TicketPayment : Form
    {
        SqlConnection connection;
        ConnectionClass connClass;

        TemporaryBusDetailsStore previousDateStore;
        SeatDetail previousSeatDetails;
        CustomerDetails userDetails;

        string basePath = AppDomain.CurrentDomain.BaseDirectory;

        string[] imagePath = {
                "Image/Payment/tng.png",
                "Image/Payment/FPX.png",
                "Image/Payment/Card.png"
            };

        public TicketPayment(CustomerDetails userDetails, TemporaryBusDetailsStore previousDataStore, SeatDetail previousSeatDetials)
        {
            InitializeComponent();

            this.userDetails = userDetails;
            this.previousDateStore = previousDataStore;
            this.previousSeatDetails = previousSeatDetials;

            string basePath = AppDomain.CurrentDomain.BaseDirectory;

            connClass = new ConnectionClass();
            connection = new SqlConnection(connClass.connectionString);

        }

        private void cardRb_CheckedChanged(object sender, EventArgs e)
        {
            if (cardRb.Checked)
            {
                cardPanel.Visible = true;
                paymentPic.Image = Image.FromFile(imagePath[2]);
            }
        }

        private void ewalletRb_CheckedChanged(object sender, EventArgs e)
        {
            if (ewalletRb.Checked)
            {
                cardPanel.Visible = false;
                paymentPic.Image = Image.FromFile(imagePath[0]);
            }
        }

        private void fpxRb_CheckedChanged(object sender, EventArgs e)
        {
            if (fpxRb.Checked)
            {
                cardPanel.Visible = false;
                paymentPic.Image = Image.FromFile(imagePath[1]);
                fpxLabel.Visible = true;
                fpxLabel.Location = new Point(163, 292);
            }
            else
            {
                fpxLabel.Visible = false;
            }
        }

        private void TicketPayment_Load(object sender, EventArgs e)
        {

        }

        private void bookBt_Click(object sender, EventArgs e)
        {
            if (cardRb.Checked)
            {
                if (string.IsNullOrWhiteSpace(cardHolderNameTb.Text))
                {
                    MessageBox.Show("Card Holder Name Cannot Be Null!", "NULL ERROR!");
                    return;
                }

                string cleanedText = cardNumTb.Text.Replace("_", "").Replace("-", "").Trim();
                if (string.IsNullOrWhiteSpace(cleanedText))
                {
                    MessageBox.Show("Card Number Cannot Be Null", "NULL ERROR!");
                    return;
                }

                if (exDateMMTb.Value == 0 || exDateYYTb.Value == 0 || exDateMMTb == null || exDateYYTb == null)
                {
                    MessageBox.Show("Expiry Date For Both Month and Year Cannot Be Null or Zero!", "NULL/ INPUT ERROR");
                    return;
                }

                if (cvvTb.Value == 0 || cvvTb == null)
                {
                    MessageBox.Show("CVV Number Cannot Be Null or Zero!", "NULL/ INPUT ERROR");
                    return;
                }

                if (!visaRb.Checked && !masterRb.Checked)
                {
                    MessageBox.Show("Visa/ Master Must Be Chosen Either One!", "NULL ERROR");
                    return;
                }

                if (!policyCb.Checked)
                {
                    MessageBox.Show("Term And Policy Must Be Checked Before Proceed!", "NULL ERROR");
                    return;
                }
            }

            string checkRecordCustomer = "SELECT TOP 1 CusID FROM Customer ORDER BY CusID DESC";
            using (SqlCommand command = new SqlCommand(checkRecordCustomer, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                int customerId;
                if (reader.Read())
                {
                    // If there's at least one record, increment the latest ID
                    customerId = Convert.ToInt32(reader["CusID"]) + 1;
                }
                else
                {
                    // No records in the table, start from 1
                    customerId = 1;
                }
                previousDateStore.cusID = customerId.ToString();

                reader.Close();
                connection.Close();

                string sqlRecordCustomer = "INSERT INTO Customer (cusID, cusName, cusIC, cusContact, cusEmail, cusGender) " +
                                           "VALUES (@cusID, @cusName, @cusIC, @cusContact, @cusEmail, @cusGender)";
                using (SqlCommand insertCMD = new SqlCommand(sqlRecordCustomer, connection))
                {
                    insertCMD.Parameters.AddWithValue("@cusID", customerId);
                    insertCMD.Parameters.AddWithValue("@cusName", userDetails.Name);
                    insertCMD.Parameters.AddWithValue("@cusIC", userDetails.IC);
                    insertCMD.Parameters.AddWithValue("@cusContact", userDetails.Contact);
                    insertCMD.Parameters.AddWithValue("@cusEmail", userDetails.Email);
                    insertCMD.Parameters.AddWithValue("@cusGender", userDetails.gender);

                    connection.Open();
                    int rowsAffected = insertCMD.ExecuteNonQuery();
                    connection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Customer Record Inserted Successfully!", "Success");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Insert Customer Record.", "Error");
                    }


                    string[] seatsChoose = previousSeatDetails.SeatNumber.Split(',')
                        .Select(s => s.Trim())
                        .Where(s => !string.IsNullOrEmpty(s))
                        .ToArray();

                    // Step 1: Get the current highest SeatID
                    string sqlCheckSeatsKey = "SELECT TOP 1 SeatID FROM Seats ORDER BY SeatID DESC";
                    int seatIdStart = 1;

                    using (SqlCommand seatCommand = new SqlCommand(sqlCheckSeatsKey, connection))
                    {
                        connection.Open();
                        SqlDataReader seatReader = seatCommand.ExecuteReader();
                        if (seatReader.Read())
                        {
                            seatIdStart = Convert.ToInt32(seatReader["SeatID"]) + 1;
                        }
                        seatReader.Close();
                        connection.Close();
                    }

                    // Step 2: Insert all selected seats
                    string sqlInsertSeat = "INSERT INTO Seats (SeatID, seat, TicketID) VALUES (@seatID, @seat, @ticketID)";

                    using (SqlCommand insertSeatCommand = new SqlCommand(sqlInsertSeat, connection))
                    {
                        connection.Open();
                        for (int i = 0; i < seatsChoose.Length; i++)
                        {
                            insertSeatCommand.Parameters.Clear();
                            insertSeatCommand.Parameters.AddWithValue("@seatID", seatIdStart + i);
                            insertSeatCommand.Parameters.AddWithValue("@seat", seatsChoose[i]);
                            insertSeatCommand.Parameters.AddWithValue("@ticketID", previousDateStore.ticketID);

                            int seatRowAffected = insertSeatCommand.ExecuteNonQuery();
                            if (seatRowAffected <= 0)
                            {
                                MessageBox.Show($"Failed to insert Seat {seatsChoose[i]}.", "Error");
                                connection.Close();
                                return;
                            }
                        }
                        connection.Close();
                    }


                    // Proceed with the next steps, such as booking the ticket
                    string checkRecordBooking = "SELECT TOP 1 BookingID FROM Booking ORDER BY BookingID DESC";
                    using (SqlCommand bookingCommand = new SqlCommand(checkRecordBooking, connection))
                    {
                        connection.Open();
                        SqlDataReader bookingReader = bookingCommand.ExecuteReader();
                        int bookingId;
                        if (bookingReader.Read())
                        {
                            // If there's at least one record, increment the latest ID
                            bookingId = Convert.ToInt32(bookingReader["BookingID"]) + 1;
                        }
                        else
                        {
                            // No records in the table, start from 1
                            bookingId = 1;
                        }

                        previousDateStore.bookingID = bookingId.ToString();

                        bookingReader.Close();
                        connection.Close();

                        // Insert into Booking table
                        string sqlRecordBooking = "INSERT INTO Booking (BookingID, BookingType, BookingDate, NumPax, TotalAmount, PaymentMethod, CusID, TicketID)" +
                                                  "VALUES (@bookingID, 'TICKET', @bookingDate, @numPax, @totalAmount, @paymentMethod, @cusID, @ticketID)";
                        using (SqlCommand bookingInsertCMD = new SqlCommand(sqlRecordBooking, connection))
                        {
                            bookingInsertCMD.Parameters.AddWithValue("@bookingID", bookingId);
                            bookingInsertCMD.Parameters.AddWithValue("@bookingDate", DateTime.Now);
                            bookingInsertCMD.Parameters.AddWithValue("@numPax", previousSeatDetails.NumberOfSeats);
                            bookingInsertCMD.Parameters.AddWithValue("@totalAmount", previousSeatDetails.TotalFees);
                            bookingInsertCMD.Parameters.AddWithValue("@paymentMethod", cardRb.Checked ? "Card" : ewalletRb.Checked ? "E-Wallet" : "FPX");
                            bookingInsertCMD.Parameters.AddWithValue("@cusID", customerId);
                            bookingInsertCMD.Parameters.AddWithValue("@ticketID", previousDateStore.ticketID);

                            connection.Open();
                            int bookingRowsAffected = bookingInsertCMD.ExecuteNonQuery();
                            connection.Close();
                            if (bookingRowsAffected > 0)
                            {
                                previousDateStore.bookingID = bookingId.ToString();
                                previousDateStore.cusID = customerId.ToString();
                                MessageBox.Show("Booking Record Inserted Successfully!", "Success");
                                this.Hide();
                                TicketReceipt ticketReceipt = new TicketReceipt(previousDateStore, previousSeatDetails, userDetails);
                                ticketReceipt.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Failed to Insert Booking Record.", "Error");
                            }
                        }
                    }

                }
            }

        }

        private void backBt_Click(object sender, EventArgs e)
        {
            TicketCheckout ticketCheckout = new TicketCheckout(previousDateStore, previousSeatDetails, userDetails);
            this.Hide();
            ticketCheckout.cusName = userDetails.Name;
            ticketCheckout.cusContact = userDetails.Contact;
            ticketCheckout.cusIC = userDetails.IC;
            ticketCheckout.cusEmail = userDetails.Email;
            ticketCheckout.ShowDialog();
        }
    }
}

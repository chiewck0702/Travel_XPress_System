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
using System.Xml.Linq;
using TravelXpress_Package_System.Module;

namespace TravelXpress_Package_System
{    
    public partial class AccommodationDetailsPage: Form
    {
        private SqlConnection connection;
        public ConnectionClass connectionClass;
        private SqlDataAdapter dataAdapter;
        private DataSet dataset;
        private HotelList selectedAccommodation;
        private List<RoomDetails> selectedRooms;
        private AccommodationCheckout accommodationCheckout;
        private CustomerDetails customerDetails;
        string[] imagePath = {
                "Image/Payment/tng.png",
                "Image/Payment/FPX.png",
                "Image/Payment/Card.png"
            };
        public AccommodationDetailsPage(HotelList accommodation, List<RoomDetails> rooms, AccommodationCheckout checkout)
        {
            InitializeComponent();

            this.selectedAccommodation = accommodation;
            this.selectedRooms = rooms;
            this.accommodationCheckout = checkout;

            lblAccommName.Text = selectedAccommodation.AccomName;
            lblAccommLocation.Text = selectedAccommodation.AccomLocation;
        }

        private void AccommodationDetailsPage_Load(object sender, EventArgs e)
        {            
            LoadSelectedRooms();
        }

        private decimal finalTotal = 0;
        private void LoadSelectedRooms()
        {
            decimal subTotal = 0;

            for (int i = 0; i < selectedRooms.Count && i < 3; i++)
            {
                RoomDetails room = selectedRooms[i];
                string bedType = room.RBedType;
                string price = room.PricePerNight.ToString("0.00");
                string quantity = room.NoOfRooms.ToString();
                string total = room.TotalAmount.ToString("0.00");

                if (i == 0)
                {
                    lblRBedType1.Text = bedType;
                    if (room.NoOfRooms == 0)
                    {
                        lblPricePerNIght1.Text = "-";
                        lblRoomQuantity1.Text = "-";
                        lblTotalPerRoom1.Text = "-";
                    }
                    else
                    {
                        lblPricePerNIght1.Text = price;
                        lblRoomQuantity1.Text = quantity;
                        lblTotalPerRoom1.Text = "RM " + total;
                    }                        
                }
                else if (i == 1)
                {
                    lblRBedType2.Text = bedType;
                    if (room.NoOfRooms == 0)
                    {
                        lblPricePerNIght2.Text = "-";
                        lblRoomQuantity2.Text = "-";
                        lblTotalPerRoom2.Text = "-";
                    }
                    else
                    {
                        lblPricePerNIght2.Text = price;
                        lblRoomQuantity2.Text = quantity;
                        lblTotalPerRoom2.Text = "RM " + total;
                    }                    
                }
                else if (i == 2)
                {
                    lblRBedType3.Text = bedType;
                    if (room.NoOfRooms == 0)
                    {
                        lblPricePerNIght3.Text = "-";
                        lblRoomQuantity3.Text = "-";
                        lblTotalPerRoom3.Text = "-";
                    }
                    else
                    {
                        lblPricePerNIght3.Text = price;
                        lblRoomQuantity3.Text = quantity;
                        lblTotalPerRoom3.Text = "RM " + total;
                    }
                }

                if (room.NoOfRooms > 0)
                {
                    subTotal += room.TotalAmount;
                }

                
            }

            if (accommodationCheckout != null)
            {
                lblcheckin.Text = accommodationCheckout.StartDate.ToShortDateString();
                lblcheckout.Text = accommodationCheckout.EndDate.ToShortDateString();

                lblcheckin.Text = accommodationCheckout.StartDate.ToString("dd/MM/yyyy");
                lblcheckout.Text = accommodationCheckout.EndDate.ToString("dd/MM/yyyy");

                TimeSpan duration = accommodationCheckout.EndDate - accommodationCheckout.StartDate;
                accommodationCheckout.DurationDays = duration.Days;
                lblTotalDays.Text = $"{duration.Days} night(s)";

                finalTotal = subTotal * accommodationCheckout.DurationDays;
            }

            lblFinalAmount.Text = "RM " + finalTotal.ToString("0.00");
        }        

        private void button5_Click(object sender, EventArgs e)
        {
            AccommodationBookingPage accommodationBookingPage = new AccommodationBookingPage(selectedAccommodation);
            this.Hide();
            accommodationBookingPage.ShowDialog();
        }        

        //proceed button
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tBxName.Text) && string.IsNullOrWhiteSpace(tBxIC.Text) && string.IsNullOrWhiteSpace(tBxEmail.Text) && string.IsNullOrWhiteSpace(tBxPhoneNumber.Text))
            {
                MessageBox.Show("All fields needs to be fill in.", "NULL WARNING");
                return;
            }

            if (cardRb.Checked)
            {
                if (string.IsNullOrWhiteSpace(tBxCardHolder.Text))
                {
                    MessageBox.Show("Card Holder Name Cannot Be Null!", "NULL ERROR!");
                    return;
                }

                string cleanedText = tBxCardNo.Text.Replace("_", "").Replace("-", "").Trim();
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

            CustomerDetails customerDetails = new CustomerDetails
            {
                Name = tBxName.Text,      
                IC = tBxIC.Text,
                Contact = tBxPhoneNumber.Text,
                Email = tBxEmail.Text,
                Gender = cbBxGender.SelectedItem?.ToString()
            };

            connectionClass = new ConnectionClass();
            string connectionString = connectionClass.connectionString;
            
            int newCustID;
            string query3 = "SELECT TOP 1 * FROM Customer ORDER BY cusID DESC";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query3, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Customer");

                var data = dataSet.Tables["Customer"];
                if (data.Rows.Count > 0)
                {
                    newCustID = int.Parse(data.Rows[0]["cusID"].ToString());
                    newCustID++;
                }
                else
                {
                    newCustID = 1;
                }
            }
            
            using (SqlConnection conn = new SqlConnection(connectionString))
            {                
                string query = "INSERT INTO Customer (cusID, cusName, cusIC, cusContact, cusEmail, cusGender) VALUES (@cusID, @Name, @IC, @Contact, @Email, @Gender)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@cusID", newCustID);
                cmd.Parameters.AddWithValue("@Name", customerDetails.Name);
                    cmd.Parameters.AddWithValue("@IC", customerDetails.IC);
                    cmd.Parameters.AddWithValue("@Contact", customerDetails.Contact);
                    cmd.Parameters.AddWithValue("@Email", customerDetails.Email);
                    cmd.Parameters.AddWithValue("@Gender", customerDetails.Gender);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }

            int newBookingID;
            // insert into customer table 
            string query4 = "SELECT TOP 1 * FROM Booking ORDER BY BookingID DESC";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query4, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Booking");

                var data = dataSet.Tables["Booking"];
                if (data.Rows.Count > 0)
                {
                    newBookingID = int.Parse(data.Rows[0]["BookingID"].ToString());
                    newBookingID++;
                }
                else
                {
                    newBookingID = 1;
                }
            }

            accommodationCheckout.totalAmount = (double)finalTotal;
            accommodationCheckout.bookingDate = DateTime.Now;

            if (cardRb.Checked)
            {
                accommodationCheckout.paymentMethod = "Credit/Debit Card";
            }
            else if (ewalletRb.Checked)
            {
                accommodationCheckout.paymentMethod = "E-Wallet";
            }
            else if (fpxRb.Checked)
            {
                accommodationCheckout.paymentMethod = "FPX";
            }

            string insertBookingQuery = "INSERT INTO Booking (BookingID, BookingType, BookingDate, StartDate, EndDate, NumPax, TotalAmount, PaymentMethod, CusID, AccomID) VALUES (@BookingID, @BookingType, @BookingDate, @StartDate, @EndDate, @NumPax, @TotalAmount, @PaymentMethod, @CusID, @AccomID)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(insertBookingQuery, conn);

                cmd.Parameters.AddWithValue("@BookingID", newBookingID);
                cmd.Parameters.AddWithValue("@BookingType", "Accommodation");
                cmd.Parameters.AddWithValue("@BookingDate", accommodationCheckout.bookingDate);
                cmd.Parameters.AddWithValue("@StartDate", accommodationCheckout.StartDate);
                cmd.Parameters.AddWithValue("@EndDate", accommodationCheckout.EndDate);
                cmd.Parameters.AddWithValue("@NumPax", "1");
                cmd.Parameters.AddWithValue("@TotalAmount", finalTotal);
                cmd.Parameters.AddWithValue("@PaymentMethod", accommodationCheckout.paymentMethod);
                cmd.Parameters.AddWithValue("@CusID", newCustID);
                cmd.Parameters.AddWithValue("@AccomID", selectedAccommodation.AccomID);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

            }


            using (AccommodationReceiptPage accommodationReceiptPage = new AccommodationReceiptPage(customerDetails, newBookingID, selectedRooms, accommodationCheckout, selectedAccommodation))
            {
                if (accommodationReceiptPage.ShowDialog() == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                //this.Hide();

                //accommodationReceiptPage.ShowDialog();
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
            }
        }

        private void cardRb_CheckedChanged(object sender, EventArgs e)
        {
            if (cardRb.Checked)
            {
                cardPanel.Visible = true;
                paymentPic.Image = Image.FromFile(imagePath[2]);
            }
        }

        private void exDateMMTb_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AccommodationBookingPage accommodationBookingPage = new AccommodationBookingPage(selectedAccommodation);
            this.Hide();
            accommodationBookingPage.ShowDialog();
        }
    }
}

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
    public partial class AccommodationReceiptPage: Form
    {
        private SqlConnection connection;
        public ConnectionClass connectionClass;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
        private HotelList selectedAccommodation;
        private List<RoomDetails> selectedRooms;
        private AccommodationCheckout accommodationCheckout;
        private CustomerDetails customerDetails;
        private int bookingID;
        public AccommodationReceiptPage(CustomerDetails customer, int bookingID, List<RoomDetails> rooms, AccommodationCheckout checkout, HotelList hotelList)
        {
            InitializeComponent();
            this.customerDetails = customer;
            this.bookingID = bookingID;
            this.selectedRooms = rooms;
            this.accommodationCheckout = checkout;
            this.selectedAccommodation = hotelList;

            this.connectionClass = new ConnectionClass();   
            string connectionString = connectionClass.connectionString;
            connection = new SqlConnection(connectionString);
        }

        private void AccommodationReceiptPage_Load(object sender, EventArgs e)
        {
            lblCustName.Text = ": " + customerDetails.Name;
            lblCustEmail.Text = ": " + customerDetails.Email;
            lblCustPhone.Text = ": " + customerDetails.Contact;
            lblCustIC.Text = ": " + customerDetails.IC;
            lblCustGender.Text = ": " + customerDetails.Gender;

            // Accommodation
            lblHotel.Text = ": " + selectedAccommodation.AccomName;
            lblLocation.Text = ": " + selectedAccommodation.AccomLocation;

            // Dates
            lblcheckin.Text = ": " + accommodationCheckout.StartDate.ToString("dd/MM/yyyy");
            lblcheckout.Text = ": " + accommodationCheckout.EndDate.ToString("dd/MM/yyyy");
            lblduration.Text = ": " + accommodationCheckout.DurationDays + " night(s)";
            lblBookingDate.Text = ": " + accommodationCheckout.bookingDate.ToString("dd/MM/yyyy");


            // Payment
            lblPaymentMethod.Text = accommodationCheckout.paymentMethod;
            lbltotalAmount.Text = "RM " + accommodationCheckout.totalAmount.ToString("0.00");

            double paid = accommodationCheckout.totalAmount; 
            decimal balance = 0;

            lblAmountPaid.Text = "RM " + paid.ToString("0.00");
            lblBalance.Text = "RM " + balance.ToString("0.00");

            Label[] lblBedTypes = { lblRBedType1, lblRBedType2, lblRBedType3 };
            Label[] lblQuantities = { lblRoomQuantity1, lblRoomQuantity2, lblRoomQuantity3 };
            Label[] lblPrices = { lblPricePerNIght1, lblPricePerNIght2, lblPricePerNIght3 };
            Label[] lblTotals = { lblTotalPerRoom1, lblTotalPerRoom2, lblTotalPerRoom3 };

            for (int i = 0; i < lblBedTypes.Length; i++)
            {
                if (i < selectedRooms.Count && selectedRooms[i].NoOfRooms > 0)
                {
                    var room = selectedRooms[i];
                    lblBedTypes[i].Text = room.RBedType; 
                    lblQuantities[i].Text = room.NoOfRooms.ToString();
                    lblPrices[i].Text = "RM " + room.PricePerNight.ToString("0.00");
                    lblTotals[i].Text = "RM " + room.TotalAmount.ToString("0.00");
                }
                else
                {
                    lblBedTypes[i].Text = "-";
                    lblQuantities[i].Text = "-";
                    lblPrices[i].Text = "-";
                    lblTotals[i].Text = "-";
                }
            }   

            LoadData();
        }

        private void LoadData()
        {          

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Booking has been confirmd. Thank you for booking with us :)");
            this.DialogResult = DialogResult.OK;
            this.Close();                  
        }
    }
}

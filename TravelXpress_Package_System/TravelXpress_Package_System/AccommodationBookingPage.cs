using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelXpress_Package_System.Module;

namespace TravelXpress_Package_System
{
    public partial class AccommodationBookingPage: Form
    {
        private SqlConnection connection;        
        public ConnectionClass connectionClass;
        private SqlDataAdapter dataAdapter;
        private DataSet dataset;
        private HotelList selectedAccommodation;
        private List<RoomDetails> selectedRooms;
        private AccommodationCheckout accommodationCheckout;
        public AccommodationBookingPage(HotelList accommodation)
        {
            InitializeComponent();

            connectionClass = new ConnectionClass();
            string connectionString = connectionClass.connectionString;
            connection = new SqlConnection(connectionString);
            this.selectedAccommodation = accommodation;

            lblAccommName.Text = selectedAccommodation.AccomName;
            lblAccommLocation.Text = selectedAccommodation.AccomLocation;

            lblfacilitiesList.Text = selectedAccommodation.AccomFacilities;

            checkinDate.MinDate = DateTime.Today;
            checkoutDate.MinDate = DateTime.Today.AddDays(1);
        }

        private void AccommodationBookingPage_Load(object sender, EventArgs e)
        {            
            LoadRooms();
        }

            private void LoadRooms()
            {
                flowLayoutPanel1.Controls.Clear();

                string query = "SELECT * FROM RoomType WHERE AccomID = @AccomID";

                string connectionString = connectionClass.connectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);                    

                    cmd.Parameters.AddWithValue("@AccomID", selectedAccommodation.AccomID);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {                        
                        RoomDetails room = new RoomDetails
                        {
                            Type = reader["Type"].ToString(),
                            RBedType = reader["RBedType"].ToString(), 
                            RAmenities = reader["RAmenities"].ToString(),
                            RFacilities = reader["RFacilities"].ToString(),
                            PricePerNight = Convert.ToDecimal(reader["PricePerNight"]),
                            NoOfRooms = 0
                        };
                    
                        RoomControl card = new RoomControl();
                        card.SetRoomData(room);

                        flowLayoutPanel1.Controls.Add(card);
                    }
                    reader.Close();
                }
            }

        private void button5_Click(object sender, EventArgs e)
        {
            AccommodationAvailabilityPage accommodationAvailabilityPage = new AccommodationAvailabilityPage();
            this.Hide();
            accommodationAvailabilityPage.ShowDialog();
        }

        //proceed button
        private void button1_Click(object sender, EventArgs e)
        {
            //validate if room is selected
            selectedRooms = new List<RoomDetails>();
            bool isSelectedRoom = false;

            foreach (RoomControl card in flowLayoutPanel1.Controls.OfType<RoomControl>())
            {
                var room = card.GetSelectedRoom();
                if (room.NoOfRooms > 0)
                {
                    isSelectedRoom = true;
                }

                selectedRooms.Add(room);
            }

            if (!isSelectedRoom)
            {
                MessageBox.Show("Please select at least one room to proceed.", "No Room Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //validate datetimepicker
            if (checkinDate.Value > checkoutDate.Value)
            {
                MessageBox.Show("Check-In date must be before Check-Out date.", "Check-In Date is later than Check-Out date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime maxdays = checkinDate.Value.AddDays(30);
            if (checkoutDate.Value < checkinDate.Value)
            {
                MessageBox.Show("Check-Out date must be after Check-In date.", "Check-Out Date is earlier than Check-In date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (checkoutDate.Value > maxdays)
            {
                MessageBox.Show("We do not do booking more than 30 days.", "Maximum days booking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //calculate duration
            DateTime checkin = checkinDate.Value.Date;
            DateTime checkout = checkoutDate.Value.Date;

            TimeSpan duration = checkout - checkin;
            
            var accommodationCheckout = new AccommodationCheckout
            {
                bookingDate = DateTime.Now,
                StartDate = checkin,
                EndDate = checkout,
                DurationDays = duration.Days                
            };

            
            using (AccommodationDetailsPage accommDetailsPage = new AccommodationDetailsPage(selectedAccommodation, selectedRooms, accommodationCheckout))
            {
                if (accommDetailsPage.ShowDialog() == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }            
        }

        private void lblAccommLocation_Click(object sender, EventArgs e)
        {

        }
    }
}

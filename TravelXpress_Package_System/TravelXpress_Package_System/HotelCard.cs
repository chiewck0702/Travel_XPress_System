using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelXpress_Package_System
{
    public partial class HotelOutput: UserControl
    {        
        public HotelOutput()
        {
            InitializeComponent();
        }

        private HotelList selectedAccommodation;
        private RoomDetails RoomDetails;

        public void SetHotelData(string id, string name, string location, float rating, string facilities)
        {
            lblAccommName.Text = name;
            lblAccommLocation.Text = location;
            lblAccommRating.Text = rating.ToString("0.0") + " / 10";            

            string facilitiesList = "";            
            string[] facilitiesArray = facilities.Split(',');
            foreach (string facility in facilitiesArray)
            {
                facilitiesList += "> " + facility.Trim() + Environment.NewLine;
            }
            lblFacilitiesList.Text = facilitiesList;

            selectedAccommodation = new HotelList
            {
                AccomID = id,
                AccomName = name,
                AccomLocation = location,
                Rating = rating,
                AccomFacilities = facilitiesList
            };
            
            string selectedImagePath = "";

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (name.ToLower().Contains("cats"))
                pictureBox1.Image = Properties.Resources.catsHotel;
            else if (name.ToLower().Contains("luna"))
                pictureBox1.Image = Properties.Resources.luna_hotel;
            else if (name.ToLower().Contains("tropicana"))
                pictureBox1.Image = Properties.Resources.tropicanaHotel;           

            string fullPath = Path.Combine(Application.StartupPath, selectedImagePath);            

        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (AccommodationBookingPage accommodationBookingPage = new AccommodationBookingPage(selectedAccommodation))
            {
                if (accommodationBookingPage.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show("Returned from Accommodation Payment.");
                }
            }            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

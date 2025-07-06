using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Net.NetworkInformation;

namespace TravelXpress_Package_System
{
    public partial class RoomControl: UserControl
    {
        string[] imagePath = {
                "Image/Single bed.png",
                "Image/King bed.png",
                "Image/Family room.png"
            };
        private RoomDetails _roomDetails;
        public RoomControl()
        {
            InitializeComponent();
        }

        public void SetRoomData(RoomDetails room)        
        {
            _roomDetails = room;

            lblRoomType.Text = room.Type;
            lblBedType.Text = room.RBedType;

            string amenitiesList = "";
            string[] amenitiesArray = room.RAmenities.Split(',');
            foreach (string facility in amenitiesArray)
            {
                amenitiesList += "> " + facility.Trim() + Environment.NewLine;
            }
            lblRoomAmenitiesList.Text = amenitiesList;            

            string facilitiesList = "";
            string[] facilitiesArray = room.RFacilities.Split(',');
            foreach (string facility in facilitiesArray)
            {
                facilitiesList += "> " + facility.Trim() + Environment.NewLine;
            }
            lblRoomFacilitiesList.Text = facilitiesList;            

            lblQuantPerNight.Text = "RM " + room.PricePerNight.ToString("0.00");

            cbBxQuantity.Items.Clear();
            for (int i = 0; i <= 5; i++)
            {
                cbBxQuantity.Items.Add(i);
            }

            string selectedImagePath = "";

            if (room.Type.Contains("Single"))
                selectedImagePath = imagePath[0];
            else if (room.Type.Contains("King"))
                selectedImagePath = imagePath[1];
            else if (room.Type.Contains("Family"))
                selectedImagePath = imagePath[2];

            if (System.IO.File.Exists(selectedImagePath))
            {
                pictureBox1.Image = Image.FromFile(selectedImagePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }            
        }

        public RoomDetails GetSelectedRoom()
        {
            int selectedQuantity = 0;

            if (cbBxQuantity.SelectedItem != null)
            {
                int.TryParse(cbBxQuantity.SelectedItem.ToString(), out selectedQuantity);
            }

            _roomDetails.NoOfRooms = selectedQuantity;
            return _roomDetails;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cbBxQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

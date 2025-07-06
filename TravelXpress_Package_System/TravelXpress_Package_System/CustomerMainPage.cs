using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelXpress_Package_System
{
    public partial class CustomerMainPage : Form
    {
        SeatDetail seatDetail = new SeatDetail();
        public CustomerMainPage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //TourPackageForm tourPackageForm = new TourPackageForm();
            //tourPackageForm.ShowDialog();
            using (TourPackageForm tourPackageForm = new TourPackageForm())
            {
                if (tourPackageForm.ShowDialog() == DialogResult.OK)
                {
                    // You could refresh the customerMainPageForm data here if needed
                    MessageBox.Show("Returned from successful booking.");
                }
            }
        }

        private void buttonTicket_Click(object sender, EventArgs e)
        {
            TicketBookingForm ticketBookingForm = new TicketBookingForm(seatDetail);
            this.Hide();
            ticketBookingForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccommodationAvailabilityPage accommAvailabilityPage = new AccommodationAvailabilityPage();
            accommAvailabilityPage.ShowDialog();
        }

        private void CustomerMainPage_Load(object sender, EventArgs e)
        {

        }
    }
}

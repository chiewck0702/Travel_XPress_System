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
    public partial class AdminMainPage : Form
    {
        public AdminMainPage()
        {
            InitializeComponent();
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            AdminManagementPage adminManagementPage = new AdminManagementPage();
            adminManagementPage.Show();
        }

        private void buttonPackage_Click(object sender, EventArgs e)
        {
            AdminBookingStatus adminBookingStatus = new AdminBookingStatus();
            adminBookingStatus.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminAccomodationPage adminAccomodationPage = new AdminAccomodationPage();
            adminAccomodationPage.Show();
        }
    }
}

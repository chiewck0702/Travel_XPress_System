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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerMainPage customerMainPage = new CustomerMainPage();
            customerMainPage.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminLoginPage adminLoginPage = new AdminLoginPage();
            adminLoginPage.ShowDialog();
        }
    }
}

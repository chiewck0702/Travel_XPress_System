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
    
    public partial class AdminLoginPage : Form
    {
        public ConnectionClass connectionClass;
        public AdminLoginPage()
        {
            InitializeComponent();
            connectionClass = new ConnectionClass();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string adminID = tbID.Text.Trim();
            string password = tbPassword.Text;

            if (string.IsNullOrEmpty(adminID) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both Admin ID and Password.");
                return;
            }

            string connectionString = connectionClass.connectionString; 



            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM AdminDetails WHERE AdminID = @AdminID AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@AdminID", int.Parse(adminID)); // AdminID 是 INT
                        cmd.Parameters.AddWithValue("@Password", password);

                        int count = (int)cmd.ExecuteScalar();

                        if (count == 1)
                        {
                            MessageBox.Show("Login successful!");
                            AdminMainPage adminMainPage = new AdminMainPage();
                            adminMainPage.Show();
                        }
                        else
                        {
                            MessageBox.Show("Admin ID or Password is incorrect.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        private void AdminLoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}

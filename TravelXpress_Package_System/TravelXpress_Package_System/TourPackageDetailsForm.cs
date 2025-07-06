using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelXpress_Package_System.Module;

namespace TravelXpress_Package_System
{
    public partial class TourPackageDetailsForm : Form
    {
        public int packageType;
        public ConnectionClass connectionClass;
        public TourPackageDetailsForm(int packageType)
        {
            InitializeComponent();
            this.packageType = packageType;
            connectionClass = new ConnectionClass();
            getDataFromDB();
        }

        void getDataFromDB()
        {
            string connectionString = connectionClass.connectionString;
            string query = "SELECT * FROM ImagePath WHERE PackageID = @PackageID AND imagePath LIKE '%itinerary%'";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PackageID", packageType);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "ImagePath");

                var data = dataSet.Tables["ImagePath"];
                if (data.Rows.Count > 0)
                {
                    pictureBoxItinerary.Image = Image.FromFile(data.Rows[0]["imagePath"].ToString());
                }
            }
;
            string query2 = "SELECT p.PackageName, p.FromLocation, p.ToLocation, a.AccomName, p.DurationDays, p.Price, p.Description " +
                "FROM Package p JOIN Accommodation a ON p.AccomID = a.AccomID WHERE p.PackageID = @PackageID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query2, connection);
                command.Parameters.AddWithValue("@PackageID", packageType);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Package");

                var data = dataSet.Tables["Package"];
                if (data.Rows.Count > 0)
                {
                    labelPackageDetails.Text = data.Rows[0]["PackageName"].ToString();
                    labelPackageDetails.Text += '\n' + "From: " + data.Rows[0]["FromLocation"].ToString();
                    labelPackageDetails.Text += '\n' + "To: " + data.Rows[0]["ToLocation"].ToString();
                    labelPackageDetails.Text += '\n' + "Transport: Bus";
                    labelPackageDetails.Text += '\n' + "Accomodation: " + data.Rows[0]["AccomName"].ToString();
                    var duration = int.Parse(data.Rows[0]["DurationDays"].ToString());
                    labelPackageDetails.Text += '\n' + "Duration: " + duration + " Days " + (duration - 1) + " Night ";
                    labelPackageDetails.Text += '\n' + "Price: RM " + data.Rows[0]["Price"].ToString() + " per pax";
                    labelPackageDetails.Text += '\n' + "Special Attraction: " + data.Rows[0]["Description"].ToString();
                    //                    Package 1
                    //From: Selangor
                    //To: Melaka
                    //Transport: Bus
                    //Accomodation: CATS Hotel
                    //Duration: 3 Days 2 Night
                    //Price: RM 1000.00 per pax
                    //Special Attraction: A'Famosa, The Stadthuys, Jonker Street

                }
            }
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            using (CheckoutForm checkoutform = new CheckoutForm(packageType))
            {
                if (checkoutform.ShowDialog() == DialogResult.OK)
                {
                    // Booking was successful, now close this form too
                    this.DialogResult = DialogResult.OK; // Optional
                    this.Close();
                }
            }
        }
    }
}

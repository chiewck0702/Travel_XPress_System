using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelXpress_Package_System.Module;

namespace TravelXpress_Package_System
{
    public partial class TourPackageForm : Form
    {
        public ConnectionClass connectionClass;
        public TourPackageForm()
        {
            InitializeComponent();
            connectionClass = new ConnectionClass();

            //getDataFromDB();
        }

        public int packageID;
        public string packageDescription;

        void getDataFromDB()
        {
            string connectionString = connectionClass.connectionString;
            string query = "SELECT p.PackageName, p.FromLocation, p.ToLocation, a.AccomName, p.DurationDays, p.Price, p.Description " +
                "FROM Package p JOIN Accommodation a ON p.AccomID = a.AccomID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Package");

                var data = dataSet.Tables["Package"];
                if (data.Rows.Count > 0)
                {
                    List<Label> labels = new List<Label> { label1, label2, label3, label4, label5};
                    for (int i = 0; i < 5; i++)
                    {
                        packageDescription = data.Rows[i]["PackageName"].ToString();
                        packageDescription += '\n' + "From: " + data.Rows[i]["FromLocation"].ToString();
                        packageDescription += '\n' + "To: " + data.Rows[i]["ToLocation"].ToString();
                        packageDescription += '\n' + "Transport: Bus";
                        packageDescription += '\n' + "Accomodation: " + data.Rows[i]["AccomName"].ToString();
                        var duration = int.Parse(data.Rows[i]["DurationDays"].ToString());
                        packageDescription += '\n' + "Duration: " + duration + " Days " + (duration - 1) + " Night ";
                        packageDescription += '\n' + "Price: RM " + data.Rows[i]["Price"].ToString() + " per pax";
                        packageDescription += '\n' + "Special Attraction: " + data.Rows[i]["Description"].ToString();
                        
                        labels[i].Text = packageDescription;
                    }
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
        

        private void button1_Click(object sender, EventArgs e)
        {
            packageID = 1;
            //CheckoutForm checkoutform = new CheckoutForm(packageID);
            //checkoutform.ShowDialog();
            goCkeckoutForm(packageID);
        }

        void goCkeckoutForm(int packageID)
        {
            using (CheckoutForm checkoutform = new CheckoutForm(packageID))
            {
                if (checkoutform.ShowDialog() == DialogResult.OK)
                {
                    // Booking was successful, now close this form too
                    this.DialogResult = DialogResult.OK; // Optional
                    this.Close();
                }
            }
        }

        private void buttonCheckout2_Click(object sender, EventArgs e)
        {
            packageID = 2;
            goCkeckoutForm(packageID);
        }

        private void buttonCheckout3_Click(object sender, EventArgs e)
        {
            packageID = 3;
            goCkeckoutForm(packageID);
        }

        private void buttonCheckout4_Click(object sender, EventArgs e)
        {
            packageID = 4;
            goCkeckoutForm(packageID);
        }

        private void buttonCheckout5_Click(object sender, EventArgs e)
        {
            packageID = 5;
            goCkeckoutForm(packageID);
        }

        private void linkLabelMorDetails1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            packageID = 1;
            goPackageDetailForm(packageID);
        }

        private void linkLabelMorDetails2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            packageID = 2;
            goPackageDetailForm(packageID);
        }

        private void linkLabelMorDetails3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            packageID = 3;
            goPackageDetailForm(packageID);
        }

        private void linkLabelMorDetails4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            packageID = 4;
            goPackageDetailForm(packageID);
        }

        private void linkLabelMorDetails5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            packageID = 5;
            goPackageDetailForm(packageID);
        }

        void goPackageDetailForm(int packageID)
        {
            using (TourPackageDetailsForm tourPackageDetailsForm = new TourPackageDetailsForm(packageID))
            {
                if (tourPackageDetailsForm.ShowDialog() == DialogResult.OK)
                {
                    // Booking was successful, now close this form too
                    this.DialogResult = DialogResult.OK; // Optional
                    this.Close();
                }
            }
        }
    }
}

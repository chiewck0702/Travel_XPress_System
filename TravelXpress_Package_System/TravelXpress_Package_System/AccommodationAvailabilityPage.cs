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
using System.Xml;
using System.Xml.Linq;
using TravelXpress_Package_System.Module;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TravelXpress_Package_System
{
    public partial class AccommodationAvailabilityPage: Form
    {
        private SqlConnection connection;
        private ConnectionClass connectionClass;
        private SqlDataAdapter dataAdapter;
        private DataSet dataSet;
        private RoomDetails roomDetails;
        public AccommodationAvailabilityPage()
        {
            InitializeComponent();

            connectionClass = new ConnectionClass();

            string connectionString = connectionClass.connectionString;
            connection = new SqlConnection(connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //AccommodationBookingPage accommBookingPage = new AccommodationBookingPage();
            //accommBookingPage.ShowDialog();
        }

        private void AccommodationAvailabilityPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'travelXpressDataSet.Accommodation' table. You can move, or remove it, as needed.
            //this.accommodationTableAdapter.Fill(this.travelXpressDataSet.Accommodation);

            LoadHotels();
            LoadHotelsbyStates();        
            LoadHotelsbyRating();
        }

        private void LoadHotels()
        {
            flowLayoutPanel1.Controls.Clear();

            string selectState = cbBoxStates.SelectedItem?.ToString();
            string selectRating = cbBoxRating.SelectedItem?.ToString();

            string query = "SELECT AccomID, AccomName, Location, Rating, AccomFacilities, State FROM Accommodation";

            List<string> conditions = new List<string>();           

            if (!string.IsNullOrEmpty(selectState) && selectState != "All")
            {
                conditions.Add("State = @State");
            }
            else
            {

            }

            if (conditions.Count > 0)
                query += " WHERE " + string.Join(" AND ", conditions);

            if (selectRating == "Rating - Low to High")
                query += " ORDER BY Rating ASC";

            if (selectRating == "Rating - High to Low")
                query += " ORDER BY Rating DESC";

            string connectionString = connectionClass.connectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);

                if (!string.IsNullOrEmpty(selectState))
                    cmd.Parameters.AddWithValue("@State", selectState);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    HotelOutput card = new HotelOutput();

                    card.SetHotelData(
                        reader["AccomID"].ToString(),
                        reader["AccomName"].ToString(),
                        reader["Location"].ToString(),                        
                        Convert.ToSingle(reader["Rating"]),
                        reader["AccomFacilities"].ToString()                        
                    );                                      

                    flowLayoutPanel1.Controls.Add(card);
                }

                reader.Close();
            }
        }

        private void LoadHotelsbyStates()
        {
            cbBoxStates.Items.Clear();
            cbBoxStates.Items.Add("All");

            string query = "SELECT DISTINCT State FROM Accommodation";
            string connectionString = connectionClass.connectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cbBoxStates.Items.Add(reader["State"].ToString());
                }
                reader.Close();
            }            
        }

        private void LoadHotelsbyRating()
        {
            cbBoxRating.Items.Clear();
            cbBoxRating.Items.Add("Rating - Low to High");
            cbBoxRating.Items.Add("Rating - High to Low");
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            CustomerMainPage customerMainPage = new CustomerMainPage();
            this.Hide();
            customerMainPage.ShowDialog();
        }

        private void SEARCH_Click(object sender, EventArgs e)
        {
            LoadHotels();
        }

        private void cbBoxRating_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadHotels();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {            
            CustomerMainPage customerMainPage = new CustomerMainPage();
            this.Hide();
            customerMainPage.ShowDialog();
        }
    }
}

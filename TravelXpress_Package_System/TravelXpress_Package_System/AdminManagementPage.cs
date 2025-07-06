using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelXpress_Package_System.Module;

namespace TravelXpress_Package_System
{
    public partial class AdminManagementPage : Form
    {
        public ConnectionClass connectionClass;
        private int currentIndex = 0;
        private GroupBox[] groupBoxes;
        public AdminManagementPage()
        {
            InitializeComponent();
            connectionClass = new ConnectionClass();
            groupBoxes = new GroupBox[] { groupBox1, groupBox2,groupBox3 };
            ShowGroupBox(currentIndex);
        }

        private void ShowGroupBox(int index)
        {
            for (int i = 0; i < groupBoxes.Length; i++)
            {
                groupBoxes[i].Visible = (i == index);
            }

            btnPrevious.Enabled = index > 0;
            btnNext.Enabled = index < groupBoxes.Length - 1;

            if (index == 1)
            {
                LoadSecondGroupData();
                LoadBusIDs();
                LoadRouteIDs();
                tbTripID.Text = GenerateNextID("Trip", "TripID", "T", 4);
            }

            if (index == 2)
            {
                LoadThirdGroupData();
                LoadTripIDs();
                tbTicketID.Text = GenerateNextID("Ticket", "TicketID", "", 1);
            }
        }

        private void LoadSecondGroupData()
        {
            string query = "SELECT * FROM Trip"; 
            using (SqlConnection conn = new SqlConnection(connectionClass.connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewTrip.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading trip data: " + ex.Message);
                }
            }
        }

        private void LoadThirdGroupData()
        {
            string query = "SELECT * FROM Ticket";
            using (SqlConnection conn = new SqlConnection(connectionClass.connectionString))
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewTicket.DataSource = dt; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading ticket data: " + ex.Message);
                }
            }
        }


        private void AdminManagementPage_Load(object sender, EventArgs e)
        {
            tbRouteID.Text = GenerateNextID("RoutePath", "RouteID", "R", 3);
            string connectionString = connectionClass.connectionString;
            string queryRoute = "SELECT RouteID,Origin,Destination,EstimatedDuration,distance FROM RoutePath";

            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(queryRoute, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridViewRoute.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading route data: " + ex.Message);
                }
            }
        }

        private string GenerateNextID(string tableName, string idColumn, string prefix, int padLength)
        {
            string query = $"SELECT MAX({idColumn}) FROM {tableName}";
            using (SqlConnection conn = new SqlConnection(connectionClass.connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value && result != null)
                    {
                        string lastId = result.ToString(); 
                        string numericPart = lastId.Substring(prefix.Length); 
                        if (int.TryParse(numericPart, out int number))
                        {
                            number++;
                            return prefix + number.ToString().PadLeft(padLength, '0');
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error generating ID: " + ex.Message);
                }
            }

            return prefix + "001".PadLeft(padLength, '0');
        }


        private void LoadBusIDs()
        {
            string query = "SELECT BusID FROM BusDetails"; 

            using (SqlConnection conn = new SqlConnection(connectionClass.connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cbBusID.Items.Clear(); 

                    while (reader.Read())
                    {
                        cbBusID.Items.Add(reader["BusID"].ToString());
                    }

                    if (cbBusID.Items.Count > 0)
                    {
                        cbBusID.SelectedIndex = 0; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Bus IDs: " + ex.Message);
                }
            }
        }
        private void LoadRouteIDs()
        {
            string query = "SELECT RouteID FROM RoutePath";

            using (SqlConnection conn = new SqlConnection(connectionClass.connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cbRouteID.Items.Clear();

                    while (reader.Read())
                    {
                        cbRouteID.Items.Add(reader["RouteID"].ToString());
                    }

                    if (cbRouteID.Items.Count > 0)
                    {
                        cbRouteID.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Route IDs: " + ex.Message);
                }
            }
        }

        private void LoadTripIDs()
        {
            string query = "SELECT TripID FROM Trip";

            using (SqlConnection conn = new SqlConnection(connectionClass.connectionString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cbTripId.Items.Clear();

                    while (reader.Read())
                    {
                        cbTripId.Items.Add(reader["TripID"].ToString());
                    }

                    if (cbTripId.Items.Count > 0)
                    {
                        cbTripId.SelectedIndex = 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Trip IDs: " + ex.Message);
                }
            }
        }

        private void btnInsertR_Click(object sender, EventArgs e)
        {
            if (ValidateRouteInput())
            {
                string query = "INSERT INTO RoutePath (RouteID, Origin, Destination, EstimatedDuration, Distance) VALUES (@RouteID, @Origin, @Destination, @EstimatedDuration, @Distance)";
                using (SqlCommand command = new SqlCommand(query, new SqlConnection(connectionClass.connectionString)))
                {
                    command.Parameters.AddWithValue("@RouteID",tbRouteID.Text);
                    command.Parameters.AddWithValue("@Origin", tbOrigin.Text);
                    command.Parameters.AddWithValue("@Destination", tbDestination.Text);
                    command.Parameters.AddWithValue("@EstimatedDuration",tbDuration.Text);
                    command.Parameters.AddWithValue("@Distance", double.Parse(tbDistance.Text));
                    try
                    {
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Route added successfully.");
                        ClearRouteInputFields();
                        AdminManagementPage_Load(sender, e); 
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error inserting route: " + ex.Message);
                    }
                }
            }
        }

        private bool ValidateRouteInput()
        {
            if(string.IsNullOrEmpty(tbRouteID.Text)||string.IsNullOrEmpty(tbOrigin.Text) || string.IsNullOrEmpty(tbDestination.Text) ||
                string.IsNullOrEmpty(tbDuration.Text) || string.IsNullOrEmpty(tbDistance.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }
            if (!double.TryParse(tbDistance.Text, out _))
            {
                MessageBox.Show("Distance must be numeric.");
                return false;
            }
            return true;
        }
        private bool ValidateTripInput()
        {
            if (string.IsNullOrEmpty(tbStatusT.Text) || string.IsNullOrEmpty(tbTripID.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }
            
            return true;
        }

       

        private bool ValidateTicketInput()
        {
            if (string.IsNullOrEmpty(tbTicketID.Text) || string.IsNullOrEmpty(tbPrice.Text) || string.IsNullOrEmpty(tbBoarding.Text) ||
                string.IsNullOrEmpty(tbDropOff.Text) || string.IsNullOrEmpty(tbStatusTr.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }
            return true;
        }
        private void ClearRouteInputFields()
        {
            tbRouteID.Clear();
            tbOrigin.Clear();
            tbDestination.Clear();
            tbDuration.Clear();
            tbDistance.Clear();
        }

        private void ClearTripFields()
        {
            tbTripID.Clear();
            cbBusID.SelectedIndex = -1;
            cbRouteID.SelectedIndex = -1;
            pickerDepartureDate.Value = DateTime.Now;
            pickerDepartureTime.Value = DateTime.Now;
            pickerArrivalTime.Value = DateTime.Now;
            tbStatusT.Clear();
        }

        private void ClearTicketFields()
        {
            tbTicketID.Clear();
            cbTripId.SelectedIndex = -1;
            tbBoarding.Clear();
            tbDropOff.Clear();
            tbStatusTr.Clear();
            tbPrice.Clear();
        }
            
    

        private void btnUpdateR_Click(object sender, EventArgs e)
        {
            if (ValidateRouteInput())
            {
                string query = "UPDATE RoutePath SET Origin = @Origin, Destination = @Destination, EstimatedDuration = @EstimatedDuration, Distance = @Distance WHERE RouteID = @RouteID";

                using (SqlCommand command = new SqlCommand(query, new SqlConnection(connectionClass.connectionString)))
                {
                    command.Parameters.AddWithValue("@RouteID", tbRouteID.Text);
                    command.Parameters.AddWithValue("@Origin", tbOrigin.Text);
                    command.Parameters.AddWithValue("@Destination", tbDestination.Text);
                    command.Parameters.AddWithValue("@EstimatedDuration", tbDuration.Text);
                    command.Parameters.AddWithValue("@Distance", double.Parse(tbDistance.Text));

                    try
                    {
                        command.Connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Route updated successfully.");
                            ClearRouteInputFields();
                            AdminManagementPage_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("No route found with the specified RouteID.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating route: " + ex.Message);
                    }
                }
            }
        }

       

        private void dataGridViewRoute_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewRoute.Rows[e.RowIndex];
                tbRouteID.Text = row.Cells["RouteID"].Value.ToString();
                tbOrigin.Text = row.Cells["Origin"].Value.ToString();
                tbDestination.Text = row.Cells["Destination"].Value.ToString();
                tbDuration.Text = row.Cells["EstimatedDuration"].Value.ToString();
                tbDistance.Text = row.Cells["distance"].Value.ToString();
            }
        }

        private void btnDeleteR_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbRouteID.Text))
            {
                MessageBox.Show("Please select a route to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this route?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM RoutePath WHERE RouteID = @RouteID";

                using (SqlCommand command = new SqlCommand(query, new SqlConnection(connectionClass.connectionString)))
                {
                    command.Parameters.AddWithValue("@RouteID", tbRouteID.Text);

                    try
                    {
                        command.Connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Route deleted successfully.");
                            ClearRouteInputFields();
                            AdminManagementPage_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("No route found with the specified RouteID.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting route: " + ex.Message);
                    }
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                ShowGroupBox(currentIndex);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < groupBoxes.Length - 1)
            {
                currentIndex++;
                ShowGroupBox(currentIndex);
            }
        }

        private void btnInsertT_Click(object sender, EventArgs e)
        {
            string selectedBusID = cbBusID.SelectedItem.ToString();
            string selectedRouteID = cbRouteID.SelectedItem.ToString();
            if (string.IsNullOrEmpty(selectedBusID) || string.IsNullOrEmpty(selectedRouteID))
            {
                MessageBox.Show("Please select both a Bus ID and Route ID.");
                return;
            }

            if (ValidateTripInput())
            {
                DateTime departureDate = pickerDepartureDate.Value.Date;
                DateTime departureDateTime = departureDate + pickerDepartureTime.Value.TimeOfDay;
                DateTime arrivalDateTime = departureDate + pickerArrivalTime.Value.TimeOfDay;

                string query = "INSERT INTO Trip (TripID,DepartureDate, DepartureTime, ArrivalTime, Status,BusID,RouteID) VALUES (@TripID,@DepartureDate, @DepartureTime, @ArrivalTime, @Status, @BusID,@RouteID)";
                using (SqlCommand command = new SqlCommand(query, new SqlConnection(connectionClass.connectionString)))
                {
                    command.Parameters.AddWithValue("@TripID", tbTripID.Text);
                    command.Parameters.AddWithValue("@RouteID", selectedRouteID);
                    command.Parameters.AddWithValue("@BusID", selectedBusID);
                    command.Parameters.AddWithValue("@DepartureDate", pickerDepartureDate.Value.Date);
                    command.Parameters.AddWithValue("@DepartureTime", departureDateTime);
                    command.Parameters.AddWithValue("@ArrivalTime", arrivalDateTime);
                    command.Parameters.AddWithValue("@Status", tbStatusT.Text);
                    try
                    {
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Trip added successfully.");
                        ClearTripFields();
                        LoadSecondGroupData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error inserting trip: " + ex.Message);
                    }
                }
            }
        }

        private void btnUpdateT_Click(object sender, EventArgs e)
        {
            if (cbBusID.SelectedItem == null || cbRouteID.SelectedItem == null)
            {
                MessageBox.Show("Please select both a Bus ID and Route ID.");
                return;
            }

            string selectedBusID = cbBusID.SelectedItem.ToString();
            string selectedRouteID = cbRouteID.SelectedItem.ToString();

            if (string.IsNullOrEmpty(tbTripID.Text))
            {
                MessageBox.Show("Please enter Trip ID to update.");
                return;
            }

            DateTime departureDate = pickerDepartureDate.Value.Date;
            DateTime departureDateTime = departureDate + pickerDepartureTime.Value.TimeOfDay;
            DateTime arrivalDateTime = departureDate + pickerArrivalTime.Value.TimeOfDay;

            string query = "UPDATE Trip SET DepartureDate = @DepartureDate, DepartureTime = @DepartureTime, ArrivalTime = @ArrivalTime, Status = @Status, BusID = @BusID, RouteID = @RouteID WHERE TripID = @TripID";

            using (SqlCommand command = new SqlCommand(query, new SqlConnection(connectionClass.connectionString)))
            {
                command.Parameters.AddWithValue("@TripID", tbTripID.Text);
                command.Parameters.AddWithValue("@DepartureDate", pickerDepartureDate.Value.Date);
                command.Parameters.AddWithValue("@DepartureTime", departureDateTime);
                command.Parameters.AddWithValue("@ArrivalTime", arrivalDateTime);
                command.Parameters.AddWithValue("@Status", tbStatusT.Text);
                command.Parameters.AddWithValue("@BusID", selectedBusID);
                command.Parameters.AddWithValue("@RouteID", selectedRouteID);

                try
                {
                    command.Connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Trip updated successfully.");
                        ClearTripFields();
                        LoadSecondGroupData();
                    }
                    else
                    {
                        MessageBox.Show("No trip found with the specified TripID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating trip: " + ex.Message);
                }
            }
        }


        private void btnDeleteT_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTripID.Text))
            {
                MessageBox.Show("Please select a Trip ID to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this trip?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Trip WHERE TripID = @TripID";

                using (SqlCommand command = new SqlCommand(query, new SqlConnection(connectionClass.connectionString)))
                {
                    command.Parameters.AddWithValue("@TripID", tbTripID.Text);

                    try
                    {
                        command.Connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Trip deleted successfully.");
                            ClearTripFields();
                            LoadSecondGroupData();
                        }
                        else
                        {
                            MessageBox.Show("No trip found with the specified TripID.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting trip: " + ex.Message);
                    }
                }
            }
        }

        private void dataGridViewTrip_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewTrip.Rows[e.RowIndex];
                tbTripID.Text = row.Cells["TripID"].Value.ToString();
                pickerDepartureDate.Value = Convert.ToDateTime(row.Cells["DepartureDate"].Value);
                pickerDepartureTime.Value = Convert.ToDateTime(row.Cells["DepartureTime"].Value);
                pickerArrivalTime.Value = Convert.ToDateTime(row.Cells["ArrivalTime"].Value);
                tbStatusT.Text = row.Cells["Status"].Value.ToString();

                string busID = row.Cells["BusID"].Value.ToString();
                string routeID = row.Cells["RouteID"].Value.ToString();

                cbBusID.SelectedItem = busID;
                cbRouteID.SelectedItem = routeID;
            }
        }

        private void cbRouteID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRouteID = cbRouteID.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedRouteID)) return;

            string query = "SELECT EstimatedDuration FROM RoutePath WHERE RouteID = @RouteID";

            using (SqlConnection conn = new SqlConnection(connectionClass.connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@RouteID", selectedRouteID);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string durationStr = result.ToString(); 
                        TimeSpan estimatedDuration;

                        if (TimeSpan.TryParse(durationStr, out estimatedDuration))
                        {
                            pickerArrivalTime.Value = pickerDepartureTime.Value.Add(estimatedDuration);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading Estimated Duration: " + ex.Message);
                }
            }
        }

        private void pickerDepartureTime_ValueChanged(object sender, EventArgs e)
        {
            UpdateArrivalTimeBasedOnDuration();
        }

        

private void UpdateArrivalTimeBasedOnDuration()
    {
        string selectedRouteID = cbRouteID.SelectedItem?.ToString();
        if (string.IsNullOrEmpty(selectedRouteID)) return;

        string query = "SELECT EstimatedDuration FROM RoutePath WHERE RouteID = @RouteID";

        using (SqlConnection conn = new SqlConnection(connectionClass.connectionString))
        using (SqlCommand cmd = new SqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@RouteID", selectedRouteID);

            try
            {
                conn.Open();
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string durationStr = result.ToString().ToLower(); 
                    int hours = 0, minutes = 0;

                    Match matchHour = Regex.Match(durationStr, @"(\d+)\s*h");
                    if (matchHour.Success)
                    {
                        hours = int.Parse(matchHour.Groups[1].Value);
                    }

                    Match matchMin = Regex.Match(durationStr, @"(\d+)\s*(m|min)");
                    if (matchMin.Success)
                    {
                        minutes = int.Parse(matchMin.Groups[1].Value);
                    }

                    TimeSpan estimatedDuration = new TimeSpan(hours, minutes, 0);
                    pickerArrivalTime.Value = pickerDepartureTime.Value.Add(estimatedDuration);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error parsing Estimated Duration: " + ex.Message);
            }
        }
    }

        private void btnInsertTr_Click(object sender, EventArgs e)
        {
            string selectedTripID = cbTripId.SelectedItem.ToString();
            if (string.IsNullOrEmpty(selectedTripID))
            {
                MessageBox.Show("Please select Trip ID.");
                return;
            }
            if (ValidateTicketInput())
            {
                string query = "INSERT INTO Ticket (TicketID, TripID, Price, BoardingPoint, DropOffPoint,Status) VALUES (@TicketID, @TripID, @Price, @BoardingPoint,@DropOffPoint, @Status)";
                using (SqlCommand command = new SqlCommand(query, new SqlConnection(connectionClass.connectionString)))
                {
                    command.Parameters.AddWithValue("@TicketID", tbTicketID.Text);
                    command.Parameters.AddWithValue("@TripID", cbTripId.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@BoardingPoint", tbBoarding.Text);
                    command.Parameters.AddWithValue("@DropOffPoint", tbDropOff.Text);
                    command.Parameters.AddWithValue("@Status", tbStatusTr.Text);
                    command.Parameters.AddWithValue("@Price", decimal.Parse(tbPrice.Text));
                    try
                    {
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Ticket added successfully.");
                        ClearTicketFields();
                        LoadThirdGroupData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error inserting ticket: " + ex.Message);
                    }
                }

                
            }
        }

        private void btnUpdateTr_Click(object sender, EventArgs e)
        {
            string selectedTripID = cbTripId.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedTripID))
            {
                MessageBox.Show("Please select Trip ID.");
                return;
            }

            if (ValidateTicketInput())
            {
                string query = "UPDATE Ticket SET TripID = @TripID, Price = @Price, BoardingPoint = @BoardingPoint, DropOffPoint = @DropOffPoint, Status = @Status WHERE TicketID = @TicketID";
                using (SqlCommand command = new SqlCommand(query, new SqlConnection(connectionClass.connectionString)))
                {
                    command.Parameters.AddWithValue("@TripID", selectedTripID);
                    command.Parameters.AddWithValue("@BoardingPoint", tbBoarding.Text);
                    command.Parameters.AddWithValue("@DropOffPoint", tbDropOff.Text);
                    command.Parameters.AddWithValue("@Status", tbStatusTr.Text);
                    command.Parameters.AddWithValue("@Price", decimal.Parse(tbPrice.Text));
                    command.Parameters.AddWithValue("@TicketID", tbTicketID.Text);

                    try
                    {
                        command.Connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ticket updated successfully.");
                            ClearTicketFields();
                            LoadThirdGroupData();
                        }
                        else
                        {
                            MessageBox.Show("Ticket ID not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating ticket: " + ex.Message);
                    }
                }
            }
        }


        private void btnDeleteTr_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbTicketID.Text))
            {
                MessageBox.Show("Please enter Ticket ID to delete.");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this ticket?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Ticket WHERE TicketID = @TicketID";
                using (SqlCommand command = new SqlCommand(query, new SqlConnection(connectionClass.connectionString)))
                {
                    command.Parameters.AddWithValue("@TicketID", tbTicketID.Text);

                    try
                    {
                        command.Connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Ticket deleted successfully.");
                            ClearTicketFields();
                            LoadThirdGroupData();
                        }
                        else
                        {
                            MessageBox.Show("Ticket ID not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting ticket: " + ex.Message);
                    }
                }
            }
        }

        private void dataGridViewTicket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewTicket.Rows[e.RowIndex];
                tbTicketID.Text = row.Cells["TicketID"].Value.ToString();
                cbTripId.SelectedItem = row.Cells["TripID"].Value.ToString();
                tbBoarding.Text = row.Cells["BoardingPoint"].Value.ToString();
                tbDropOff.Text = row.Cells["DropOffPoint"].Value.ToString();
                tbStatusTr.Text = row.Cells["Status"].Value.ToString();
                tbPrice.Text = row.Cells["Price"].Value.ToString();
            }
        }

    }
}








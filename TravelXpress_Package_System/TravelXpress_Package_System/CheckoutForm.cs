using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TravelXpress_Package_System.Module;

namespace TravelXpress_Package_System
{
    public partial class CheckoutForm : Form
    {
        public int packagetype;
        public int durationDays = 0;
        public double roomExtraSlotPrice = 25;
        public CustomerMemberDetails customerMemberDetails;
        public CustomerDetails customerDetails;
        public PackageCheckout PackageCheckout;
        public ConnectionClass connectionClass;
        public CheckoutForm(int packagetype)
        {
            InitializeComponent();
            this.packagetype = packagetype;
            this.customerMemberDetails = new CustomerMemberDetails();
            this.customerDetails = new CustomerDetails();
            this.PackageCheckout = new PackageCheckout();
            connectionClass = new ConnectionClass();

            groupBoxCustomerFamilyDetails.Hide();

            groupBoxCustomerFamilyDetails.Text = "Details for customer member 1: ";

            comboBoxTransport.SelectedIndex = 0;
            
            dateTimePickerFromDate.Value = DateTime.Today.Date;
            dateTimePickerFromDate.MinDate = DateTime.Today.Date;

            getDataFromDB();

            if (durationDays != 0)
            {
                dateTimePickerToDate.Value = DateTime.Today.Date.AddDays(durationDays - 1);
                dateTimePickerToDate.MinDate = DateTime.Today.Date.AddDays(durationDays - 1);
            }
        }

        public double price = 0;

        void getDataFromDB()
        {
            string connectionString = connectionClass.connectionString;
            string query = "SELECT * FROM ImagePath WHERE PackageID = @PackageID AND imagePath NOT LIKE '%itinerary%' ORDER BY ImageID ASC";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@PackageID", packagetype);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "ImagePath");

                var data = dataSet.Tables["ImagePath"];
                if (data.Rows.Count > 1)
                {
                    Console.WriteLine(data.Rows.Count);
                    if (pictureBox1.Image != null)
                    {
                        pictureBox1.Image.Dispose(); // Free old image from memory
                    }
                    if (pictureBox2.Image != null)
                    {
                        pictureBox2.Image.Dispose(); // Free old image from memory
                    }
                    if (pictureBox3.Image != null)
                    {
                        pictureBox3.Image.Dispose(); // Free old image from memory
                    }

                    pictureBox1.Image = Image.FromFile(data.Rows[0]["imagePath"].ToString());
                    pictureBox2.Image = Image.FromFile(data.Rows[1]["imagePath"].ToString());
                    //Console.WriteLine(data.Rows[1]["imagePath"].ToString());
                    pictureBox3.Image = Image.FromFile(data.Rows[2]["imagePath"].ToString());
                }
            }

            string query2 = "SELECT * FROM Package WHERE PackageID = @PackageID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query2, connection);
                command.Parameters.AddWithValue("@PackageID", packagetype);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet, "Package");

                var data = dataSet.Tables["Package"];

                if (data.Rows.Count > 0)
                {
                    durationDays = int.Parse(data.Rows[0]["DurationDays"].ToString());
                    price = double.Parse(data.Rows[0]["Price"].ToString());
                    textBoxPackageFromLocation.Text = data.Rows[0]["FromLocation"].ToString();
                    textBoxPackageToLocation.Text = data.Rows[0]["ToLocation"].ToString();
                    textBoxPackageDuration.Text = data.Rows[0]["DurationDays"].ToString() + " days";
                    textBoxPackagePrice.Text = data.Rows[0]["Price"].ToString();
                }
            }
        }

        public List<CustomerMemberDetails> memberDetails = new List<CustomerMemberDetails>();

        public int customerMemberPax = 0;
        public int currentCustomerMemberNo = 0;

        private void radioButtonTrue_CheckedChanged(object sender, EventArgs e)
        {
            panel1.AutoScroll = false;
            if (radioButtonTrue.Checked)
            {
                if (!checkCustomerDetail())
                {
                    MessageBox.Show("Your details is not complete fill in");
                    radioButtonTrue.Checked = false;
                    return;
                }
                labelNumberPax.Visible = true;
                numericUpDownNumPax.Visible = true;
                buttonMemberPaxConfirm.Visible = true;
                buttonMemberPaxEdit.Visible = true;
            }
            else
            {
                labelNumberPax.Visible = false;
                numericUpDownNumPax.Visible = false;
                buttonMemberPaxConfirm.Visible = false;
                buttonMemberPaxEdit.Visible = false;
                groupBoxCustomerFamilyDetails.Hide();
                buttonConfirmCustomerMemberDetails.Visible = false;
                buttonEditCustomerMemberDetails.Visible = false;
            }
            panel1.AutoScroll = true;
        }

        private void buttonMemberPaxConfirm_Click(object sender, EventArgs e)
        {
            panel1.AutoScroll = false;
            groupBoxCustomerFamilyDetails.Show();
            groupBoxCustomerFamilyDetails.Enabled = true;
            buttonConfirmCustomerMemberDetails.Visible = true;
            buttonEditCustomerMemberDetails.Visible = true;
            panel1.AutoScroll = true;
            customerMemberPax = (int)numericUpDownNumPax.Value;
            currentCustomerMemberNo = 1;
            numericUpDownNumPax.Enabled = false;

            if (customerMemberPax == 1)
            {
                buttonNextPerson.Enabled = false;
            }
            else
            {
                buttonNextPerson.Enabled = true;
            }
            buttonPrevious.Enabled = false;
        }

        private void buttonMemberPaxEdit_Click(object sender, EventArgs e)
        {
            numericUpDownNumPax.Enabled = true;
        }

        private void buttonNextPerson_Click(object sender, EventArgs e)
        {
            if (!checkCustomerMemberDetails())
            {
                MessageBox.Show("The member details is not complete fill in");
            }
            else
            {
                if (memberDetails.Count + 1 == currentCustomerMemberNo)
                {
                    addNewMemberDetails();
                    clearMemberDetails();
                }
                else
                {
                    editCurrentMemberDetails();
                    clearMemberDetails();
                }
                currentCustomerMemberNo++;
                groupBoxCustomerFamilyDetails.Text = $"Details for customer member {currentCustomerMemberNo}: ";
                if (memberDetails.Count >= currentCustomerMemberNo)
                {
                    showCurrentMemberDetails();
                }
                buttonPrevious.Enabled = true;

                if (currentCustomerMemberNo == customerMemberPax)
                {
                    buttonNextPerson.Enabled = false;
                }
            }
        }

        void addNewMemberDetails()
        {
            var validNextID = "";
            if (memberDetails.Any())
            {
                var lastMemberindex = memberDetails.Count - 1;
                var lastMemberid = memberDetails[lastMemberindex].ID.Substring(1);
                int nextid = int.Parse(lastMemberid) + 1;
                validNextID = "C" + nextid.ToString("D4");
            }
            else
            {
                validNextID = "C0001";
            }
            memberDetails.Add(new CustomerMemberDetails
            {
                ID = validNextID,
                Name = textBoxCustomerMemberName.Text,
                IC = textBoxCustomerMemberIC.Text,
                Contact = textBoxCustomerMemberPhone.Text,
                Gender = radioButtonMale.Checked ? "Male" : "Female"
            });
            
        }
        
        void clearMemberDetails()
        {
            textBoxCustomerMemberName.Text = "";
            textBoxCustomerMemberIC.Text = "";
            textBoxCustomerMemberPhone.Text = "";
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
        }

        void showCurrentMemberDetails()
        {
            textBoxCustomerMemberName.Text = memberDetails[currentCustomerMemberNo - 1].Name;
            textBoxCustomerMemberIC.Text = memberDetails[currentCustomerMemberNo - 1].IC;
            textBoxCustomerMemberPhone.Text = memberDetails[currentCustomerMemberNo - 1].Contact;
            if (memberDetails[currentCustomerMemberNo - 1].Gender == "Male")
            {
                radioButtonMale.Checked = true;
            }
            else
            {
                radioButtonFemale.Checked = true;
            }
        }

        void editCurrentMemberDetails()
        {
            memberDetails[currentCustomerMemberNo - 1].Name = textBoxCustomerMemberName.Text;
            memberDetails[currentCustomerMemberNo - 1].IC = textBoxCustomerMemberIC.Text;
            memberDetails[currentCustomerMemberNo - 1].Contact = textBoxCustomerMemberPhone.Text;
            memberDetails[currentCustomerMemberNo - 1].Gender = radioButtonMale.Checked ? "Male" : "Female";
        }


        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (currentCustomerMemberNo > memberDetails.Count)
            {
                addNewMemberDetails();
            }
            else
            {
                editCurrentMemberDetails();
            }
            currentCustomerMemberNo--;
            groupBoxCustomerFamilyDetails.Text = $"Details for customer member {currentCustomerMemberNo}: ";
            buttonNextPerson.Enabled = true;

            if (currentCustomerMemberNo == 1)
            {
                buttonPrevious.Enabled = false;
            }
            showCurrentMemberDetails();
        }

        private void buttonConfirmCustomerMemberDetails_Click(object sender, EventArgs e)
        {
            if (currentCustomerMemberNo != customerMemberPax)
            {
                MessageBox.Show($"Your member {currentCustomerMemberNo + 1} details not yet fill in. Please fill in and click 'Next Person' button");
            }
            else if (!checkCustomerMemberDetails())
            {
                MessageBox.Show($"Your member {currentCustomerMemberNo} details not yet fill in complete.");
            }
            else
            {
                if (currentCustomerMemberNo > memberDetails.Count)
                {
                    addNewMemberDetails();
                }
                else
                {
                    editCurrentMemberDetails();
                }
                groupBoxCustomerFamilyDetails.Enabled = false;
            }
        }

        bool checkCustomerMemberDetails()
        {
            if (string.IsNullOrEmpty(textBoxCustomerMemberName.Text))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(textBoxCustomerMemberIC.Text))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(textBoxCustomerMemberPhone.Text))
            {
                return false;
            }
            else if (!radioButtonMale.Checked && !radioButtonFemale.Checked)
            {
                return false;
            }
            return true;
        }

        private void buttonEditCustomerMemberDetails_Click(object sender, EventArgs e)
        {
            groupBoxCustomerFamilyDetails.Enabled = true;
        }

        bool checkCustomerDetail()
        {
            if (string.IsNullOrEmpty(textBoxCustomerName.Text))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(textBoxCustomerEmail.Text))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(textBoxCustomerIC.Text))
            {
                return false;
            }
            else if (string.IsNullOrEmpty(textBoxCustomerContact.Text))
            {
                return false;
            }
            else if (!radioButtonTrue.Checked && !radioButtonFalse.Checked)
            {
                return false;
            }
            return true;
        }

        private void radioButtonFalse_CheckedChanged(object sender, EventArgs e)
        {            
            if (radioButtonFalse.Checked)
            {
                if (!checkCustomerDetail())
                {
                    MessageBox.Show("Your details is not complete fill in yet");
                    radioButtonFalse.Checked = false;
                    return;
                }
                panel1.ScrollControlIntoView(buttonCheckOut);
            }
        }

        private void checkBoxSingleBed_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSingleBed.Checked)
            {
                numericUpDownSingleBed.Visible = true;
            }
            else
            {
                numericUpDownSingleBed.Visible = false;
            }
        }

        private void checkBoxSingleRKingBed_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSingleRKingBed.Checked)
            {
                numericUpDownSingleRKingBed.Visible = true;
            }
            else
            {
                numericUpDownSingleRKingBed.Visible = false;
            }
        }

        private void checkBoxFamilyRoom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFamilyRoom.Checked)
            {
                numericUpDownFamilyRoom.Visible = true;
            }
            else
            {
                numericUpDownFamilyRoom.Visible = false;
            }
        }
        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(memberDetails.Count);
            int roomPax = checkRoomPax();
            if (!checkCustomerDetail())
            {
                MessageBox.Show($"Your details is not yet complete");
                return;
            }
            else if (!finalCheckCusMemberDetails())
            {
                if (buttonConfirmCustomerMemberDetails.Visible == false)
                {
                    MessageBox.Show("You not yet confirm the number of member you want to book. \nPlease click button Confirm to continue");
                    return;
                }
                else if (groupBoxCustomerFamilyDetails.Enabled == true)
                {
                    MessageBox.Show("You not yet confirm the member details. \nPlease click button Confirm to continue");
                    return;
                }
                MessageBox.Show("You are here");
                return;
            }
            else if (roomPax - (customerMemberPax + 1) < 0)
            {
                MessageBox.Show($"Not enough room booked! You are short by {roomPax}. \nPlease add more room to accomodate all {customerMemberPax + 1} people");
                return;
            }
            else
            {
                if (roomPax - (customerMemberPax + 1) > 0)
                {
                    DialogResult result = MessageBox.Show($"You have {customerMemberPax + 1} guest(s), but the rooms selected can hold up to {roomPax} people. " +
                        $"\nThis could lead to extra costs (RM {roomExtraSlotPrice:F2} per extra slot). \nDo you want to continue?",
                        "Room capacity warning",
                        MessageBoxButtons.YesNo);

                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
                customerDetails.Name = textBoxCustomerName.Text;
                customerDetails.IC = textBoxCustomerIC.Text;
                customerDetails.Contact = textBoxCustomerContact.Text;
                customerDetails.Email = textBoxCustomerEmail.Text;
                customerDetails.Gender = radioButtonCusMale.Checked ? "Male" : "Female";
                customerDetails.memberNum = radioButtonTrue.Checked ? (int)numericUpDownNumPax.Value : 0;

                PackageCheckout.CustomerDetails = customerDetails;

                if (customerDetails.memberNum != 0)
                {
                    PackageCheckout.CustomerMembersDetails = memberDetails;
                }

                PackageCheckout.PackageID = packagetype.ToString();
                PackageCheckout.bookingDate = DateTime.Today;
                PackageCheckout.StartDate = dateTimePickerFromDate.Value;
                PackageCheckout.EndDate = dateTimePickerToDate.Value;

                PackageCheckout.SelectedPackageRoom.singleBed = checkBoxSingleBed.Checked ? (int)numericUpDownSingleBed.Value : 0;
                PackageCheckout.SelectedPackageRoom.singleRKingBed = checkBoxSingleRKingBed.Checked ? (int)numericUpDownSingleRKingBed.Value : 0;
                PackageCheckout.SelectedPackageRoom.familyRoom = checkBoxFamilyRoom.Checked ? (int)numericUpDownFamilyRoom.Value : 0;

                PackageCheckout.numPax = customerDetails.memberNum + 1; // + 1 cause need to include customer itself
                PackageCheckout.packageAmount = PackageCheckout.numPax * price;
                if (roomPax - (customerMemberPax + 1) != 0)
                {
                    PackageCheckout.roomAmount = (roomPax - (customerMemberPax + 1)) * roomExtraSlotPrice;
                }
                PackageCheckout.totalAmount = PackageCheckout.packageAmount + PackageCheckout.roomAmount;

                //ChekourPaymentForm form = new ChekourPaymentForm(PackageCheckout);
                //form.ShowDialog();
                using (ChekourPaymentForm form = new ChekourPaymentForm(PackageCheckout))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        // Booking was successful, now close this form too
                        this.DialogResult = DialogResult.OK; // Optional
                        this.Close();
                    }
                }
            }
        }
        int checkRoomPax()
        {
            int singleBed = checkBoxSingleBed.Checked ? (int)numericUpDownSingleBed.Value : 0;
            int singleRKingBed = checkBoxSingleRKingBed.Checked ? (int)numericUpDownSingleRKingBed.Value * 2 : 0;
            int familyRoom = checkBoxFamilyRoom.Checked ? (int)numericUpDownFamilyRoom.Value * 4 : 0;

            int estimatedRoomPax = singleBed + singleRKingBed + familyRoom;

            return estimatedRoomPax;
        }

        bool finalCheckCusMemberDetails()
        {
            if (radioButtonTrue.Checked)
            {
                if (buttonConfirmCustomerMemberDetails.Visible == false)
                {
                    return false;
                }
                else if (groupBoxCustomerFamilyDetails.Enabled == true)
                {
                    return false;
                }
            }
            return true;
        }

        private void dateTimePickerFromDate_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerFromDate.Value < DateTime.Today)
            {
                MessageBox.Show("From date cannot less than today date");
                dateTimePickerFromDate.Value = DateTime.Today;
                return;
            }
            else if (durationDays != 0)
            {
                dateTimePickerToDate.Value = dateTimePickerFromDate.Value.AddDays(durationDays - 1);
            }
        }

        private void dateTimePickerToDate_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePickerToDate.Value < DateTime.Today)
            {
                MessageBox.Show("To date cannot less than today date");
                dateTimePickerToDate.Value = DateTime.Today.AddDays(durationDays - 1);
                return;
            }
            else if (durationDays != 0)
            {
                var newFromDate = dateTimePickerToDate.Value.AddDays(-durationDays + 1);

                if (newFromDate < DateTime.Today)
                {
                    MessageBox.Show("The selected end date with this duration results in a start date before today. Please choose a later end date", "Invalid date range");
                    dateTimePickerToDate.Value = DateTime.Today.AddDays(durationDays - 1);
                    return;
                }
                dateTimePickerFromDate.Value = newFromDate;
            }
        }
    }
}

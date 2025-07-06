namespace TravelXpress_Package_System
{
    partial class AdminManagementPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewRoute = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteR = new System.Windows.Forms.Button();
            this.btnUpdateR = new System.Windows.Forms.Button();
            this.btnInsertR = new System.Windows.Forms.Button();
            this.tbDistance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDuration = new System.Windows.Forms.TextBox();
            this.EstimatedT = new System.Windows.Forms.Label();
            this.tbDestination = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOrigin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbRouteID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbDropOff = new System.Windows.Forms.TextBox();
            this.tbBoarding = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.cbTripId = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnDeleteTr = new System.Windows.Forms.Button();
            this.btnUpdateTr = new System.Windows.Forms.Button();
            this.btnInsertTr = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.tbStatusTr = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbTicketID = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dataGridViewTicket = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbRouteID = new System.Windows.Forms.ComboBox();
            this.cbBusID = new System.Windows.Forms.ComboBox();
            this.pickerArrivalTime = new System.Windows.Forms.DateTimePicker();
            this.pickerDepartureTime = new System.Windows.Forms.DateTimePicker();
            this.pickerDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDeleteT = new System.Windows.Forms.Button();
            this.btnUpdateT = new System.Windows.Forms.Button();
            this.btnInsertT = new System.Windows.Forms.Button();
            this.tbBusIDT = new System.Windows.Forms.Label();
            this.tbStatusT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbTripID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridViewTrip = new System.Windows.Forms.DataGridView();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoute)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicket)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrip)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "Management";
            // 
            // dataGridViewRoute
            // 
            this.dataGridViewRoute.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewRoute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoute.Location = new System.Drawing.Point(39, 55);
            this.dataGridViewRoute.Name = "dataGridViewRoute";
            this.dataGridViewRoute.RowHeadersWidth = 51;
            this.dataGridViewRoute.RowTemplate.Height = 27;
            this.dataGridViewRoute.Size = new System.Drawing.Size(1083, 218);
            this.dataGridViewRoute.TabIndex = 1;
            this.dataGridViewRoute.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRoute_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteR);
            this.groupBox1.Controls.Add(this.btnUpdateR);
            this.groupBox1.Controls.Add(this.btnInsertR);
            this.groupBox1.Controls.Add(this.tbDistance);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbDuration);
            this.groupBox1.Controls.Add(this.EstimatedT);
            this.groupBox1.Controls.Add(this.tbDestination);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbOrigin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbRouteID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dataGridViewRoute);
            this.groupBox1.Location = new System.Drawing.Point(13, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1157, 547);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Route Path";
            // 
            // btnDeleteR
            // 
            this.btnDeleteR.BackColor = System.Drawing.Color.Red;
            this.btnDeleteR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteR.Location = new System.Drawing.Point(963, 455);
            this.btnDeleteR.Name = "btnDeleteR";
            this.btnDeleteR.Size = new System.Drawing.Size(188, 70);
            this.btnDeleteR.TabIndex = 14;
            this.btnDeleteR.Text = "Delete";
            this.btnDeleteR.UseVisualStyleBackColor = false;
            this.btnDeleteR.Click += new System.EventHandler(this.btnDeleteR_Click_1);
            // 
            // btnUpdateR
            // 
            this.btnUpdateR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdateR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateR.Location = new System.Drawing.Point(750, 455);
            this.btnUpdateR.Name = "btnUpdateR";
            this.btnUpdateR.Size = new System.Drawing.Size(188, 70);
            this.btnUpdateR.TabIndex = 13;
            this.btnUpdateR.Text = "Update";
            this.btnUpdateR.UseVisualStyleBackColor = false;
            this.btnUpdateR.Click += new System.EventHandler(this.btnUpdateR_Click);
            // 
            // btnInsertR
            // 
            this.btnInsertR.BackColor = System.Drawing.Color.Green;
            this.btnInsertR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsertR.Location = new System.Drawing.Point(532, 455);
            this.btnInsertR.Name = "btnInsertR";
            this.btnInsertR.Size = new System.Drawing.Size(188, 70);
            this.btnInsertR.TabIndex = 12;
            this.btnInsertR.Text = "Insert";
            this.btnInsertR.UseVisualStyleBackColor = false;
            this.btnInsertR.Click += new System.EventHandler(this.btnInsertR_Click);
            // 
            // tbDistance
            // 
            this.tbDistance.Location = new System.Drawing.Point(848, 365);
            this.tbDistance.Name = "tbDistance";
            this.tbDistance.Size = new System.Drawing.Size(257, 45);
            this.tbDistance.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 38);
            this.label6.TabIndex = 10;
            this.label6.Text = "Distance:";
            // 
            // tbDuration
            // 
            this.tbDuration.Location = new System.Drawing.Point(848, 297);
            this.tbDuration.Name = "tbDuration";
            this.tbDuration.Size = new System.Drawing.Size(257, 45);
            this.tbDuration.TabIndex = 9;
            // 
            // EstimatedT
            // 
            this.EstimatedT.AutoSize = true;
            this.EstimatedT.Location = new System.Drawing.Point(525, 304);
            this.EstimatedT.Name = "EstimatedT";
            this.EstimatedT.Size = new System.Drawing.Size(303, 38);
            this.EstimatedT.TabIndex = 8;
            this.EstimatedT.Text = "Estimated Duration:\r\n";
            // 
            // tbDestination
            // 
            this.tbDestination.Location = new System.Drawing.Point(206, 455);
            this.tbDestination.Name = "tbDestination";
            this.tbDestination.Size = new System.Drawing.Size(279, 45);
            this.tbDestination.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "Destination:";
            // 
            // tbOrigin
            // 
            this.tbOrigin.Location = new System.Drawing.Point(206, 376);
            this.tbOrigin.Name = "tbOrigin";
            this.tbOrigin.Size = new System.Drawing.Size(279, 45);
            this.tbOrigin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Origin:";
            // 
            // tbRouteID
            // 
            this.tbRouteID.Location = new System.Drawing.Point(206, 301);
            this.tbRouteID.Name = "tbRouteID";
            this.tbRouteID.Size = new System.Drawing.Size(279, 45);
            this.tbRouteID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "RouteID:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1189, 600);
            this.panel1.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbDropOff);
            this.groupBox3.Controls.Add(this.tbBoarding);
            this.groupBox3.Controls.Add(this.tbPrice);
            this.groupBox3.Controls.Add(this.cbTripId);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.btnDeleteTr);
            this.groupBox3.Controls.Add(this.btnUpdateTr);
            this.groupBox3.Controls.Add(this.btnInsertTr);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.tbStatusTr);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.tbTicketID);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.dataGridViewTicket);
            this.groupBox3.Location = new System.Drawing.Point(13, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1157, 547);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ticket";
            this.groupBox3.Visible = false;
            // 
            // tbDropOff
            // 
            this.tbDropOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDropOff.Location = new System.Drawing.Point(205, 494);
            this.tbDropOff.Name = "tbDropOff";
            this.tbDropOff.Size = new System.Drawing.Size(279, 34);
            this.tbDropOff.TabIndex = 25;
            // 
            // tbBoarding
            // 
            this.tbBoarding.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBoarding.Location = new System.Drawing.Point(206, 430);
            this.tbBoarding.Name = "tbBoarding";
            this.tbBoarding.Size = new System.Drawing.Size(279, 34);
            this.tbBoarding.TabIndex = 24;
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(206, 367);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(279, 34);
            this.tbPrice.TabIndex = 23;
            // 
            // cbTripId
            // 
            this.cbTripId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTripId.FormattingEnabled = true;
            this.cbTripId.Location = new System.Drawing.Point(750, 349);
            this.cbTripId.Name = "cbTripId";
            this.cbTripId.Size = new System.Drawing.Size(279, 37);
            this.cbTripId.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 494);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(170, 29);
            this.label13.TabIndex = 15;
            this.label13.Text = "Drop Off Point:";
            // 
            // btnDeleteTr
            // 
            this.btnDeleteTr.BackColor = System.Drawing.Color.Red;
            this.btnDeleteTr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteTr.Location = new System.Drawing.Point(953, 455);
            this.btnDeleteTr.Name = "btnDeleteTr";
            this.btnDeleteTr.Size = new System.Drawing.Size(188, 70);
            this.btnDeleteTr.TabIndex = 14;
            this.btnDeleteTr.Text = "Delete";
            this.btnDeleteTr.UseVisualStyleBackColor = false;
            this.btnDeleteTr.Click += new System.EventHandler(this.btnDeleteTr_Click);
            // 
            // btnUpdateTr
            // 
            this.btnUpdateTr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdateTr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateTr.Location = new System.Drawing.Point(750, 455);
            this.btnUpdateTr.Name = "btnUpdateTr";
            this.btnUpdateTr.Size = new System.Drawing.Size(188, 70);
            this.btnUpdateTr.TabIndex = 13;
            this.btnUpdateTr.Text = "Update";
            this.btnUpdateTr.UseVisualStyleBackColor = false;
            this.btnUpdateTr.Click += new System.EventHandler(this.btnUpdateTr_Click);
            // 
            // btnInsertTr
            // 
            this.btnInsertTr.BackColor = System.Drawing.Color.Green;
            this.btnInsertTr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsertTr.Location = new System.Drawing.Point(532, 455);
            this.btnInsertTr.Name = "btnInsertTr";
            this.btnInsertTr.Size = new System.Drawing.Size(188, 70);
            this.btnInsertTr.TabIndex = 12;
            this.btnInsertTr.Text = "Insert";
            this.btnInsertTr.UseVisualStyleBackColor = false;
            this.btnInsertTr.Click += new System.EventHandler(this.btnInsertTr_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(568, 360);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 29);
            this.label14.TabIndex = 10;
            this.label14.Text = "TripID:";
            // 
            // tbStatusTr
            // 
            this.tbStatusTr.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStatusTr.Location = new System.Drawing.Point(750, 298);
            this.tbStatusTr.Name = "tbStatusTr";
            this.tbStatusTr.Size = new System.Drawing.Size(279, 34);
            this.tbStatusTr.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(568, 301);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 29);
            this.label15.TabIndex = 8;
            this.label15.Text = "Status:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(11, 430);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(178, 29);
            this.label16.TabIndex = 6;
            this.label16.Text = "Boarding Point:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(11, 365);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 29);
            this.label17.TabIndex = 4;
            this.label17.Text = "Price:";
            // 
            // tbTicketID
            // 
            this.tbTicketID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTicketID.Location = new System.Drawing.Point(206, 301);
            this.tbTicketID.Name = "tbTicketID";
            this.tbTicketID.Size = new System.Drawing.Size(279, 34);
            this.tbTicketID.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(11, 301);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(108, 29);
            this.label18.TabIndex = 2;
            this.label18.Text = "TicketID:";
            // 
            // dataGridViewTicket
            // 
            this.dataGridViewTicket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTicket.Location = new System.Drawing.Point(39, 55);
            this.dataGridViewTicket.Name = "dataGridViewTicket";
            this.dataGridViewTicket.RowHeadersWidth = 51;
            this.dataGridViewTicket.RowTemplate.Height = 27;
            this.dataGridViewTicket.Size = new System.Drawing.Size(1083, 218);
            this.dataGridViewTicket.TabIndex = 1;
            this.dataGridViewTicket.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTicket_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbRouteID);
            this.groupBox2.Controls.Add(this.cbBusID);
            this.groupBox2.Controls.Add(this.pickerArrivalTime);
            this.groupBox2.Controls.Add(this.pickerDepartureTime);
            this.groupBox2.Controls.Add(this.pickerDepartureDate);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnDeleteT);
            this.groupBox2.Controls.Add(this.btnUpdateT);
            this.groupBox2.Controls.Add(this.btnInsertT);
            this.groupBox2.Controls.Add(this.tbBusIDT);
            this.groupBox2.Controls.Add(this.tbStatusT);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbTripID);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dataGridViewTrip);
            this.groupBox2.Location = new System.Drawing.Point(13, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1157, 547);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Trip";
            this.groupBox2.Visible = false;
            // 
            // cbRouteID
            // 
            this.cbRouteID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRouteID.FormattingEnabled = true;
            this.cbRouteID.Location = new System.Drawing.Point(750, 408);
            this.cbRouteID.Name = "cbRouteID";
            this.cbRouteID.Size = new System.Drawing.Size(279, 37);
            this.cbRouteID.TabIndex = 23;
            this.cbRouteID.SelectedIndexChanged += new System.EventHandler(this.cbRouteID_SelectedIndexChanged);
            // 
            // cbBusID
            // 
            this.cbBusID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBusID.FormattingEnabled = true;
            this.cbBusID.Location = new System.Drawing.Point(750, 349);
            this.cbBusID.Name = "cbBusID";
            this.cbBusID.Size = new System.Drawing.Size(279, 37);
            this.cbBusID.TabIndex = 22;
            // 
            // pickerArrivalTime
            // 
            this.pickerArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickerArrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pickerArrivalTime.Location = new System.Drawing.Point(206, 486);
            this.pickerArrivalTime.Name = "pickerArrivalTime";
            this.pickerArrivalTime.ShowUpDown = true;
            this.pickerArrivalTime.Size = new System.Drawing.Size(279, 34);
            this.pickerArrivalTime.TabIndex = 21;
            // 
            // pickerDepartureTime
            // 
            this.pickerDepartureTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickerDepartureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.pickerDepartureTime.Location = new System.Drawing.Point(205, 422);
            this.pickerDepartureTime.Name = "pickerDepartureTime";
            this.pickerDepartureTime.ShowUpDown = true;
            this.pickerDepartureTime.Size = new System.Drawing.Size(279, 34);
            this.pickerDepartureTime.TabIndex = 20;
            this.pickerDepartureTime.ValueChanged += new System.EventHandler(this.pickerDepartureTime_ValueChanged);
            // 
            // pickerDepartureDate
            // 
            this.pickerDepartureDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickerDepartureDate.Location = new System.Drawing.Point(206, 365);
            this.pickerDepartureDate.Name = "pickerDepartureDate";
            this.pickerDepartureDate.Size = new System.Drawing.Size(279, 34);
            this.pickerDepartureDate.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(568, 411);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 29);
            this.label12.TabIndex = 17;
            this.label12.Text = "RouteID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 494);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 29);
            this.label11.TabIndex = 15;
            this.label11.Text = "Arrival Time:";
            // 
            // btnDeleteT
            // 
            this.btnDeleteT.BackColor = System.Drawing.Color.Red;
            this.btnDeleteT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteT.Location = new System.Drawing.Point(963, 455);
            this.btnDeleteT.Name = "btnDeleteT";
            this.btnDeleteT.Size = new System.Drawing.Size(188, 70);
            this.btnDeleteT.TabIndex = 14;
            this.btnDeleteT.Text = "Delete";
            this.btnDeleteT.UseVisualStyleBackColor = false;
            this.btnDeleteT.Click += new System.EventHandler(this.btnDeleteT_Click);
            // 
            // btnUpdateT
            // 
            this.btnUpdateT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdateT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdateT.Location = new System.Drawing.Point(750, 455);
            this.btnUpdateT.Name = "btnUpdateT";
            this.btnUpdateT.Size = new System.Drawing.Size(188, 70);
            this.btnUpdateT.TabIndex = 13;
            this.btnUpdateT.Text = "Update";
            this.btnUpdateT.UseVisualStyleBackColor = false;
            this.btnUpdateT.Click += new System.EventHandler(this.btnUpdateT_Click);
            // 
            // btnInsertT
            // 
            this.btnInsertT.BackColor = System.Drawing.Color.Green;
            this.btnInsertT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnInsertT.Location = new System.Drawing.Point(532, 455);
            this.btnInsertT.Name = "btnInsertT";
            this.btnInsertT.Size = new System.Drawing.Size(188, 70);
            this.btnInsertT.TabIndex = 12;
            this.btnInsertT.Text = "Insert";
            this.btnInsertT.UseVisualStyleBackColor = false;
            this.btnInsertT.Click += new System.EventHandler(this.btnInsertT_Click);
            // 
            // tbBusIDT
            // 
            this.tbBusIDT.AutoSize = true;
            this.tbBusIDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBusIDT.Location = new System.Drawing.Point(568, 360);
            this.tbBusIDT.Name = "tbBusIDT";
            this.tbBusIDT.Size = new System.Drawing.Size(83, 29);
            this.tbBusIDT.TabIndex = 10;
            this.tbBusIDT.Text = "BusID:";
            // 
            // tbStatusT
            // 
            this.tbStatusT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStatusT.Location = new System.Drawing.Point(750, 298);
            this.tbStatusT.Name = "tbStatusT";
            this.tbStatusT.Size = new System.Drawing.Size(279, 34);
            this.tbStatusT.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(568, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Status:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(11, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(188, 29);
            this.label8.TabIndex = 6;
            this.label8.Text = "Departure Time:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(182, 29);
            this.label9.TabIndex = 4;
            this.label9.Text = "Departure Date:";
            // 
            // tbTripID
            // 
            this.tbTripID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTripID.Location = new System.Drawing.Point(206, 301);
            this.tbTripID.Name = "tbTripID";
            this.tbTripID.Size = new System.Drawing.Size(279, 34);
            this.tbTripID.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 301);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 29);
            this.label10.TabIndex = 2;
            this.label10.Text = "TripID:";
            // 
            // dataGridViewTrip
            // 
            this.dataGridViewTrip.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewTrip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrip.Location = new System.Drawing.Point(39, 55);
            this.dataGridViewTrip.Name = "dataGridViewTrip";
            this.dataGridViewTrip.RowHeadersWidth = 51;
            this.dataGridViewTrip.RowTemplate.Height = 27;
            this.dataGridViewTrip.Size = new System.Drawing.Size(1083, 218);
            this.dataGridViewTrip.TabIndex = 1;
            this.dataGridViewTrip.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTrip_CellClick);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(65, 698);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(252, 68);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(896, 698);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(252, 68);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // AdminManagementPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1218, 851);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "AdminManagementPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Management Page";
            this.Load += new System.EventHandler(this.AdminManagementPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoute)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTicket)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewRoute;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbDistance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbDuration;
        private System.Windows.Forms.Label EstimatedT;
        private System.Windows.Forms.TextBox tbDestination;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbOrigin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbRouteID;
        private System.Windows.Forms.Button btnDeleteR;
        private System.Windows.Forms.Button btnUpdateR;
        private System.Windows.Forms.Button btnInsertR;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteT;
        private System.Windows.Forms.Button btnUpdateT;
        private System.Windows.Forms.Button btnInsertT;
        private System.Windows.Forms.Label tbBusIDT;
        private System.Windows.Forms.TextBox tbStatusT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbTripID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridViewTrip;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker pickerArrivalTime;
        private System.Windows.Forms.DateTimePicker pickerDepartureTime;
        private System.Windows.Forms.DateTimePicker pickerDepartureDate;
        private System.Windows.Forms.ComboBox cbRouteID;
        private System.Windows.Forms.ComboBox cbBusID;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbTripId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnDeleteTr;
        private System.Windows.Forms.Button btnUpdateTr;
        private System.Windows.Forms.Button btnInsertTr;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbStatusTr;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbTicketID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dataGridViewTicket;
        private System.Windows.Forms.TextBox tbDropOff;
        private System.Windows.Forms.TextBox tbBoarding;
        private System.Windows.Forms.TextBox tbPrice;
    }
}
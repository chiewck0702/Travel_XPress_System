namespace TravelXpress_Package_System
{
    partial class TicketBookingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketBookingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.roundTripCb = new System.Windows.Forms.CheckBox();
            this.busDetailsDataGridView1 = new System.Windows.Forms.DataGridView();
            this.busDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.travelXpressDataSet = new TravelXpress_Package_System.TravelXpressDataSet();
            this.panel3 = new System.Windows.Forms.Panel();
            this.backBt = new System.Windows.Forms.Button();
            this.searchBt = new System.Windows.Forms.Button();
            this.clearBt = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.returnDate = new System.Windows.Forms.DateTimePicker();
            this.departureDate = new System.Windows.Forms.DateTimePicker();
            this.returnDateLb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.busToTb = new System.Windows.Forms.TextBox();
            this.busFromTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.busDetailsTableAdapter = new TravelXpress_Package_System.TravelXpressDataSetTableAdapters.BusDetailsTableAdapter();
            this.tableAdapterManager = new TravelXpress_Package_System.TravelXpressDataSetTableAdapters.TableAdapterManager();
            this.busDetailsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.busDetailsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busDetailsDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelXpressDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.busDetailsBindingNavigator)).BeginInit();
            this.busDetailsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.roundTripCb);
            this.panel1.Controls.Add(this.busDetailsDataGridView1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.returnDate);
            this.panel1.Controls.Add(this.departureDate);
            this.panel1.Controls.Add(this.returnDateLb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.busToTb);
            this.panel1.Controls.Add(this.busFromTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(15, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 670);
            this.panel1.TabIndex = 0;
            // 
            // roundTripCb
            // 
            this.roundTripCb.AutoSize = true;
            this.roundTripCb.Enabled = false;
            this.roundTripCb.Location = new System.Drawing.Point(402, 457);
            this.roundTripCb.Name = "roundTripCb";
            this.roundTripCb.Size = new System.Drawing.Size(168, 33);
            this.roundTripCb.TabIndex = 28;
            this.roundTripCb.Text = "Round Trip?";
            this.roundTripCb.UseVisualStyleBackColor = true;
            this.roundTripCb.CheckedChanged += new System.EventHandler(this.roundTripCb_CheckedChanged);
            // 
            // busDetailsDataGridView1
            // 
            this.busDetailsDataGridView1.AutoGenerateColumns = false;
            this.busDetailsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.busDetailsDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.busDetailsDataGridView1.DataSource = this.busDetailsBindingSource;
            this.busDetailsDataGridView1.Location = new System.Drawing.Point(31, 99);
            this.busDetailsDataGridView1.Name = "busDetailsDataGridView1";
            this.busDetailsDataGridView1.RowHeadersWidth = 51;
            this.busDetailsDataGridView1.RowTemplate.Height = 24;
            this.busDetailsDataGridView1.Size = new System.Drawing.Size(1162, 127);
            this.busDetailsDataGridView1.TabIndex = 27;
            // 
            // busDetailsBindingSource
            // 
            this.busDetailsBindingSource.DataMember = "BusDetails";
            this.busDetailsBindingSource.DataSource = this.travelXpressDataSet;
            // 
            // travelXpressDataSet
            // 
            this.travelXpressDataSet.DataSetName = "TravelXpressDataSet";
            this.travelXpressDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.backBt);
            this.panel3.Controls.Add(this.searchBt);
            this.panel3.Controls.Add(this.clearBt);
            this.panel3.Location = new System.Drawing.Point(20, 591);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 59);
            this.panel3.TabIndex = 27;
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(3, 8);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(125, 43);
            this.backBt.TabIndex = 11;
            this.backBt.Text = "Back";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // searchBt
            // 
            this.searchBt.Location = new System.Drawing.Point(387, 8);
            this.searchBt.Name = "searchBt";
            this.searchBt.Size = new System.Drawing.Size(163, 43);
            this.searchBt.TabIndex = 1;
            this.searchBt.Text = "Search";
            this.searchBt.UseVisualStyleBackColor = true;
            this.searchBt.Click += new System.EventHandler(this.searchBt_Click);
            // 
            // clearBt
            // 
            this.clearBt.Location = new System.Drawing.Point(205, 8);
            this.clearBt.Name = "clearBt";
            this.clearBt.Size = new System.Drawing.Size(163, 43);
            this.clearBt.TabIndex = 10;
            this.clearBt.Text = "Clear";
            this.clearBt.UseVisualStyleBackColor = true;
            this.clearBt.Click += new System.EventHandler(this.clearBt_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1218, 70);
            this.panel2.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(516, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(611, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(582, 341);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // returnDate
            // 
            this.returnDate.Enabled = false;
            this.returnDate.Location = new System.Drawing.Point(260, 505);
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(310, 34);
            this.returnDate.TabIndex = 8;
            // 
            // departureDate
            // 
            this.departureDate.Location = new System.Drawing.Point(260, 406);
            this.departureDate.Name = "departureDate";
            this.departureDate.Size = new System.Drawing.Size(310, 34);
            this.departureDate.TabIndex = 7;
            // 
            // returnDateLb
            // 
            this.returnDateLb.AutoSize = true;
            this.returnDateLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDateLb.Location = new System.Drawing.Point(89, 505);
            this.returnDateLb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.returnDateLb.Name = "returnDateLb";
            this.returnDateLb.Size = new System.Drawing.Size(151, 29);
            this.returnDateLb.TabIndex = 6;
            this.returnDateLb.Text = "Return Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 406);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Departure Date";
            // 
            // busToTb
            // 
            this.busToTb.Location = new System.Drawing.Point(260, 349);
            this.busToTb.Name = "busToTb";
            this.busToTb.Size = new System.Drawing.Size(310, 34);
            this.busToTb.TabIndex = 4;
            this.busToTb.TextChanged += new System.EventHandler(this.busToTb_TextChanged);
            // 
            // busFromTb
            // 
            this.busFromTb.Location = new System.Drawing.Point(260, 293);
            this.busFromTb.Name = "busFromTb";
            this.busFromTb.Size = new System.Drawing.Size(310, 34);
            this.busFromTb.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(144, 354);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bus To";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 293);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bus From";
            // 
            // busDetailsTableAdapter
            // 
            this.busDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccommodationTableAdapter = null;
            this.tableAdapterManager.AdminDetailsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookingTableAdapter = null;
            this.tableAdapterManager.BusDetailsTableAdapter = this.busDetailsTableAdapter;
            this.tableAdapterManager.CustomerMembersTableAdapter = null;
            this.tableAdapterManager.CustomerTableAdapter = null;
            this.tableAdapterManager.ImagePathTableAdapter = null;
            this.tableAdapterManager.PackageTableAdapter = null;
            this.tableAdapterManager.RoomTypeTableAdapter = null;
            this.tableAdapterManager.RoutePathTableAdapter = null;
            this.tableAdapterManager.TicketTableAdapter = null;
            this.tableAdapterManager.TripTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TravelXpress_Package_System.TravelXpressDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // busDetailsBindingNavigator
            // 
            this.busDetailsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.busDetailsBindingNavigator.BindingSource = this.busDetailsBindingSource;
            this.busDetailsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.busDetailsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.busDetailsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.busDetailsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.busDetailsBindingNavigatorSaveItem});
            this.busDetailsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.busDetailsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.busDetailsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.busDetailsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.busDetailsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.busDetailsBindingNavigator.Name = "busDetailsBindingNavigator";
            this.busDetailsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.busDetailsBindingNavigator.Size = new System.Drawing.Size(1277, 27);
            this.busDetailsBindingNavigator.TabIndex = 1;
            this.busDetailsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(49, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // busDetailsBindingNavigatorSaveItem
            // 
            this.busDetailsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.busDetailsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("busDetailsBindingNavigatorSaveItem.Image")));
            this.busDetailsBindingNavigatorSaveItem.Name = "busDetailsBindingNavigatorSaveItem";
            this.busDetailsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.busDetailsBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Bus";
            this.dataGridViewTextBoxColumn6.HeaderText = "Bus";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BusPlateNum";
            this.dataGridViewTextBoxColumn7.HeaderText = "BusPlateNum";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "BusType";
            this.dataGridViewTextBoxColumn8.HeaderText = "BusType";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "TotalSeats";
            this.dataGridViewTextBoxColumn9.HeaderText = "TotalSeats";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(26, 240);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(332, 25);
            this.label5.TabIndex = 29;
            this.label5.Text = "Round Trip Is Not Available Currenly.";
            // 
            // TicketBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 684);
            this.Controls.Add(this.busDetailsBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "TicketBookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Booking";
            this.Load += new System.EventHandler(this.TicketBookingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.busDetailsDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelXpressDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.busDetailsBindingNavigator)).EndInit();
            this.busDetailsBindingNavigator.ResumeLayout(false);
            this.busDetailsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox busToTb;
        private System.Windows.Forms.TextBox busFromTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker returnDate;
        private System.Windows.Forms.DateTimePicker departureDate;
        private System.Windows.Forms.Label returnDateLb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button clearBt;
        private System.Windows.Forms.Button searchBt;
        private System.Windows.Forms.Button backBt;
        private System.Windows.Forms.Panel panel2;
        private TravelXpressDataSet travelXpressDataSet;
        private System.Windows.Forms.BindingSource busDetailsBindingSource;
        private TravelXpressDataSetTableAdapters.BusDetailsTableAdapter busDetailsTableAdapter;
        private TravelXpressDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator busDetailsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton busDetailsBindingNavigatorSaveItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView busDetailsDataGridView1;
        private System.Windows.Forms.CheckBox roundTripCb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label5;
    }
}
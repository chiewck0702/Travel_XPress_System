namespace TravelXpress_Package_System
{
    partial class TicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowTicket1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ticket1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.chooseBt1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.busFromTb = new System.Windows.Forms.TextBox();
            this.busFromLb = new System.Windows.Forms.Label();
            this.busToTb = new System.Windows.Forms.TextBox();
            this.busToLb = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.returnTb = new System.Windows.Forms.TextBox();
            this.returnDateLb = new System.Windows.Forms.Label();
            this.backBt = new System.Windows.Forms.Button();
            this.departTb = new System.Windows.Forms.TextBox();
            this.departDateLb = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bookingTableAdapter1 = new TravelXpress_Package_System.TravelXpressDataSetTableAdapters.BookingTableAdapter();
            this.panel1.SuspendLayout();
            this.flowTicket1.SuspendLayout();
            this.ticket1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.flowTicket1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.returnTb);
            this.panel1.Controls.Add(this.returnDateLb);
            this.panel1.Controls.Add(this.backBt);
            this.panel1.Controls.Add(this.departTb);
            this.panel1.Controls.Add(this.departDateLb);
            this.panel1.Location = new System.Drawing.Point(15, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1227, 580);
            this.panel1.TabIndex = 1;
            // 
            // flowTicket1
            // 
            this.flowTicket1.AutoScroll = true;
            this.flowTicket1.Controls.Add(this.ticket1);
            this.flowTicket1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowTicket1.Location = new System.Drawing.Point(42, 272);
            this.flowTicket1.Name = "flowTicket1";
            this.flowTicket1.Size = new System.Drawing.Size(1138, 343);
            this.flowTicket1.TabIndex = 27;
            this.flowTicket1.WrapContents = false;
            // 
            // ticket1
            // 
            this.ticket1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ticket1.Controls.Add(this.label9);
            this.ticket1.Controls.Add(this.label31);
            this.ticket1.Controls.Add(this.label30);
            this.ticket1.Controls.Add(this.chooseBt1);
            this.ticket1.Controls.Add(this.pictureBox1);
            this.ticket1.Controls.Add(this.label6);
            this.ticket1.Controls.Add(this.label16);
            this.ticket1.Controls.Add(this.label15);
            this.ticket1.Controls.Add(this.label14);
            this.ticket1.Controls.Add(this.label12);
            this.ticket1.Controls.Add(this.label13);
            this.ticket1.Controls.Add(this.label11);
            this.ticket1.Controls.Add(this.label10);
            this.ticket1.Controls.Add(this.label8);
            this.ticket1.Controls.Add(this.label7);
            this.ticket1.Controls.Add(this.label5);
            this.ticket1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticket1.Location = new System.Drawing.Point(3, 3);
            this.ticket1.Name = "ticket1";
            this.ticket1.Size = new System.Drawing.Size(1116, 230);
            this.ticket1.TabIndex = 25;
            this.ticket1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(883, 53);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 32);
            this.label9.TabIndex = 30;
            this.label9.Text = "RM";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(211, 159);
            this.label31.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(103, 29);
            this.label31.TabIndex = 43;
            this.label31.Text = "Total Seats";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(180, 159);
            this.label30.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(36, 29);
            this.label30.TabIndex = 42;
            this.label30.Text = "29";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chooseBt1
            // 
            this.chooseBt1.BackColor = System.Drawing.Color.Black;
            this.chooseBt1.ForeColor = System.Drawing.Color.White;
            this.chooseBt1.Location = new System.Drawing.Point(898, 144);
            this.chooseBt1.Name = "chooseBt1";
            this.chooseBt1.Size = new System.Drawing.Size(190, 43);
            this.chooseBt1.TabIndex = 41;
            this.chooseBt1.Text = "Choose";
            this.chooseBt1.UseVisualStyleBackColor = false;
            this.chooseBt1.Click += new System.EventHandler(this.chooseBt1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(173, 126);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 33);
            this.label6.TabIndex = 38;
            this.label6.Text = "Transnational";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(643, 83);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(195, 29);
            this.label16.TabIndex = 37;
            this.label16.Text = "Kedah";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(268, 83);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(195, 29);
            this.label15.TabIndex = 36;
            this.label15.Text = "Kuala Lumpur";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(651, 29);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(187, 52);
            this.label14.TabIndex = 35;
            this.label14.Text = "Terminal Bus Shahab Perdana";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(475, 29);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(135, 29);
            this.label12.TabIndex = 33;
            this.label12.Text = "5h 10m";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(455, 54);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(184, 29);
            this.label13.TabIndex = 34;
            this.label13.Text = "-------------------->";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(276, 29);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(187, 52);
            this.label11.TabIndex = 32;
            this.label11.Text = "KL Sentral";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(925, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(185, 83);
            this.label10.TabIndex = 31;
            this.label10.Text = "25";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(65, 71);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "Seat(s) Left";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(30, 71);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "44";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 29);
            this.label5.TabIndex = 27;
            this.label5.Text = "07：00 AM";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.busFromTb);
            this.panel2.Controls.Add(this.busFromLb);
            this.panel2.Controls.Add(this.busToTb);
            this.panel2.Controls.Add(this.busToLb);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 80);
            this.panel2.TabIndex = 25;
            // 
            // busFromTb
            // 
            this.busFromTb.BackColor = System.Drawing.Color.Silver;
            this.busFromTb.Location = new System.Drawing.Point(189, 22);
            this.busFromTb.Multiline = true;
            this.busFromTb.Name = "busFromTb";
            this.busFromTb.ReadOnly = true;
            this.busFromTb.Size = new System.Drawing.Size(422, 39);
            this.busFromTb.TabIndex = 21;
            this.busFromTb.Text = "Kuala Lumpur";
            this.busFromTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // busFromLb
            // 
            this.busFromLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busFromLb.ForeColor = System.Drawing.Color.White;
            this.busFromLb.Location = new System.Drawing.Point(81, 18);
            this.busFromLb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.busFromLb.Name = "busFromLb";
            this.busFromLb.Size = new System.Drawing.Size(99, 43);
            this.busFromLb.TabIndex = 19;
            this.busFromLb.Text = "Depart:";
            this.busFromLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // busToTb
            // 
            this.busToTb.BackColor = System.Drawing.Color.Silver;
            this.busToTb.Location = new System.Drawing.Point(697, 22);
            this.busToTb.Multiline = true;
            this.busToTb.Name = "busToTb";
            this.busToTb.ReadOnly = true;
            this.busToTb.Size = new System.Drawing.Size(422, 39);
            this.busToTb.TabIndex = 22;
            this.busToTb.Text = "Kedah";
            this.busToTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // busToLb
            // 
            this.busToLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busToLb.ForeColor = System.Drawing.Color.White;
            this.busToLb.Location = new System.Drawing.Point(606, 18);
            this.busToLb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.busToLb.Name = "busToLb";
            this.busToLb.Size = new System.Drawing.Size(92, 43);
            this.busToLb.TabIndex = 20;
            this.busToLb.Text = "To";
            this.busToLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(37, 205);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(503, 37);
            this.label17.TabIndex = 26;
            this.label17.Text = "Please Choose One of The Ticket:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // returnTb
            // 
            this.returnTb.Location = new System.Drawing.Point(823, 112);
            this.returnTb.Multiline = true;
            this.returnTb.Name = "returnTb";
            this.returnTb.ReadOnly = true;
            this.returnTb.Size = new System.Drawing.Size(240, 39);
            this.returnTb.TabIndex = 24;
            this.returnTb.Text = "12 April 2025";
            // 
            // returnDateLb
            // 
            this.returnDateLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnDateLb.Location = new System.Drawing.Point(644, 108);
            this.returnDateLb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.returnDateLb.Name = "returnDateLb";
            this.returnDateLb.Size = new System.Drawing.Size(177, 43);
            this.returnDateLb.TabIndex = 23;
            this.returnDateLb.Text = "Return Date";
            this.returnDateLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backBt
            // 
            this.backBt.Location = new System.Drawing.Point(1017, 199);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(163, 43);
            this.backBt.TabIndex = 11;
            this.backBt.Text = "Back";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // departTb
            // 
            this.departTb.Location = new System.Drawing.Point(300, 108);
            this.departTb.Multiline = true;
            this.departTb.Name = "departTb";
            this.departTb.ReadOnly = true;
            this.departTb.Size = new System.Drawing.Size(240, 39);
            this.departTb.TabIndex = 18;
            this.departTb.Text = "12 April 2025";
            // 
            // departDateLb
            // 
            this.departDateLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departDateLb.Location = new System.Drawing.Point(121, 104);
            this.departDateLb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.departDateLb.Name = "departDateLb";
            this.departDateLb.Size = new System.Drawing.Size(177, 43);
            this.departDateLb.TabIndex = 17;
            this.departDateLb.Text = "Depart Date";
            this.departDateLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bookingTableAdapter1
            // 
            this.bookingTableAdapter1.ClearBeforeFill = true;
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 624);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket Form";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowTicket1.ResumeLayout(false);
            this.ticket1.ResumeLayout(false);
            this.ticket1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button backBt;
        private System.Windows.Forms.Label departDateLb;
        private System.Windows.Forms.TextBox departTb;
        private System.Windows.Forms.Label busFromLb;
        private System.Windows.Forms.TextBox busFromTb;
        private System.Windows.Forms.Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox busToTb;
        private System.Windows.Forms.Label busToLb;
        private System.Windows.Forms.TextBox returnTb;
        private System.Windows.Forms.Label returnDateLb;
        private System.Windows.Forms.FlowLayoutPanel flowTicket1;
        private TravelXpressDataSetTableAdapters.BookingTableAdapter bookingTableAdapter1;
        private System.Windows.Forms.Panel ticket1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Button chooseBt1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}
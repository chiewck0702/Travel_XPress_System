namespace TravelXpress_Package_System
{
    partial class TicketPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketPayment));
            this.panel = new System.Windows.Forms.Panel();
            this.backBt = new System.Windows.Forms.Button();
            this.fpxLabel = new System.Windows.Forms.Label();
            this.bookBt = new System.Windows.Forms.Button();
            this.cardPanel = new System.Windows.Forms.GroupBox();
            this.policyCb = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.masterRb = new System.Windows.Forms.RadioButton();
            this.visaRb = new System.Windows.Forms.RadioButton();
            this.cvvTb = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.exDateYYTb = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.exDateMMTb = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cardHolderNameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cardNumTb = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.paymentPic = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cardRb = new System.Windows.Forms.RadioButton();
            this.fpxRb = new System.Windows.Forms.RadioButton();
            this.ewalletRb = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.cardPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cvvTb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exDateYYTb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exDateMMTb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentPic)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.backBt);
            this.panel.Controls.Add(this.fpxLabel);
            this.panel.Controls.Add(this.bookBt);
            this.panel.Controls.Add(this.cardPanel);
            this.panel.Controls.Add(this.paymentPic);
            this.panel.Controls.Add(this.groupBox1);
            this.panel.Controls.Add(this.panel2);
            this.panel.Location = new System.Drawing.Point(15, 14);
            this.panel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1227, 596);
            this.panel.TabIndex = 2;
            // 
            // backBt
            // 
            this.backBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBt.Location = new System.Drawing.Point(658, 504);
            this.backBt.Name = "backBt";
            this.backBt.Size = new System.Drawing.Size(119, 57);
            this.backBt.TabIndex = 81;
            this.backBt.Text = "Back";
            this.backBt.UseVisualStyleBackColor = true;
            this.backBt.Click += new System.EventHandler(this.backBt_Click);
            // 
            // fpxLabel
            // 
            this.fpxLabel.AutoSize = true;
            this.fpxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpxLabel.Location = new System.Drawing.Point(708, 481);
            this.fpxLabel.Name = "fpxLabel";
            this.fpxLabel.Size = new System.Drawing.Size(314, 25);
            this.fpxLabel.TabIndex = 80;
            this.fpxLabel.Text = "Redirecting To FPX Interface....";
            this.fpxLabel.Visible = false;
            // 
            // bookBt
            // 
            this.bookBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookBt.Location = new System.Drawing.Point(1050, 504);
            this.bookBt.Name = "bookBt";
            this.bookBt.Size = new System.Drawing.Size(119, 57);
            this.bookBt.TabIndex = 80;
            this.bookBt.Text = "Book";
            this.bookBt.UseVisualStyleBackColor = true;
            this.bookBt.Click += new System.EventHandler(this.bookBt_Click);
            // 
            // cardPanel
            // 
            this.cardPanel.Controls.Add(this.policyCb);
            this.cardPanel.Controls.Add(this.label7);
            this.cardPanel.Controls.Add(this.groupBox3);
            this.cardPanel.Controls.Add(this.cvvTb);
            this.cardPanel.Controls.Add(this.label6);
            this.cardPanel.Controls.Add(this.exDateYYTb);
            this.cardPanel.Controls.Add(this.label5);
            this.cardPanel.Controls.Add(this.exDateMMTb);
            this.cardPanel.Controls.Add(this.label4);
            this.cardPanel.Controls.Add(this.cardHolderNameTb);
            this.cardPanel.Controls.Add(this.label3);
            this.cardPanel.Controls.Add(this.cardNumTb);
            this.cardPanel.Controls.Add(this.label2);
            this.cardPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardPanel.Location = new System.Drawing.Point(36, 225);
            this.cardPanel.Name = "cardPanel";
            this.cardPanel.Size = new System.Drawing.Size(576, 415);
            this.cardPanel.TabIndex = 67;
            this.cardPanel.TabStop = false;
            this.cardPanel.Text = "Card Details";
            this.cardPanel.Visible = false;
            // 
            // policyCb
            // 
            this.policyCb.AutoSize = true;
            this.policyCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.policyCb.ForeColor = System.Drawing.Color.Red;
            this.policyCb.Location = new System.Drawing.Point(45, 369);
            this.policyCb.Name = "policyCb";
            this.policyCb.Size = new System.Drawing.Size(312, 29);
            this.policyCb.TabIndex = 79;
            this.policyCb.Text = "I Agree To The Term and Policy";
            this.policyCb.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 25);
            this.label7.TabIndex = 78;
            this.label7.Text = "Card Type";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.masterRb);
            this.groupBox3.Controls.Add(this.visaRb);
            this.groupBox3.Location = new System.Drawing.Point(160, 293);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(232, 60);
            this.groupBox3.TabIndex = 68;
            this.groupBox3.TabStop = false;
            // 
            // masterRb
            // 
            this.masterRb.AutoSize = true;
            this.masterRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterRb.Location = new System.Drawing.Point(110, 19);
            this.masterRb.Name = "masterRb";
            this.masterRb.Size = new System.Drawing.Size(107, 33);
            this.masterRb.TabIndex = 67;
            this.masterRb.TabStop = true;
            this.masterRb.Text = "Master";
            this.masterRb.UseVisualStyleBackColor = true;
            // 
            // visaRb
            // 
            this.visaRb.AutoSize = true;
            this.visaRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visaRb.Location = new System.Drawing.Point(14, 19);
            this.visaRb.Name = "visaRb";
            this.visaRb.Size = new System.Drawing.Size(80, 33);
            this.visaRb.TabIndex = 66;
            this.visaRb.TabStop = true;
            this.visaRb.Text = "Visa";
            this.visaRb.UseVisualStyleBackColor = true;
            // 
            // cvvTb
            // 
            this.cvvTb.Location = new System.Drawing.Point(330, 243);
            this.cvvTb.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.cvvTb.Name = "cvvTb";
            this.cvvTb.Size = new System.Drawing.Size(93, 34);
            this.cvvTb.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(325, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 76;
            this.label6.Text = "CVV";
            // 
            // exDateYYTb
            // 
            this.exDateYYTb.Location = new System.Drawing.Point(139, 247);
            this.exDateYYTb.Name = "exDateYYTb";
            this.exDateYYTb.Size = new System.Drawing.Size(68, 34);
            this.exDateYYTb.TabIndex = 75;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 25);
            this.label5.TabIndex = 74;
            this.label5.Text = "/";
            // 
            // exDateMMTb
            // 
            this.exDateMMTb.Location = new System.Drawing.Point(43, 247);
            this.exDateMMTb.Name = "exDateMMTb";
            this.exDateMMTb.Size = new System.Drawing.Size(68, 34);
            this.exDateMMTb.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 25);
            this.label4.TabIndex = 72;
            this.label4.Text = "Expiry Date (MM/YY)";
            // 
            // cardHolderNameTb
            // 
            this.cardHolderNameTb.Location = new System.Drawing.Point(43, 74);
            this.cardHolderNameTb.Name = "cardHolderNameTb";
            this.cardHolderNameTb.Size = new System.Drawing.Size(490, 34);
            this.cardHolderNameTb.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 70;
            this.label3.Text = "Card Number";
            // 
            // cardNumTb
            // 
            this.cardNumTb.Location = new System.Drawing.Point(43, 152);
            this.cardNumTb.Mask = "0000-0000-0000-0000";
            this.cardNumTb.Name = "cardNumTb";
            this.cardNumTb.Size = new System.Drawing.Size(490, 34);
            this.cardNumTb.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 68;
            this.label2.Text = "Card Holder Name";
            // 
            // paymentPic
            // 
            this.paymentPic.Image = ((System.Drawing.Image)(resources.GetObject("paymentPic.Image")));
            this.paymentPic.Location = new System.Drawing.Point(658, 117);
            this.paymentPic.Name = "paymentPic";
            this.paymentPic.Size = new System.Drawing.Size(511, 349);
            this.paymentPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.paymentPic.TabIndex = 9;
            this.paymentPic.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cardRb);
            this.groupBox1.Controls.Add(this.fpxRb);
            this.groupBox1.Controls.Add(this.ewalletRb);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(36, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 88);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Method";
            // 
            // cardRb
            // 
            this.cardRb.AutoSize = true;
            this.cardRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardRb.Location = new System.Drawing.Point(367, 35);
            this.cardRb.Name = "cardRb";
            this.cardRb.Size = new System.Drawing.Size(166, 33);
            this.cardRb.TabIndex = 65;
            this.cardRb.TabStop = true;
            this.cardRb.Text = "Visa/ Master";
            this.cardRb.UseVisualStyleBackColor = true;
            this.cardRb.CheckedChanged += new System.EventHandler(this.cardRb_CheckedChanged);
            // 
            // fpxRb
            // 
            this.fpxRb.AutoSize = true;
            this.fpxRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fpxRb.Location = new System.Drawing.Point(221, 35);
            this.fpxRb.Name = "fpxRb";
            this.fpxRb.Size = new System.Drawing.Size(82, 33);
            this.fpxRb.TabIndex = 64;
            this.fpxRb.TabStop = true;
            this.fpxRb.Text = "FPX";
            this.fpxRb.UseVisualStyleBackColor = true;
            this.fpxRb.CheckedChanged += new System.EventHandler(this.fpxRb_CheckedChanged);
            // 
            // ewalletRb
            // 
            this.ewalletRb.AutoSize = true;
            this.ewalletRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ewalletRb.Location = new System.Drawing.Point(29, 35);
            this.ewalletRb.Name = "ewalletRb";
            this.ewalletRb.Size = new System.Drawing.Size(125, 33);
            this.ewalletRb.TabIndex = 63;
            this.ewalletRb.TabStop = true;
            this.ewalletRb.Text = "E-Wallet";
            this.ewalletRb.UseVisualStyleBackColor = true;
            this.ewalletRb.CheckedChanged += new System.EventHandler(this.ewalletRb_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1197, 70);
            this.panel2.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(503, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Method";
            // 
            // TicketPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 624);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "TicketPayment";
            this.Text = "TicketPayment";
            this.Load += new System.EventHandler(this.TicketPayment_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.cardPanel.ResumeLayout(false);
            this.cardPanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cvvTb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exDateYYTb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exDateMMTb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentPic)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox paymentPic;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton cardRb;
        private System.Windows.Forms.RadioButton fpxRb;
        private System.Windows.Forms.RadioButton ewalletRb;
        private System.Windows.Forms.GroupBox cardPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cardHolderNameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox cardNumTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton masterRb;
        private System.Windows.Forms.RadioButton visaRb;
        private System.Windows.Forms.NumericUpDown cvvTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown exDateYYTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown exDateMMTb;
        private System.Windows.Forms.Button bookBt;
        private System.Windows.Forms.CheckBox policyCb;
        private System.Windows.Forms.Label fpxLabel;
        private System.Windows.Forms.Button backBt;
    }
}
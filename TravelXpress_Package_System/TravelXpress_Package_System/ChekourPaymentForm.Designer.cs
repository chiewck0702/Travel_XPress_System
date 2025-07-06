namespace TravelXpress_Package_System
{
    partial class ChekourPaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChekourPaymentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonBook = new System.Windows.Forms.Button();
            this.pictureBoxPayment = new System.Windows.Forms.PictureBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCard = new System.Windows.Forms.RadioButton();
            this.radioButtonFPX = new System.Windows.Forms.RadioButton();
            this.radioButtonTng = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanelSummary = new System.Windows.Forms.TableLayoutPanel();
            this.labelSummary = new System.Windows.Forms.Label();
            this.labelAmountDetails = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPayment)).BeginInit();
            this.cardPanel.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cvvTb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exDateYYTb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exDateMMTb)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.buttonBook);
            this.panel1.Controls.Add(this.pictureBoxPayment);
            this.panel1.Controls.Add(this.cardPanel);
            this.panel1.Controls.Add(this.labelTotalAmount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.tableLayoutPanelSummary);
            this.panel1.Controls.Add(this.labelSummary);
            this.panel1.Controls.Add(this.labelAmountDetails);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1121, 517);
            this.panel1.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(788, 1475);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 25);
            this.label8.TabIndex = 78;
            // 
            // buttonBook
            // 
            this.buttonBook.Location = new System.Drawing.Point(917, 1403);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(161, 50);
            this.buttonBook.TabIndex = 77;
            this.buttonBook.Text = "Book";
            this.buttonBook.UseVisualStyleBackColor = true;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // pictureBoxPayment
            // 
            this.pictureBoxPayment.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPayment.Image")));
            this.pictureBoxPayment.Location = new System.Drawing.Point(638, 906);
            this.pictureBoxPayment.Name = "pictureBoxPayment";
            this.pictureBoxPayment.Size = new System.Drawing.Size(440, 281);
            this.pictureBoxPayment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPayment.TabIndex = 76;
            this.pictureBoxPayment.TabStop = false;
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
            this.cardPanel.Controls.Add(this.label1);
            this.cardPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardPanel.Location = new System.Drawing.Point(30, 1060);
            this.cardPanel.Name = "cardPanel";
            this.cardPanel.Size = new System.Drawing.Size(576, 415);
            this.cardPanel.TabIndex = 75;
            this.cardPanel.TabStop = false;
            this.cardPanel.Text = "Card Details";
            this.cardPanel.Visible = false;
            // 
            // policyCb
            // 
            this.policyCb.AutoSize = true;
            this.policyCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.policyCb.ForeColor = System.Drawing.Color.Red;
            this.policyCb.Location = new System.Drawing.Point(45, 369);
            this.policyCb.Name = "policyCb";
            this.policyCb.Size = new System.Drawing.Size(267, 24);
            this.policyCb.TabIndex = 79;
            this.policyCb.Text = "I Agree To The Term and Policy";
            this.policyCb.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
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
            this.masterRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterRb.Location = new System.Drawing.Point(110, 19);
            this.masterRb.Name = "masterRb";
            this.masterRb.Size = new System.Drawing.Size(82, 24);
            this.masterRb.TabIndex = 67;
            this.masterRb.TabStop = true;
            this.masterRb.Text = "Master";
            this.masterRb.UseVisualStyleBackColor = true;
            // 
            // visaRb
            // 
            this.visaRb.AutoSize = true;
            this.visaRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visaRb.Location = new System.Drawing.Point(14, 19);
            this.visaRb.Name = "visaRb";
            this.visaRb.Size = new System.Drawing.Size(63, 24);
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
            this.cvvTb.Size = new System.Drawing.Size(93, 27);
            this.cvvTb.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(325, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 76;
            this.label6.Text = "CVV";
            // 
            // exDateYYTb
            // 
            this.exDateYYTb.Location = new System.Drawing.Point(139, 247);
            this.exDateYYTb.Name = "exDateYYTb";
            this.exDateYYTb.Size = new System.Drawing.Size(68, 27);
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
            this.exDateMMTb.Size = new System.Drawing.Size(68, 27);
            this.exDateMMTb.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 72;
            this.label4.Text = "Expiry Date (MM/YY)";
            // 
            // cardHolderNameTb
            // 
            this.cardHolderNameTb.Location = new System.Drawing.Point(43, 74);
            this.cardHolderNameTb.Name = "cardHolderNameTb";
            this.cardHolderNameTb.Size = new System.Drawing.Size(490, 27);
            this.cardHolderNameTb.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "Card Number";
            // 
            // cardNumTb
            // 
            this.cardNumTb.Location = new System.Drawing.Point(43, 152);
            this.cardNumTb.Mask = "0000-0000-0000-0000";
            this.cardNumTb.Name = "cardNumTb";
            this.cardNumTb.Size = new System.Drawing.Size(490, 27);
            this.cardNumTb.TabIndex = 69;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 68;
            this.label1.Text = "Card Holder Name";
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAmount.Location = new System.Drawing.Point(326, 843);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(192, 36);
            this.labelTotalAmount.TabIndex = 74;
            this.labelTotalAmount.Text = "Total Amount";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(788, 1038);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 73;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCard);
            this.groupBox1.Controls.Add(this.radioButtonFPX);
            this.groupBox1.Controls.Add(this.radioButtonTng);
            this.groupBox1.Location = new System.Drawing.Point(30, 906);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 84);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payment Method";
            // 
            // radioButtonCard
            // 
            this.radioButtonCard.AutoSize = true;
            this.radioButtonCard.Location = new System.Drawing.Point(350, 35);
            this.radioButtonCard.Name = "radioButtonCard";
            this.radioButtonCard.Size = new System.Drawing.Size(125, 24);
            this.radioButtonCard.TabIndex = 65;
            this.radioButtonCard.TabStop = true;
            this.radioButtonCard.Text = "Visa/ Master";
            this.radioButtonCard.UseVisualStyleBackColor = true;
            this.radioButtonCard.CheckedChanged += new System.EventHandler(this.radioButtonCard_CheckedChanged);
            // 
            // radioButtonFPX
            // 
            this.radioButtonFPX.AutoSize = true;
            this.radioButtonFPX.Location = new System.Drawing.Point(204, 35);
            this.radioButtonFPX.Name = "radioButtonFPX";
            this.radioButtonFPX.Size = new System.Drawing.Size(62, 24);
            this.radioButtonFPX.TabIndex = 64;
            this.radioButtonFPX.TabStop = true;
            this.radioButtonFPX.Text = "FPX";
            this.radioButtonFPX.UseVisualStyleBackColor = true;
            this.radioButtonFPX.CheckedChanged += new System.EventHandler(this.radioButtonFPX_CheckedChanged);
            // 
            // radioButtonTng
            // 
            this.radioButtonTng.AutoSize = true;
            this.radioButtonTng.Location = new System.Drawing.Point(29, 35);
            this.radioButtonTng.Name = "radioButtonTng";
            this.radioButtonTng.Size = new System.Drawing.Size(94, 24);
            this.radioButtonTng.TabIndex = 63;
            this.radioButtonTng.TabStop = true;
            this.radioButtonTng.Text = "E-Wallet";
            this.radioButtonTng.UseVisualStyleBackColor = true;
            this.radioButtonTng.CheckedChanged += new System.EventHandler(this.radioButtonTng_CheckedChanged);
            // 
            // tableLayoutPanelSummary
            // 
            this.tableLayoutPanelSummary.AutoScroll = true;
            this.tableLayoutPanelSummary.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelSummary.ColumnCount = 2;
            this.tableLayoutPanelSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelSummary.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanelSummary.Location = new System.Drawing.Point(294, 111);
            this.tableLayoutPanelSummary.Name = "tableLayoutPanelSummary";
            this.tableLayoutPanelSummary.RowCount = 5;
            this.tableLayoutPanelSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelSummary.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelSummary.Size = new System.Drawing.Size(532, 513);
            this.tableLayoutPanelSummary.TabIndex = 72;
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSummary.Location = new System.Drawing.Point(482, 36);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(157, 38);
            this.labelSummary.TabIndex = 71;
            this.labelSummary.Text = "Summary\r\n";
            // 
            // labelAmountDetails
            // 
            this.labelAmountDetails.AutoSize = true;
            this.labelAmountDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmountDetails.Location = new System.Drawing.Point(326, 789);
            this.labelAmountDetails.Name = "labelAmountDetails";
            this.labelAmountDetails.Size = new System.Drawing.Size(232, 29);
            this.labelAmountDetails.TabIndex = 69;
            this.labelAmountDetails.Text = "Package total Price: ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(373, 719);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(255, 38);
            this.label20.TabIndex = 68;
            this.label20.Text = "Payment Details";
            // 
            // ChekourPaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 517);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChekourPaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check out Payment";
            this.Shown += new System.EventHandler(this.ChekourPaymentForm_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPayment)).EndInit();
            this.cardPanel.ResumeLayout(false);
            this.cardPanel.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cvvTb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exDateYYTb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exDateMMTb)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonCard;
        private System.Windows.Forms.RadioButton radioButtonFPX;
        private System.Windows.Forms.RadioButton radioButtonTng;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSummary;
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.Label labelAmountDetails;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.GroupBox cardPanel;
        private System.Windows.Forms.CheckBox policyCb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton masterRb;
        private System.Windows.Forms.RadioButton visaRb;
        private System.Windows.Forms.NumericUpDown cvvTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown exDateYYTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown exDateMMTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cardHolderNameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox cardNumTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxPayment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonBook;
    }
}
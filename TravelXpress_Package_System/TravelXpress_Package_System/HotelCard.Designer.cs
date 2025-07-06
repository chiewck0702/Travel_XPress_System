namespace TravelXpress_Package_System
{
    partial class HotelOutput
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAccommRating = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAccommName = new System.Windows.Forms.Label();
            this.lblAccommLocation = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFacilitiesList = new System.Windows.Forms.Label();
            this.lblFTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 188);
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // lblAccommRating
            // 
            this.lblAccommRating.AutoSize = true;
            this.lblAccommRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccommRating.Location = new System.Drawing.Point(1134, 29);
            this.lblAccommRating.Name = "lblAccommRating";
            this.lblAccommRating.Size = new System.Drawing.Size(20, 22);
            this.lblAccommRating.TabIndex = 47;
            this.lblAccommRating.Text = "8";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(1079, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 56);
            this.button1.TabIndex = 49;
            this.button1.Text = "BOOK ROOM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblAccommName
            // 
            this.lblAccommName.AutoSize = true;
            this.lblAccommName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccommName.Location = new System.Drawing.Point(337, 29);
            this.lblAccommName.Name = "lblAccommName";
            this.lblAccommName.Size = new System.Drawing.Size(41, 38);
            this.lblAccommName.TabIndex = 46;
            this.lblAccommName.Text = "R";
            // 
            // lblAccommLocation
            // 
            this.lblAccommLocation.AutoSize = true;
            this.lblAccommLocation.Location = new System.Drawing.Point(345, 77);
            this.lblAccommLocation.Name = "lblAccommLocation";
            this.lblAccommLocation.Size = new System.Drawing.Size(11, 16);
            this.lblAccommLocation.TabIndex = 48;
            this.lblAccommLocation.Text = "r";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFacilitiesList);
            this.groupBox1.Controls.Add(this.lblFTitle);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblAccommLocation);
            this.groupBox1.Controls.Add(this.lblAccommRating);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.lblAccommName);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1216, 215);
            this.groupBox1.TabIndex = 50;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblFacilitiesList
            // 
            this.lblFacilitiesList.AutoSize = true;
            this.lblFacilitiesList.Location = new System.Drawing.Point(345, 131);
            this.lblFacilitiesList.Name = "lblFacilitiesList";
            this.lblFacilitiesList.Size = new System.Drawing.Size(11, 16);
            this.lblFacilitiesList.TabIndex = 51;
            this.lblFacilitiesList.Text = "r";
            // 
            // lblFTitle
            // 
            this.lblFTitle.AutoSize = true;
            this.lblFTitle.Location = new System.Drawing.Point(345, 104);
            this.lblFTitle.Name = "lblFTitle";
            this.lblFTitle.Size = new System.Drawing.Size(66, 16);
            this.lblFTitle.TabIndex = 50;
            this.lblFTitle.Text = "Facilities :";
            // 
            // HotelOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "HotelOutput";
            this.Size = new System.Drawing.Size(1229, 221);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAccommRating;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAccommName;
        private System.Windows.Forms.Label lblAccommLocation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFacilitiesList;
        private System.Windows.Forms.Label lblFTitle;
    }
}

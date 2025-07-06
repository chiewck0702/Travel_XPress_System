namespace TravelXpress_Package_System
{
    partial class AccommodationAvailabilityPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.SEARCH = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbBoxRating = new System.Windows.Forms.ComboBox();
            this.travelXpressDataSet = new TravelXpress_Package_System.TravelXpressDataSet();
            this.accommodationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accommodationTableAdapter = new TravelXpress_Package_System.TravelXpressDataSetTableAdapters.AccommodationTableAdapter();
            this.accommodationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.accommodationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.accommodationBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.cbBoxStates = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.accommodationBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.travelXpressDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accommodationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accommodationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accommodationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accommodationBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accommodationBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "NEGERI / STATE";
            // 
            // SEARCH
            // 
            this.SEARCH.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.SEARCH.Location = new System.Drawing.Point(395, 99);
            this.SEARCH.Name = "SEARCH";
            this.SEARCH.Size = new System.Drawing.Size(131, 40);
            this.SEARCH.TabIndex = 52;
            this.SEARCH.Text = "SEARCH";
            this.SEARCH.UseVisualStyleBackColor = false;
            this.SEARCH.Click += new System.EventHandler(this.SEARCH_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(23, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1221, 70);
            this.panel2.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(482, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Available Accommodation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1069, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 47;
            this.label4.Text = "Filter ";
            // 
            // cbBoxRating
            // 
            this.cbBoxRating.FormattingEnabled = true;
            this.cbBoxRating.Location = new System.Drawing.Point(1114, 115);
            this.cbBoxRating.Name = "cbBoxRating";
            this.cbBoxRating.Size = new System.Drawing.Size(130, 24);
            this.cbBoxRating.TabIndex = 46;
            this.cbBoxRating.SelectedIndexChanged += new System.EventHandler(this.cbBoxRating_SelectedIndexChanged);
            // 
            // travelXpressDataSet
            // 
            this.travelXpressDataSet.DataSetName = "TravelXpressDataSet";
            this.travelXpressDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accommodationBindingSource
            // 
            this.accommodationBindingSource.DataMember = "Accommodation";
            this.accommodationBindingSource.DataSource = this.travelXpressDataSet;
            // 
            // accommodationTableAdapter
            // 
            this.accommodationTableAdapter.ClearBeforeFill = true;
            // 
            // accommodationBindingSource1
            // 
            this.accommodationBindingSource1.DataMember = "Accommodation";
            this.accommodationBindingSource1.DataSource = this.travelXpressDataSet;
            // 
            // accommodationBindingSource2
            // 
            this.accommodationBindingSource2.DataMember = "Accommodation";
            this.accommodationBindingSource2.DataSource = this.travelXpressDataSet;
            // 
            // accommodationBindingSource3
            // 
            this.accommodationBindingSource3.DataMember = "Accommodation";
            this.accommodationBindingSource3.DataSource = this.travelXpressDataSet;
            // 
            // cbBoxStates
            // 
            this.cbBoxStates.FormattingEnabled = true;
            this.cbBoxStates.Location = new System.Drawing.Point(31, 112);
            this.cbBoxStates.Name = "cbBoxStates";
            this.cbBoxStates.Size = new System.Drawing.Size(340, 24);
            this.cbBoxStates.TabIndex = 57;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(23, 145);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1258, 930);
            this.flowLayoutPanel1.TabIndex = 58;
            // 
            // accommodationBindingSource4
            // 
            this.accommodationBindingSource4.DataMember = "Accommodation";
            this.accommodationBindingSource4.DataSource = this.travelXpressDataSet;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(23, 1086);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 60);
            this.button1.TabIndex = 59;
            this.button1.Text = "BACK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AccommodationAvailabilityPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1300, 1158);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cbBoxStates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SEARCH);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbBoxRating);
            this.Name = "AccommodationAvailabilityPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccommodationAvailabilityPage";
            this.Load += new System.EventHandler(this.AccommodationAvailabilityPage_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.travelXpressDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accommodationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accommodationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accommodationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accommodationBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accommodationBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SEARCH;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbBoxRating;
        private TravelXpressDataSet travelXpressDataSet;
        private System.Windows.Forms.BindingSource accommodationBindingSource;
        private TravelXpressDataSetTableAdapters.AccommodationTableAdapter accommodationTableAdapter;
        private System.Windows.Forms.BindingSource accommodationBindingSource1;
        private System.Windows.Forms.BindingSource accommodationBindingSource2;
        private System.Windows.Forms.BindingSource accommodationBindingSource3;
        private System.Windows.Forms.ComboBox cbBoxStates;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.BindingSource accommodationBindingSource4;
        private System.Windows.Forms.Button button1;
    }
}
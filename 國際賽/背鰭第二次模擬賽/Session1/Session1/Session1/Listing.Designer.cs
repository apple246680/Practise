namespace Session1
{
    partial class Listing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.ListingDetailsTabPage = new System.Windows.Forms.TabPage();
            this.MaximumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MinimumNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.HostRulesTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ExactAddressTextbox = new System.Windows.Forms.TextBox();
            this.ApproximateAddressTextBox = new System.Windows.Forms.TextBox();
            this.BathroomNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BedroomNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CapacityNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.MaximumLabel = new System.Windows.Forms.Label();
            this.MinimumLabel = new System.Windows.Forms.Label();
            this.ReservationTimeLabel = new System.Windows.Forms.Label();
            this.HostRulesLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ExactAddressLabel = new System.Windows.Forms.Label();
            this.ApproximateAddressLabel = new System.Windows.Forms.Label();
            this.BathroomLabel = new System.Windows.Forms.Label();
            this.BedroomsLabel = new System.Windows.Forms.Label();
            this.BedLabel = new System.Windows.Forms.Label();
            this.CapacityLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.AmenitiesTabPage = new System.Windows.Forms.TabPage();
            this.NextBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.AmenitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl.SuspendLayout();
            this.ListingDetailsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BathroomNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BedroomNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BedNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapacityNumericUpDown)).BeginInit();
            this.AmenitiesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmenitiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.ListingDetailsTabPage);
            this.tabControl.Controls.Add(this.AmenitiesTabPage);
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(950, 610);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // ListingDetailsTabPage
            // 
            this.ListingDetailsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.ListingDetailsTabPage.Controls.Add(this.MaximumNumericUpDown);
            this.ListingDetailsTabPage.Controls.Add(this.MinimumNumericUpDown);
            this.ListingDetailsTabPage.Controls.Add(this.HostRulesTextBox);
            this.ListingDetailsTabPage.Controls.Add(this.DescriptionTextBox);
            this.ListingDetailsTabPage.Controls.Add(this.ExactAddressTextbox);
            this.ListingDetailsTabPage.Controls.Add(this.ApproximateAddressTextBox);
            this.ListingDetailsTabPage.Controls.Add(this.BathroomNumericUpDown);
            this.ListingDetailsTabPage.Controls.Add(this.BedroomNumericUpDown);
            this.ListingDetailsTabPage.Controls.Add(this.BedNumericUpDown);
            this.ListingDetailsTabPage.Controls.Add(this.CapacityNumericUpDown);
            this.ListingDetailsTabPage.Controls.Add(this.TitleTextBox);
            this.ListingDetailsTabPage.Controls.Add(this.TypeComboBox);
            this.ListingDetailsTabPage.Controls.Add(this.MaximumLabel);
            this.ListingDetailsTabPage.Controls.Add(this.MinimumLabel);
            this.ListingDetailsTabPage.Controls.Add(this.ReservationTimeLabel);
            this.ListingDetailsTabPage.Controls.Add(this.HostRulesLabel);
            this.ListingDetailsTabPage.Controls.Add(this.DescriptionLabel);
            this.ListingDetailsTabPage.Controls.Add(this.ExactAddressLabel);
            this.ListingDetailsTabPage.Controls.Add(this.ApproximateAddressLabel);
            this.ListingDetailsTabPage.Controls.Add(this.BathroomLabel);
            this.ListingDetailsTabPage.Controls.Add(this.BedroomsLabel);
            this.ListingDetailsTabPage.Controls.Add(this.BedLabel);
            this.ListingDetailsTabPage.Controls.Add(this.CapacityLabel);
            this.ListingDetailsTabPage.Controls.Add(this.TitleLabel);
            this.ListingDetailsTabPage.Controls.Add(this.TypeLabel);
            this.ListingDetailsTabPage.Location = new System.Drawing.Point(4, 29);
            this.ListingDetailsTabPage.Name = "ListingDetailsTabPage";
            this.ListingDetailsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ListingDetailsTabPage.Size = new System.Drawing.Size(942, 577);
            this.ListingDetailsTabPage.TabIndex = 0;
            this.ListingDetailsTabPage.Text = "Listing Details";
            // 
            // MaximumNumericUpDown
            // 
            this.MaximumNumericUpDown.Location = new System.Drawing.Point(525, 552);
            this.MaximumNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MaximumNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaximumNumericUpDown.Name = "MaximumNumericUpDown";
            this.MaximumNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.MaximumNumericUpDown.TabIndex = 24;
            this.MaximumNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MinimumNumericUpDown
            // 
            this.MinimumNumericUpDown.Location = new System.Drawing.Point(278, 551);
            this.MinimumNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MinimumNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinimumNumericUpDown.Name = "MinimumNumericUpDown";
            this.MinimumNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.MinimumNumericUpDown.TabIndex = 23;
            this.MinimumNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HostRulesTextBox
            // 
            this.HostRulesTextBox.Location = new System.Drawing.Point(160, 456);
            this.HostRulesTextBox.Multiline = true;
            this.HostRulesTextBox.Name = "HostRulesTextBox";
            this.HostRulesTextBox.Size = new System.Drawing.Size(767, 76);
            this.HostRulesTextBox.TabIndex = 22;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(160, 374);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(767, 76);
            this.DescriptionTextBox.TabIndex = 21;
            // 
            // ExactAddressTextbox
            // 
            this.ExactAddressTextbox.Location = new System.Drawing.Point(160, 238);
            this.ExactAddressTextbox.Multiline = true;
            this.ExactAddressTextbox.Name = "ExactAddressTextbox";
            this.ExactAddressTextbox.Size = new System.Drawing.Size(767, 130);
            this.ExactAddressTextbox.TabIndex = 20;
            // 
            // ApproximateAddressTextBox
            // 
            this.ApproximateAddressTextBox.Location = new System.Drawing.Point(160, 103);
            this.ApproximateAddressTextBox.Multiline = true;
            this.ApproximateAddressTextBox.Name = "ApproximateAddressTextBox";
            this.ApproximateAddressTextBox.Size = new System.Drawing.Size(767, 130);
            this.ApproximateAddressTextBox.TabIndex = 19;
            // 
            // BathroomNumericUpDown
            // 
            this.BathroomNumericUpDown.Location = new System.Drawing.Point(842, 81);
            this.BathroomNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BathroomNumericUpDown.Name = "BathroomNumericUpDown";
            this.BathroomNumericUpDown.Size = new System.Drawing.Size(85, 26);
            this.BathroomNumericUpDown.TabIndex = 18;
            this.BathroomNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BedroomNumericUpDown
            // 
            this.BedroomNumericUpDown.Location = new System.Drawing.Point(581, 76);
            this.BedroomNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BedroomNumericUpDown.Name = "BedroomNumericUpDown";
            this.BedroomNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.BedroomNumericUpDown.TabIndex = 17;
            this.BedroomNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BedNumericUpDown
            // 
            this.BedNumericUpDown.Location = new System.Drawing.Point(317, 75);
            this.BedNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BedNumericUpDown.Name = "BedNumericUpDown";
            this.BedNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.BedNumericUpDown.TabIndex = 16;
            this.BedNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CapacityNumericUpDown
            // 
            this.CapacityNumericUpDown.Location = new System.Drawing.Point(83, 75);
            this.CapacityNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CapacityNumericUpDown.Name = "CapacityNumericUpDown";
            this.CapacityNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.CapacityNumericUpDown.TabIndex = 15;
            this.CapacityNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(474, 49);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(229, 26);
            this.TitleTextBox.TabIndex = 14;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.BackColor = System.Drawing.Color.White;
            this.TypeComboBox.DisplayMember = "Name";
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(64, 49);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(193, 28);
            this.TypeComboBox.TabIndex = 13;
            this.TypeComboBox.ValueMember = "ID";
            // 
            // MaximumLabel
            // 
            this.MaximumLabel.AutoSize = true;
            this.MaximumLabel.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.MaximumLabel.Location = new System.Drawing.Point(454, 552);
            this.MaximumLabel.Name = "MaximumLabel";
            this.MaximumLabel.Size = new System.Drawing.Size(80, 22);
            this.MaximumLabel.TabIndex = 12;
            this.MaximumLabel.Text = "Maximum:";
            // 
            // MinimumLabel
            // 
            this.MinimumLabel.AutoSize = true;
            this.MinimumLabel.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.MinimumLabel.Location = new System.Drawing.Point(209, 552);
            this.MinimumLabel.Name = "MinimumLabel";
            this.MinimumLabel.Size = new System.Drawing.Size(77, 22);
            this.MinimumLabel.TabIndex = 11;
            this.MinimumLabel.Text = "Minimum:";
            // 
            // ReservationTimeLabel
            // 
            this.ReservationTimeLabel.AutoSize = true;
            this.ReservationTimeLabel.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.ReservationTimeLabel.Location = new System.Drawing.Point(21, 552);
            this.ReservationTimeLabel.Name = "ReservationTimeLabel";
            this.ReservationTimeLabel.Size = new System.Drawing.Size(180, 22);
            this.ReservationTimeLabel.TabIndex = 10;
            this.ReservationTimeLabel.Text = "Reservation Time(Nights):";
            // 
            // HostRulesLabel
            // 
            this.HostRulesLabel.AutoSize = true;
            this.HostRulesLabel.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.HostRulesLabel.Location = new System.Drawing.Point(21, 459);
            this.HostRulesLabel.Name = "HostRulesLabel";
            this.HostRulesLabel.Size = new System.Drawing.Size(86, 22);
            this.HostRulesLabel.TabIndex = 9;
            this.HostRulesLabel.Text = "Host Rules:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.DescriptionLabel.Location = new System.Drawing.Point(21, 379);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(91, 22);
            this.DescriptionLabel.TabIndex = 8;
            this.DescriptionLabel.Text = "Description:";
            // 
            // ExactAddressLabel
            // 
            this.ExactAddressLabel.AutoSize = true;
            this.ExactAddressLabel.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.ExactAddressLabel.Location = new System.Drawing.Point(25, 240);
            this.ExactAddressLabel.Name = "ExactAddressLabel";
            this.ExactAddressLabel.Size = new System.Drawing.Size(108, 22);
            this.ExactAddressLabel.TabIndex = 7;
            this.ExactAddressLabel.Text = "Exact Address:";
            // 
            // ApproximateAddressLabel
            // 
            this.ApproximateAddressLabel.AutoSize = true;
            this.ApproximateAddressLabel.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.ApproximateAddressLabel.Location = new System.Drawing.Point(25, 103);
            this.ApproximateAddressLabel.Name = "ApproximateAddressLabel";
            this.ApproximateAddressLabel.Size = new System.Drawing.Size(159, 22);
            this.ApproximateAddressLabel.TabIndex = 6;
            this.ApproximateAddressLabel.Text = "Approximate Address:";
            // 
            // BathroomLabel
            // 
            this.BathroomLabel.AutoSize = true;
            this.BathroomLabel.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.BathroomLabel.Location = new System.Drawing.Point(707, 81);
            this.BathroomLabel.Name = "BathroomLabel";
            this.BathroomLabel.Size = new System.Drawing.Size(160, 22);
            this.BathroomLabel.TabIndex = 5;
            this.BathroomLabel.Text = "Number of Bathroom:";
            // 
            // BedroomsLabel
            // 
            this.BedroomsLabel.AutoSize = true;
            this.BedroomsLabel.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.BedroomsLabel.Location = new System.Drawing.Point(443, 76);
            this.BedroomsLabel.Name = "BedroomsLabel";
            this.BedroomsLabel.Size = new System.Drawing.Size(162, 22);
            this.BedroomsLabel.TabIndex = 4;
            this.BedroomsLabel.Text = "Number of Bedrooms:";
            // 
            // BedLabel
            // 
            this.BedLabel.AutoSize = true;
            this.BedLabel.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.BedLabel.Location = new System.Drawing.Point(209, 76);
            this.BedLabel.Name = "BedLabel";
            this.BedLabel.Size = new System.Drawing.Size(125, 22);
            this.BedLabel.TabIndex = 3;
            this.BedLabel.Text = "Number of Beds:";
            // 
            // CapacityLabel
            // 
            this.CapacityLabel.AutoSize = true;
            this.CapacityLabel.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.CapacityLabel.Location = new System.Drawing.Point(21, 75);
            this.CapacityLabel.Name = "CapacityLabel";
            this.CapacityLabel.Size = new System.Drawing.Size(70, 22);
            this.CapacityLabel.TabIndex = 2;
            this.CapacityLabel.Text = "Capacity:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.TitleLabel.Location = new System.Drawing.Point(412, 49);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(41, 22);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title:";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.TypeLabel.Location = new System.Drawing.Point(21, 49);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(46, 22);
            this.TypeLabel.TabIndex = 0;
            this.TypeLabel.Text = "Type:";
            // 
            // AmenitiesTabPage
            // 
            this.AmenitiesTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.AmenitiesTabPage.Controls.Add(this.AmenitiesDataGridView);
            this.AmenitiesTabPage.Location = new System.Drawing.Point(4, 29);
            this.AmenitiesTabPage.Name = "AmenitiesTabPage";
            this.AmenitiesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AmenitiesTabPage.Size = new System.Drawing.Size(942, 577);
            this.AmenitiesTabPage.TabIndex = 1;
            this.AmenitiesTabPage.Text = "Amenities";
            // 
            // NextBtn
            // 
            this.NextBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.Location = new System.Drawing.Point(778, 619);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(75, 23);
            this.NextBtn.TabIndex = 1;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseBtn.Location = new System.Drawing.Point(859, 619);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(90, 23);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Close/Finish";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // AmenitiesDataGridView
            // 
            this.AmenitiesDataGridView.AllowUserToAddRows = false;
            this.AmenitiesDataGridView.AllowUserToDeleteRows = false;
            this.AmenitiesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AmenitiesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.AmenitiesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans Light", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AmenitiesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AmenitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AmenitiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.AmenitiesDataGridView.EnableHeadersVisualStyles = false;
            this.AmenitiesDataGridView.GridColor = System.Drawing.Color.Black;
            this.AmenitiesDataGridView.Location = new System.Drawing.Point(5, 6);
            this.AmenitiesDataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AmenitiesDataGridView.MultiSelect = false;
            this.AmenitiesDataGridView.Name = "AmenitiesDataGridView";
            this.AmenitiesDataGridView.RowHeadersVisible = false;
            this.AmenitiesDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.AmenitiesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.AmenitiesDataGridView.RowTemplate.Height = 27;
            this.AmenitiesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AmenitiesDataGridView.Size = new System.Drawing.Size(932, 303);
            this.AmenitiesDataGridView.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Amenity";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Listing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Open Sans Light", 8.25F);
            this.Name = "Listing";
            this.Size = new System.Drawing.Size(961, 654);
            this.tabControl.ResumeLayout(false);
            this.ListingDetailsTabPage.ResumeLayout(false);
            this.ListingDetailsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaximumNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimumNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BathroomNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BedroomNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BedNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapacityNumericUpDown)).EndInit();
            this.AmenitiesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AmenitiesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage ListingDetailsTabPage;
        private System.Windows.Forms.TabPage AmenitiesTabPage;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label MinimumLabel;
        private System.Windows.Forms.Label ReservationTimeLabel;
        private System.Windows.Forms.Label HostRulesLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label ExactAddressLabel;
        private System.Windows.Forms.Label ApproximateAddressLabel;
        private System.Windows.Forms.Label BathroomLabel;
        private System.Windows.Forms.Label BedroomsLabel;
        private System.Windows.Forms.Label BedLabel;
        private System.Windows.Forms.Label CapacityLabel;
        private System.Windows.Forms.Label MaximumLabel;
        private System.Windows.Forms.NumericUpDown MaximumNumericUpDown;
        private System.Windows.Forms.NumericUpDown MinimumNumericUpDown;
        private System.Windows.Forms.TextBox HostRulesTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox ExactAddressTextbox;
        private System.Windows.Forms.TextBox ApproximateAddressTextBox;
        private System.Windows.Forms.NumericUpDown BathroomNumericUpDown;
        private System.Windows.Forms.NumericUpDown BedroomNumericUpDown;
        private System.Windows.Forms.NumericUpDown BedNumericUpDown;
        private System.Windows.Forms.NumericUpDown CapacityNumericUpDown;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.DataGridView AmenitiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
    }
}

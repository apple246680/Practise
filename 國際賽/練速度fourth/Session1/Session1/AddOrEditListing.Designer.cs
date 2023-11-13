namespace Session1
{
    partial class AddOrEditListing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ListingTabControl = new System.Windows.Forms.TabControl();
            this.ListingDetailsPage = new System.Windows.Forms.TabPage();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.MaxNum = new System.Windows.Forms.NumericUpDown();
            this.MinNum = new System.Windows.Forms.NumericUpDown();
            this.MaximumLabel = new System.Windows.Forms.Label();
            this.MinmumLabel = new System.Windows.Forms.Label();
            this.HostRulesTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ExactAddressTextBox = new System.Windows.Forms.TextBox();
            this.ExactAddressLabel = new System.Windows.Forms.Label();
            this.ApproximateAddressTextBox = new System.Windows.Forms.TextBox();
            this.BathroomNum = new System.Windows.Forms.NumericUpDown();
            this.BedroomNum = new System.Windows.Forms.NumericUpDown();
            this.BedsNum = new System.Windows.Forms.NumericUpDown();
            this.CapacityyNum = new System.Windows.Forms.NumericUpDown();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.ReservationTimeLabel = new System.Windows.Forms.Label();
            this.HostRulesLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.ApproximateAddressLabel = new System.Windows.Forms.Label();
            this.BathroomLabel = new System.Windows.Forms.Label();
            this.BedroomLabel = new System.Windows.Forms.Label();
            this.BedLabel = new System.Windows.Forms.Label();
            this.CapacityLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.AmenitiesPage = new System.Windows.Forms.TabPage();
            this.AmenitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ChooesAmenitiesLabel = new System.Windows.Forms.Label();
            this.DistanceToAttractionPage = new System.Windows.Forms.TabPage();
            this.DistanceDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AttractionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DistanceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OnFootColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ByCarColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BodyLabel = new System.Windows.Forms.Label();
            this.NextBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.ListingTabControl.SuspendLayout();
            this.ListingDetailsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BathroomNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BedroomNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BedsNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapacityyNum)).BeginInit();
            this.AmenitiesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmenitiesDataGridView)).BeginInit();
            this.DistanceToAttractionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ListingTabControl
            // 
            this.ListingTabControl.Controls.Add(this.ListingDetailsPage);
            this.ListingTabControl.Controls.Add(this.AmenitiesPage);
            this.ListingTabControl.Controls.Add(this.DistanceToAttractionPage);
            this.ListingTabControl.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            this.ListingTabControl.Location = new System.Drawing.Point(55, 87);
            this.ListingTabControl.Name = "ListingTabControl";
            this.ListingTabControl.SelectedIndex = 0;
            this.ListingTabControl.Size = new System.Drawing.Size(888, 426);
            this.ListingTabControl.TabIndex = 17;
            this.ListingTabControl.SelectedIndexChanged += new System.EventHandler(this.ListingTabControl_SelectedIndexChanged);
            // 
            // ListingDetailsPage
            // 
            this.ListingDetailsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.ListingDetailsPage.Controls.Add(this.TitleTextBox);
            this.ListingDetailsPage.Controls.Add(this.MaxNum);
            this.ListingDetailsPage.Controls.Add(this.MinNum);
            this.ListingDetailsPage.Controls.Add(this.MaximumLabel);
            this.ListingDetailsPage.Controls.Add(this.MinmumLabel);
            this.ListingDetailsPage.Controls.Add(this.HostRulesTextBox);
            this.ListingDetailsPage.Controls.Add(this.DescriptionTextBox);
            this.ListingDetailsPage.Controls.Add(this.ExactAddressTextBox);
            this.ListingDetailsPage.Controls.Add(this.ExactAddressLabel);
            this.ListingDetailsPage.Controls.Add(this.ApproximateAddressTextBox);
            this.ListingDetailsPage.Controls.Add(this.BathroomNum);
            this.ListingDetailsPage.Controls.Add(this.BedroomNum);
            this.ListingDetailsPage.Controls.Add(this.BedsNum);
            this.ListingDetailsPage.Controls.Add(this.CapacityyNum);
            this.ListingDetailsPage.Controls.Add(this.TypeComboBox);
            this.ListingDetailsPage.Controls.Add(this.ReservationTimeLabel);
            this.ListingDetailsPage.Controls.Add(this.HostRulesLabel);
            this.ListingDetailsPage.Controls.Add(this.DescriptionLabel);
            this.ListingDetailsPage.Controls.Add(this.ApproximateAddressLabel);
            this.ListingDetailsPage.Controls.Add(this.BathroomLabel);
            this.ListingDetailsPage.Controls.Add(this.BedroomLabel);
            this.ListingDetailsPage.Controls.Add(this.BedLabel);
            this.ListingDetailsPage.Controls.Add(this.CapacityLabel);
            this.ListingDetailsPage.Controls.Add(this.TitleLabel);
            this.ListingDetailsPage.Controls.Add(this.TypeLabel);
            this.ListingDetailsPage.Location = new System.Drawing.Point(4, 31);
            this.ListingDetailsPage.Name = "ListingDetailsPage";
            this.ListingDetailsPage.Padding = new System.Windows.Forms.Padding(3);
            this.ListingDetailsPage.Size = new System.Drawing.Size(880, 391);
            this.ListingDetailsPage.TabIndex = 0;
            this.ListingDetailsPage.Text = "Listing Details";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.BackColor = System.Drawing.Color.White;
            this.TitleTextBox.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.TitleTextBox.ForeColor = System.Drawing.Color.Black;
            this.TitleTextBox.Location = new System.Drawing.Point(536, 12);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(330, 28);
            this.TitleTextBox.TabIndex = 25;
            // 
            // MaxNum
            // 
            this.MaxNum.BackColor = System.Drawing.Color.White;
            this.MaxNum.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.MaxNum.ForeColor = System.Drawing.Color.Black;
            this.MaxNum.Location = new System.Drawing.Point(519, 333);
            this.MaxNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MaxNum.Name = "MaxNum";
            this.MaxNum.Size = new System.Drawing.Size(64, 28);
            this.MaxNum.TabIndex = 24;
            // 
            // MinNum
            // 
            this.MinNum.BackColor = System.Drawing.Color.White;
            this.MinNum.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.MinNum.ForeColor = System.Drawing.Color.Black;
            this.MinNum.Location = new System.Drawing.Point(350, 333);
            this.MinNum.Name = "MinNum";
            this.MinNum.Size = new System.Drawing.Size(64, 28);
            this.MinNum.TabIndex = 23;
            // 
            // MaximumLabel
            // 
            this.MaximumLabel.AutoSize = true;
            this.MaximumLabel.Font = new System.Drawing.Font("Open Sans", 10F);
            this.MaximumLabel.Location = new System.Drawing.Point(420, 333);
            this.MaximumLabel.Name = "MaximumLabel";
            this.MaximumLabel.Size = new System.Drawing.Size(93, 24);
            this.MaximumLabel.TabIndex = 22;
            this.MaximumLabel.Text = "Maximum:";
            // 
            // MinmumLabel
            // 
            this.MinmumLabel.AutoSize = true;
            this.MinmumLabel.Font = new System.Drawing.Font("Open Sans", 10F);
            this.MinmumLabel.Location = new System.Drawing.Point(255, 333);
            this.MinmumLabel.Name = "MinmumLabel";
            this.MinmumLabel.Size = new System.Drawing.Size(89, 24);
            this.MinmumLabel.TabIndex = 21;
            this.MinmumLabel.Text = "Minimum:";
            // 
            // HostRulesTextBox
            // 
            this.HostRulesTextBox.BackColor = System.Drawing.Color.White;
            this.HostRulesTextBox.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.HostRulesTextBox.ForeColor = System.Drawing.Color.Black;
            this.HostRulesTextBox.Location = new System.Drawing.Point(198, 250);
            this.HostRulesTextBox.Multiline = true;
            this.HostRulesTextBox.Name = "HostRulesTextBox";
            this.HostRulesTextBox.Size = new System.Drawing.Size(676, 56);
            this.HostRulesTextBox.TabIndex = 20;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.BackColor = System.Drawing.Color.White;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.DescriptionTextBox.ForeColor = System.Drawing.Color.Black;
            this.DescriptionTextBox.Location = new System.Drawing.Point(198, 188);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(676, 56);
            this.DescriptionTextBox.TabIndex = 19;
            // 
            // ExactAddressTextBox
            // 
            this.ExactAddressTextBox.BackColor = System.Drawing.Color.White;
            this.ExactAddressTextBox.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.ExactAddressTextBox.ForeColor = System.Drawing.Color.Black;
            this.ExactAddressTextBox.Location = new System.Drawing.Point(198, 126);
            this.ExactAddressTextBox.Multiline = true;
            this.ExactAddressTextBox.Name = "ExactAddressTextBox";
            this.ExactAddressTextBox.Size = new System.Drawing.Size(676, 56);
            this.ExactAddressTextBox.TabIndex = 18;
            // 
            // ExactAddressLabel
            // 
            this.ExactAddressLabel.AutoSize = true;
            this.ExactAddressLabel.Font = new System.Drawing.Font("Open Sans", 10F);
            this.ExactAddressLabel.Location = new System.Drawing.Point(3, 126);
            this.ExactAddressLabel.Name = "ExactAddressLabel";
            this.ExactAddressLabel.Size = new System.Drawing.Size(119, 24);
            this.ExactAddressLabel.TabIndex = 17;
            this.ExactAddressLabel.Text = "Exact Address";
            // 
            // ApproximateAddressTextBox
            // 
            this.ApproximateAddressTextBox.BackColor = System.Drawing.Color.White;
            this.ApproximateAddressTextBox.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.ApproximateAddressTextBox.ForeColor = System.Drawing.Color.Black;
            this.ApproximateAddressTextBox.Location = new System.Drawing.Point(198, 91);
            this.ApproximateAddressTextBox.Name = "ApproximateAddressTextBox";
            this.ApproximateAddressTextBox.Size = new System.Drawing.Size(676, 28);
            this.ApproximateAddressTextBox.TabIndex = 16;
            // 
            // BathroomNum
            // 
            this.BathroomNum.BackColor = System.Drawing.Color.White;
            this.BathroomNum.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.BathroomNum.ForeColor = System.Drawing.Color.Black;
            this.BathroomNum.Location = new System.Drawing.Point(817, 57);
            this.BathroomNum.Name = "BathroomNum";
            this.BathroomNum.Size = new System.Drawing.Size(60, 28);
            this.BathroomNum.TabIndex = 15;
            // 
            // BedroomNum
            // 
            this.BedroomNum.BackColor = System.Drawing.Color.White;
            this.BedroomNum.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.BedroomNum.ForeColor = System.Drawing.Color.Black;
            this.BedroomNum.Location = new System.Drawing.Point(569, 53);
            this.BedroomNum.Name = "BedroomNum";
            this.BedroomNum.Size = new System.Drawing.Size(60, 28);
            this.BedroomNum.TabIndex = 14;
            // 
            // BedsNum
            // 
            this.BedsNum.BackColor = System.Drawing.Color.White;
            this.BedsNum.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.BedsNum.ForeColor = System.Drawing.Color.Black;
            this.BedsNum.Location = new System.Drawing.Point(310, 53);
            this.BedsNum.Name = "BedsNum";
            this.BedsNum.Size = new System.Drawing.Size(61, 28);
            this.BedsNum.TabIndex = 13;
            // 
            // CapacityyNum
            // 
            this.CapacityyNum.BackColor = System.Drawing.Color.White;
            this.CapacityyNum.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.CapacityyNum.ForeColor = System.Drawing.Color.Black;
            this.CapacityyNum.Location = new System.Drawing.Point(91, 49);
            this.CapacityyNum.Name = "CapacityyNum";
            this.CapacityyNum.Size = new System.Drawing.Size(64, 28);
            this.CapacityyNum.TabIndex = 12;
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.TypeComboBox.ForeColor = System.Drawing.Color.Black;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(84, 12);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(393, 30);
            this.TypeComboBox.TabIndex = 10;
            // 
            // ReservationTimeLabel
            // 
            this.ReservationTimeLabel.AutoSize = true;
            this.ReservationTimeLabel.Font = new System.Drawing.Font("Open Sans", 10F);
            this.ReservationTimeLabel.Location = new System.Drawing.Point(8, 333);
            this.ReservationTimeLabel.Name = "ReservationTimeLabel";
            this.ReservationTimeLabel.Size = new System.Drawing.Size(205, 24);
            this.ReservationTimeLabel.TabIndex = 9;
            this.ReservationTimeLabel.Text = "Reservation Time (Night):";
            // 
            // HostRulesLabel
            // 
            this.HostRulesLabel.AutoSize = true;
            this.HostRulesLabel.Font = new System.Drawing.Font("Open Sans", 10F);
            this.HostRulesLabel.Location = new System.Drawing.Point(3, 250);
            this.HostRulesLabel.Name = "HostRulesLabel";
            this.HostRulesLabel.Size = new System.Drawing.Size(97, 24);
            this.HostRulesLabel.TabIndex = 8;
            this.HostRulesLabel.Text = "Host Rules:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Open Sans", 10F);
            this.DescriptionLabel.Location = new System.Drawing.Point(3, 188);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(103, 24);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "Description:";
            // 
            // ApproximateAddressLabel
            // 
            this.ApproximateAddressLabel.AutoSize = true;
            this.ApproximateAddressLabel.Font = new System.Drawing.Font("Open Sans", 10F);
            this.ApproximateAddressLabel.Location = new System.Drawing.Point(6, 91);
            this.ApproximateAddressLabel.Name = "ApproximateAddressLabel";
            this.ApproximateAddressLabel.Size = new System.Drawing.Size(184, 24);
            this.ApproximateAddressLabel.TabIndex = 6;
            this.ApproximateAddressLabel.Text = "Approximate Address:";
            // 
            // BathroomLabel
            // 
            this.BathroomLabel.AutoSize = true;
            this.BathroomLabel.Font = new System.Drawing.Font("Open Sans", 10F);
            this.BathroomLabel.Location = new System.Drawing.Point(635, 57);
            this.BathroomLabel.Name = "BathroomLabel";
            this.BathroomLabel.Size = new System.Drawing.Size(183, 24);
            this.BathroomLabel.TabIndex = 5;
            this.BathroomLabel.Text = "Number of Bathroom:";
            // 
            // BedroomLabel
            // 
            this.BedroomLabel.AutoSize = true;
            this.BedroomLabel.Font = new System.Drawing.Font("Open Sans", 10F);
            this.BedroomLabel.Location = new System.Drawing.Point(377, 53);
            this.BedroomLabel.Name = "BedroomLabel";
            this.BedroomLabel.Size = new System.Drawing.Size(186, 24);
            this.BedroomLabel.TabIndex = 4;
            this.BedroomLabel.Text = "Number of Bedrooms:";
            // 
            // BedLabel
            // 
            this.BedLabel.AutoSize = true;
            this.BedLabel.Font = new System.Drawing.Font("Open Sans", 10F);
            this.BedLabel.Location = new System.Drawing.Point(161, 53);
            this.BedLabel.Name = "BedLabel";
            this.BedLabel.Size = new System.Drawing.Size(143, 24);
            this.BedLabel.TabIndex = 3;
            this.BedLabel.Text = "Number of Beds:";
            // 
            // CapacityLabel
            // 
            this.CapacityLabel.AutoSize = true;
            this.CapacityLabel.Font = new System.Drawing.Font("Open Sans", 10F);
            this.CapacityLabel.Location = new System.Drawing.Point(8, 53);
            this.CapacityLabel.Name = "CapacityLabel";
            this.CapacityLabel.Size = new System.Drawing.Size(80, 24);
            this.CapacityLabel.TabIndex = 2;
            this.CapacityLabel.Text = "Capacity:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Open Sans", 10F);
            this.TitleLabel.Location = new System.Drawing.Point(483, 12);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(47, 24);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Title:";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Font = new System.Drawing.Font("Open Sans", 10F);
            this.TypeLabel.Location = new System.Drawing.Point(25, 12);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(52, 24);
            this.TypeLabel.TabIndex = 0;
            this.TypeLabel.Text = "Type:";
            // 
            // AmenitiesPage
            // 
            this.AmenitiesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.AmenitiesPage.Controls.Add(this.AmenitiesDataGridView);
            this.AmenitiesPage.Controls.Add(this.ChooesAmenitiesLabel);
            this.AmenitiesPage.Location = new System.Drawing.Point(4, 31);
            this.AmenitiesPage.Name = "AmenitiesPage";
            this.AmenitiesPage.Padding = new System.Windows.Forms.Padding(3);
            this.AmenitiesPage.Size = new System.Drawing.Size(880, 391);
            this.AmenitiesPage.TabIndex = 1;
            this.AmenitiesPage.Text = "Amenities";
            // 
            // AmenitiesDataGridView
            // 
            this.AmenitiesDataGridView.AllowUserToAddRows = false;
            this.AmenitiesDataGridView.AllowUserToDeleteRows = false;
            this.AmenitiesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AmenitiesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.AmenitiesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AmenitiesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.AmenitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AmenitiesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.AmenitiesDataGridView.EnableHeadersVisualStyles = false;
            this.AmenitiesDataGridView.GridColor = System.Drawing.Color.Black;
            this.AmenitiesDataGridView.Location = new System.Drawing.Point(10, 38);
            this.AmenitiesDataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.AmenitiesDataGridView.MultiSelect = false;
            this.AmenitiesDataGridView.Name = "AmenitiesDataGridView";
            this.AmenitiesDataGridView.RowHeadersVisible = false;
            this.AmenitiesDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.AmenitiesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.AmenitiesDataGridView.RowTemplate.Height = 27;
            this.AmenitiesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AmenitiesDataGridView.Size = new System.Drawing.Size(461, 303);
            this.AmenitiesDataGridView.TabIndex = 8;
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
            // ChooesAmenitiesLabel
            // 
            this.ChooesAmenitiesLabel.AutoSize = true;
            this.ChooesAmenitiesLabel.Font = new System.Drawing.Font("Open Sans", 12F);
            this.ChooesAmenitiesLabel.Location = new System.Drawing.Point(6, 12);
            this.ChooesAmenitiesLabel.Name = "ChooesAmenitiesLabel";
            this.ChooesAmenitiesLabel.Size = new System.Drawing.Size(273, 28);
            this.ChooesAmenitiesLabel.TabIndex = 0;
            this.ChooesAmenitiesLabel.Text = "Choose Available Amenities:";
            // 
            // DistanceToAttractionPage
            // 
            this.DistanceToAttractionPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.DistanceToAttractionPage.Controls.Add(this.DistanceDataGridView);
            this.DistanceToAttractionPage.Controls.Add(this.BodyLabel);
            this.DistanceToAttractionPage.Location = new System.Drawing.Point(4, 31);
            this.DistanceToAttractionPage.Name = "DistanceToAttractionPage";
            this.DistanceToAttractionPage.Size = new System.Drawing.Size(880, 391);
            this.DistanceToAttractionPage.TabIndex = 2;
            this.DistanceToAttractionPage.Text = "Distance to Attraction";
            // 
            // DistanceDataGridView
            // 
            this.DistanceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DistanceDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.DistanceDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DistanceDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DistanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DistanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.AttractionColumn,
            this.AreaColumn,
            this.DistanceColumn,
            this.OnFootColumn,
            this.ByCarColumn});
            this.DistanceDataGridView.EnableHeadersVisualStyles = false;
            this.DistanceDataGridView.GridColor = System.Drawing.Color.Black;
            this.DistanceDataGridView.Location = new System.Drawing.Point(17, 31);
            this.DistanceDataGridView.Name = "DistanceDataGridView";
            this.DistanceDataGridView.RowHeadersVisible = false;
            this.DistanceDataGridView.RowHeadersWidth = 62;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.DistanceDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.DistanceDataGridView.RowTemplate.Height = 27;
            this.DistanceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DistanceDataGridView.Size = new System.Drawing.Size(860, 357);
            this.DistanceDataGridView.TabIndex = 23;
            this.DistanceDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DistanceDataGridView_CellEndEdit);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // AttractionColumn
            // 
            this.AttractionColumn.HeaderText = "Attraction";
            this.AttractionColumn.MinimumWidth = 6;
            this.AttractionColumn.Name = "AttractionColumn";
            // 
            // AreaColumn
            // 
            this.AreaColumn.HeaderText = "Area";
            this.AreaColumn.MinimumWidth = 6;
            this.AreaColumn.Name = "AreaColumn";
            // 
            // DistanceColumn
            // 
            this.DistanceColumn.HeaderText = "Distance (km)";
            this.DistanceColumn.MinimumWidth = 6;
            this.DistanceColumn.Name = "DistanceColumn";
            // 
            // OnFootColumn
            // 
            this.OnFootColumn.HeaderText = "On Foot (minutes)";
            this.OnFootColumn.MinimumWidth = 6;
            this.OnFootColumn.Name = "OnFootColumn";
            // 
            // ByCarColumn
            // 
            this.ByCarColumn.HeaderText = "By Car (minutes)";
            this.ByCarColumn.MinimumWidth = 6;
            this.ByCarColumn.Name = "ByCarColumn";
            // 
            // BodyLabel
            // 
            this.BodyLabel.AutoSize = true;
            this.BodyLabel.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            this.BodyLabel.Location = new System.Drawing.Point(13, 11);
            this.BodyLabel.Name = "BodyLabel";
            this.BodyLabel.Size = new System.Drawing.Size(636, 22);
            this.BodyLabel.TabIndex = 7;
            this.BodyLabel.Text = "Specify the distance from each close by attraction and the time it takes to get t" +
    "o them:";
            // 
            // NextBtn
            // 
            this.NextBtn.BackColor = System.Drawing.Color.White;
            this.NextBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            this.NextBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.NextBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NextBtn.Location = new System.Drawing.Point(764, 519);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(58, 36);
            this.NextBtn.TabIndex = 15;
            this.NextBtn.Text = "Next";
            this.NextBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NextBtn.UseVisualStyleBackColor = false;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.White;
            this.CloseBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            this.CloseBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.CloseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseBtn.Location = new System.Drawing.Point(828, 519);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(115, 36);
            this.CloseBtn.TabIndex = 16;
            this.CloseBtn.Text = "Close/Finish";
            this.CloseBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // AddOrEditListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.Controls.Add(this.ListingTabControl);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.CloseBtn);
            this.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddOrEditListing";
            this.Size = new System.Drawing.Size(1000, 800);
            this.Load += new System.EventHandler(this.AddOrEditListing_Load);
            this.ListingTabControl.ResumeLayout(false);
            this.ListingDetailsPage.ResumeLayout(false);
            this.ListingDetailsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MaxNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BathroomNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BedroomNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BedsNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CapacityyNum)).EndInit();
            this.AmenitiesPage.ResumeLayout(false);
            this.AmenitiesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmenitiesDataGridView)).EndInit();
            this.DistanceToAttractionPage.ResumeLayout(false);
            this.DistanceToAttractionPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DistanceDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ListingTabControl;
        private System.Windows.Forms.TabPage ListingDetailsPage;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.NumericUpDown MaxNum;
        private System.Windows.Forms.NumericUpDown MinNum;
        private System.Windows.Forms.Label MaximumLabel;
        private System.Windows.Forms.Label MinmumLabel;
        private System.Windows.Forms.TextBox HostRulesTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox ExactAddressTextBox;
        private System.Windows.Forms.Label ExactAddressLabel;
        private System.Windows.Forms.TextBox ApproximateAddressTextBox;
        private System.Windows.Forms.NumericUpDown BathroomNum;
        private System.Windows.Forms.NumericUpDown BedroomNum;
        private System.Windows.Forms.NumericUpDown BedsNum;
        private System.Windows.Forms.NumericUpDown CapacityyNum;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label ReservationTimeLabel;
        private System.Windows.Forms.Label HostRulesLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label ApproximateAddressLabel;
        private System.Windows.Forms.Label BathroomLabel;
        private System.Windows.Forms.Label BedroomLabel;
        private System.Windows.Forms.Label BedLabel;
        private System.Windows.Forms.Label CapacityLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.TabPage AmenitiesPage;
        private System.Windows.Forms.DataGridView AmenitiesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.Label ChooesAmenitiesLabel;
        private System.Windows.Forms.TabPage DistanceToAttractionPage;
        private System.Windows.Forms.DataGridView DistanceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttractionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DistanceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OnFootColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ByCarColumn;
        private System.Windows.Forms.Label BodyLabel;
        private System.Windows.Forms.Button NextBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}

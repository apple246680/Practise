namespace Session2
{
    partial class AdvancedSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SimpleSearchBtn = new System.Windows.Forms.Button();
            this.AmenityComboBox3 = new System.Windows.Forms.ComboBox();
            this.Amenity3Label = new System.Windows.Forms.Label();
            this.AmenityComboBox2 = new System.Windows.Forms.ComboBox();
            this.Amenity2Label = new System.Windows.Forms.Label();
            this.AmenityComboBox1 = new System.Windows.Forms.ComboBox();
            this.Amenity1Label = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.MaxPrice = new System.Windows.Forms.NumericUpDown();
            this.MaxPriceLabel = new System.Windows.Forms.Label();
            this.StartPriceLabel = new System.Windows.Forms.Label();
            this.PeopleLabel = new System.Windows.Forms.Label();
            this.PeopleNum = new System.Windows.Forms.NumericUpDown();
            this.StartPrice = new System.Windows.Forms.NumericUpDown();
            this.NightLabel = new System.Windows.Forms.Label();
            this.NightNum = new System.Windows.Forms.NumericUpDown();
            this.ForLabel = new System.Windows.Forms.Label();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.ToLabel = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.TitleComboBox = new System.Windows.Forms.ComboBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.AttractionComboBox = new System.Windows.Forms.ComboBox();
            this.AttractionLabel = new System.Windows.Forms.Label();
            this.AreaComboBox = new System.Windows.Forms.ComboBox();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.AdvancedSearchGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultsPanel = new System.Windows.Forms.Panel();
            this.CountLabel = new System.Windows.Forms.Label();
            this.SearchResultsGroupBox = new System.Windows.Forms.GroupBox();
            this.ResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.PropertyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AreaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageScoreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCompletedReservationsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPayableColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckInColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NightNum)).BeginInit();
            this.AdvancedSearchGroupBox.SuspendLayout();
            this.ResultsPanel.SuspendLayout();
            this.SearchResultsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBtn.Location = new System.Drawing.Point(791, 241);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(220, 38);
            this.SearchBtn.TabIndex = 29;
            this.SearchBtn.Text = "Search properties...";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(623, 241);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(162, 38);
            this.ClearBtn.TabIndex = 28;
            this.ClearBtn.Text = "Clear form";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SimpleSearchBtn
            // 
            this.SimpleSearchBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimpleSearchBtn.Location = new System.Drawing.Point(455, 241);
            this.SimpleSearchBtn.Name = "SimpleSearchBtn";
            this.SimpleSearchBtn.Size = new System.Drawing.Size(162, 38);
            this.SimpleSearchBtn.TabIndex = 27;
            this.SimpleSearchBtn.Text = "Simple Search";
            this.SimpleSearchBtn.UseVisualStyleBackColor = true;
            this.SimpleSearchBtn.Click += new System.EventHandler(this.SimpleSearchBtn_Click);
            // 
            // AmenityComboBox3
            // 
            this.AmenityComboBox3.DisplayMember = "Name";
            this.AmenityComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AmenityComboBox3.FormattingEnabled = true;
            this.AmenityComboBox3.Location = new System.Drawing.Point(895, 202);
            this.AmenityComboBox3.Name = "AmenityComboBox3";
            this.AmenityComboBox3.Size = new System.Drawing.Size(253, 30);
            this.AmenityComboBox3.TabIndex = 26;
            this.AmenityComboBox3.Tag = "3";
            this.AmenityComboBox3.ValueMember = "ID";
            this.AmenityComboBox3.SelectedIndexChanged += new System.EventHandler(this.AmenityComboBox_SelectedIndexChanged);
            this.AmenityComboBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AmenityComboBox_MouseClick);
            // 
            // Amenity3Label
            // 
            this.Amenity3Label.AutoSize = true;
            this.Amenity3Label.Location = new System.Drawing.Point(800, 205);
            this.Amenity3Label.Name = "Amenity3Label";
            this.Amenity3Label.Size = new System.Drawing.Size(68, 22);
            this.Amenity3Label.TabIndex = 25;
            this.Amenity3Label.Text = "Amenity:";
            // 
            // AmenityComboBox2
            // 
            this.AmenityComboBox2.DisplayMember = "Name";
            this.AmenityComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AmenityComboBox2.FormattingEnabled = true;
            this.AmenityComboBox2.Location = new System.Drawing.Point(532, 199);
            this.AmenityComboBox2.Name = "AmenityComboBox2";
            this.AmenityComboBox2.Size = new System.Drawing.Size(253, 30);
            this.AmenityComboBox2.TabIndex = 24;
            this.AmenityComboBox2.Tag = "2";
            this.AmenityComboBox2.ValueMember = "ID";
            this.AmenityComboBox2.SelectedIndexChanged += new System.EventHandler(this.AmenityComboBox_SelectedIndexChanged);
            this.AmenityComboBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AmenityComboBox_MouseClick);
            // 
            // Amenity2Label
            // 
            this.Amenity2Label.AutoSize = true;
            this.Amenity2Label.Location = new System.Drawing.Point(437, 202);
            this.Amenity2Label.Name = "Amenity2Label";
            this.Amenity2Label.Size = new System.Drawing.Size(68, 22);
            this.Amenity2Label.TabIndex = 23;
            this.Amenity2Label.Text = "Amenity:";
            // 
            // AmenityComboBox1
            // 
            this.AmenityComboBox1.DisplayMember = "Name";
            this.AmenityComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AmenityComboBox1.FormattingEnabled = true;
            this.AmenityComboBox1.Location = new System.Drawing.Point(159, 199);
            this.AmenityComboBox1.Name = "AmenityComboBox1";
            this.AmenityComboBox1.Size = new System.Drawing.Size(253, 30);
            this.AmenityComboBox1.TabIndex = 22;
            this.AmenityComboBox1.Tag = "1";
            this.AmenityComboBox1.ValueMember = "ID";
            this.AmenityComboBox1.SelectedIndexChanged += new System.EventHandler(this.AmenityComboBox_SelectedIndexChanged);
            this.AmenityComboBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.AmenityComboBox_MouseClick);
            // 
            // Amenity1Label
            // 
            this.Amenity1Label.AutoSize = true;
            this.Amenity1Label.Location = new System.Drawing.Point(64, 202);
            this.Amenity1Label.Name = "Amenity1Label";
            this.Amenity1Label.Size = new System.Drawing.Size(68, 22);
            this.Amenity1Label.TabIndex = 21;
            this.Amenity1Label.Text = "Amenity:";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DisplayMember = "Name";
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(758, 151);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(253, 30);
            this.TypeComboBox.TabIndex = 20;
            this.TypeComboBox.ValueMember = "ID";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(623, 151);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(109, 22);
            this.TypeLabel.TabIndex = 19;
            this.TypeLabel.Text = "Property Type:";
            // 
            // MaxPrice
            // 
            this.MaxPrice.DecimalPlaces = 2;
            this.MaxPrice.Location = new System.Drawing.Point(497, 145);
            this.MaxPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.MaxPrice.Name = "MaxPrice";
            this.MaxPrice.Size = new System.Drawing.Size(120, 28);
            this.MaxPrice.TabIndex = 18;
            // 
            // MaxPriceLabel
            // 
            this.MaxPriceLabel.AutoSize = true;
            this.MaxPriceLabel.Location = new System.Drawing.Point(357, 145);
            this.MaxPriceLabel.Name = "MaxPriceLabel";
            this.MaxPriceLabel.Size = new System.Drawing.Size(117, 22);
            this.MaxPriceLabel.TabIndex = 17;
            this.MaxPriceLabel.Text = "Maximum price:";
            // 
            // StartPriceLabel
            // 
            this.StartPriceLabel.AutoSize = true;
            this.StartPriceLabel.Location = new System.Drawing.Point(87, 143);
            this.StartPriceLabel.Name = "StartPriceLabel";
            this.StartPriceLabel.Size = new System.Drawing.Size(103, 22);
            this.StartPriceLabel.TabIndex = 15;
            this.StartPriceLabel.Text = "Starting price:";
            // 
            // PeopleLabel
            // 
            this.PeopleLabel.AutoSize = true;
            this.PeopleLabel.Location = new System.Drawing.Point(1097, 102);
            this.PeopleLabel.Name = "PeopleLabel";
            this.PeopleLabel.Size = new System.Drawing.Size(56, 22);
            this.PeopleLabel.TabIndex = 14;
            this.PeopleLabel.Text = "people";
            // 
            // PeopleNum
            // 
            this.PeopleNum.Location = new System.Drawing.Point(960, 96);
            this.PeopleNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.PeopleNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PeopleNum.Name = "PeopleNum";
            this.PeopleNum.Size = new System.Drawing.Size(120, 28);
            this.PeopleNum.TabIndex = 13;
            this.PeopleNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // StartPrice
            // 
            this.StartPrice.DecimalPlaces = 2;
            this.StartPrice.Location = new System.Drawing.Point(215, 143);
            this.StartPrice.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.StartPrice.Name = "StartPrice";
            this.StartPrice.Size = new System.Drawing.Size(120, 28);
            this.StartPrice.TabIndex = 16;
            // 
            // NightLabel
            // 
            this.NightLabel.AutoSize = true;
            this.NightLabel.Location = new System.Drawing.Point(861, 101);
            this.NightLabel.Name = "NightLabel";
            this.NightLabel.Size = new System.Drawing.Size(74, 22);
            this.NightLabel.TabIndex = 12;
            this.NightLabel.Text = "night and";
            // 
            // NightNum
            // 
            this.NightNum.Location = new System.Drawing.Point(724, 95);
            this.NightNum.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.NightNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NightNum.Name = "NightNum";
            this.NightNum.Size = new System.Drawing.Size(120, 28);
            this.NightNum.TabIndex = 11;
            this.NightNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ForLabel
            // 
            this.ForLabel.AutoSize = true;
            this.ForLabel.Location = new System.Drawing.Point(676, 96);
            this.ForLabel.Name = "ForLabel";
            this.ForLabel.Size = new System.Drawing.Size(30, 22);
            this.ForLabel.TabIndex = 10;
            this.ForLabel.Text = "for";
            // 
            // ToDate
            // 
            this.ToDate.CustomFormat = "dd/MM/yyyy";
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDate.Location = new System.Drawing.Point(432, 90);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(200, 28);
            this.ToDate.TabIndex = 9;
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(357, 90);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(31, 22);
            this.ToLabel.TabIndex = 8;
            this.ToLabel.Text = "To:";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(60, 85);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(50, 22);
            this.FromLabel.TabIndex = 6;
            this.FromLabel.Text = "From:";
            // 
            // TitleComboBox
            // 
            this.TitleComboBox.FormattingEnabled = true;
            this.TitleComboBox.Location = new System.Drawing.Point(909, 42);
            this.TitleComboBox.Name = "TitleComboBox";
            this.TitleComboBox.Size = new System.Drawing.Size(253, 30);
            this.TitleComboBox.TabIndex = 5;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(780, 45);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(104, 22);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Property Title:";
            // 
            // AttractionComboBox
            // 
            this.AttractionComboBox.DisplayMember = "Name";
            this.AttractionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AttractionComboBox.FormattingEnabled = true;
            this.AttractionComboBox.Location = new System.Drawing.Point(519, 39);
            this.AttractionComboBox.Name = "AttractionComboBox";
            this.AttractionComboBox.Size = new System.Drawing.Size(253, 30);
            this.AttractionComboBox.TabIndex = 3;
            this.AttractionComboBox.ValueMember = "ID";
            this.AttractionComboBox.SelectedIndexChanged += new System.EventHandler(this.AttractionComboBox_SelectedIndexChanged);
            // 
            // AttractionLabel
            // 
            this.AttractionLabel.AutoSize = true;
            this.AttractionLabel.Location = new System.Drawing.Point(422, 42);
            this.AttractionLabel.Name = "AttractionLabel";
            this.AttractionLabel.Size = new System.Drawing.Size(80, 22);
            this.AttractionLabel.TabIndex = 2;
            this.AttractionLabel.Text = "Attraction:";
            // 
            // AreaComboBox
            // 
            this.AreaComboBox.DisplayMember = "Name";
            this.AreaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaComboBox.FormattingEnabled = true;
            this.AreaComboBox.Location = new System.Drawing.Point(145, 38);
            this.AreaComboBox.Name = "AreaComboBox";
            this.AreaComboBox.Size = new System.Drawing.Size(253, 30);
            this.AreaComboBox.TabIndex = 1;
            this.AreaComboBox.ValueMember = "ID";
            this.AreaComboBox.SelectedIndexChanged += new System.EventHandler(this.AreaComboBox_SelectedIndexChanged);
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Location = new System.Drawing.Point(68, 40);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(45, 22);
            this.AreaLabel.TabIndex = 0;
            this.AreaLabel.Text = "Area:";
            // 
            // FromDate
            // 
            this.FromDate.CustomFormat = "dd/MM/yyyy";
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDate.Location = new System.Drawing.Point(135, 85);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(200, 28);
            this.FromDate.TabIndex = 7;
            this.FromDate.ValueChanged += new System.EventHandler(this.FromDate_ValueChanged);
            // 
            // AdvancedSearchGroupBox
            // 
            this.AdvancedSearchGroupBox.Controls.Add(this.SearchBtn);
            this.AdvancedSearchGroupBox.Controls.Add(this.ClearBtn);
            this.AdvancedSearchGroupBox.Controls.Add(this.SimpleSearchBtn);
            this.AdvancedSearchGroupBox.Controls.Add(this.AmenityComboBox3);
            this.AdvancedSearchGroupBox.Controls.Add(this.Amenity3Label);
            this.AdvancedSearchGroupBox.Controls.Add(this.AmenityComboBox2);
            this.AdvancedSearchGroupBox.Controls.Add(this.Amenity2Label);
            this.AdvancedSearchGroupBox.Controls.Add(this.AmenityComboBox1);
            this.AdvancedSearchGroupBox.Controls.Add(this.Amenity1Label);
            this.AdvancedSearchGroupBox.Controls.Add(this.TypeComboBox);
            this.AdvancedSearchGroupBox.Controls.Add(this.TypeLabel);
            this.AdvancedSearchGroupBox.Controls.Add(this.MaxPrice);
            this.AdvancedSearchGroupBox.Controls.Add(this.MaxPriceLabel);
            this.AdvancedSearchGroupBox.Controls.Add(this.StartPrice);
            this.AdvancedSearchGroupBox.Controls.Add(this.StartPriceLabel);
            this.AdvancedSearchGroupBox.Controls.Add(this.PeopleLabel);
            this.AdvancedSearchGroupBox.Controls.Add(this.PeopleNum);
            this.AdvancedSearchGroupBox.Controls.Add(this.NightLabel);
            this.AdvancedSearchGroupBox.Controls.Add(this.NightNum);
            this.AdvancedSearchGroupBox.Controls.Add(this.ForLabel);
            this.AdvancedSearchGroupBox.Controls.Add(this.ToDate);
            this.AdvancedSearchGroupBox.Controls.Add(this.ToLabel);
            this.AdvancedSearchGroupBox.Controls.Add(this.FromDate);
            this.AdvancedSearchGroupBox.Controls.Add(this.FromLabel);
            this.AdvancedSearchGroupBox.Controls.Add(this.TitleComboBox);
            this.AdvancedSearchGroupBox.Controls.Add(this.TitleLabel);
            this.AdvancedSearchGroupBox.Controls.Add(this.AttractionComboBox);
            this.AdvancedSearchGroupBox.Controls.Add(this.AttractionLabel);
            this.AdvancedSearchGroupBox.Controls.Add(this.AreaComboBox);
            this.AdvancedSearchGroupBox.Controls.Add(this.AreaLabel);
            this.AdvancedSearchGroupBox.Location = new System.Drawing.Point(20, 15);
            this.AdvancedSearchGroupBox.Name = "AdvancedSearchGroupBox";
            this.AdvancedSearchGroupBox.Size = new System.Drawing.Size(1208, 285);
            this.AdvancedSearchGroupBox.TabIndex = 2;
            this.AdvancedSearchGroupBox.TabStop = false;
            this.AdvancedSearchGroupBox.Text = "Advanced Search";
            // 
            // ResultsPanel
            // 
            this.ResultsPanel.Controls.Add(this.CountLabel);
            this.ResultsPanel.Controls.Add(this.SearchResultsGroupBox);
            this.ResultsPanel.Location = new System.Drawing.Point(20, 307);
            this.ResultsPanel.Name = "ResultsPanel";
            this.ResultsPanel.Size = new System.Drawing.Size(1208, 390);
            this.ResultsPanel.TabIndex = 3;
            // 
            // CountLabel
            // 
            this.CountLabel.AutoSize = true;
            this.CountLabel.Font = new System.Drawing.Font("Open Sans Light", 12F);
            this.CountLabel.Location = new System.Drawing.Point(10, 352);
            this.CountLabel.Name = "CountLabel";
            this.CountLabel.Size = new System.Drawing.Size(54, 28);
            this.CountLabel.TabIndex = 39;
            this.CountLabel.Text = "here";
            // 
            // SearchResultsGroupBox
            // 
            this.SearchResultsGroupBox.Controls.Add(this.ResultsDataGridView);
            this.SearchResultsGroupBox.Location = new System.Drawing.Point(9, 10);
            this.SearchResultsGroupBox.Name = "SearchResultsGroupBox";
            this.SearchResultsGroupBox.Size = new System.Drawing.Size(1196, 339);
            this.SearchResultsGroupBox.TabIndex = 38;
            this.SearchResultsGroupBox.TabStop = false;
            this.SearchResultsGroupBox.Text = "Search results";
            // 
            // ResultsDataGridView
            // 
            this.ResultsDataGridView.AllowUserToAddRows = false;
            this.ResultsDataGridView.AllowUserToDeleteRows = false;
            this.ResultsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResultsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans Light", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ResultsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PropertyColumn,
            this.AreaColumn,
            this.AverageScoreColumn,
            this.TotalCompletedReservationsColumn,
            this.AmountPayableColumn,
            this.CheckInColumn});
            this.ResultsDataGridView.EnableHeadersVisualStyles = false;
            this.ResultsDataGridView.GridColor = System.Drawing.Color.Black;
            this.ResultsDataGridView.Location = new System.Drawing.Point(6, 24);
            this.ResultsDataGridView.Name = "ResultsDataGridView";
            this.ResultsDataGridView.ReadOnly = true;
            this.ResultsDataGridView.RowHeadersVisible = false;
            this.ResultsDataGridView.RowHeadersWidth = 51;
            this.ResultsDataGridView.Size = new System.Drawing.Size(1184, 309);
            this.ResultsDataGridView.TabIndex = 0;
            // 
            // PropertyColumn
            // 
            this.PropertyColumn.HeaderText = "Property";
            this.PropertyColumn.MinimumWidth = 6;
            this.PropertyColumn.Name = "PropertyColumn";
            this.PropertyColumn.ReadOnly = true;
            // 
            // AreaColumn
            // 
            this.AreaColumn.HeaderText = "Area";
            this.AreaColumn.MinimumWidth = 6;
            this.AreaColumn.Name = "AreaColumn";
            this.AreaColumn.ReadOnly = true;
            // 
            // AverageScoreColumn
            // 
            this.AverageScoreColumn.HeaderText = "Average Score";
            this.AverageScoreColumn.MinimumWidth = 6;
            this.AverageScoreColumn.Name = "AverageScoreColumn";
            this.AverageScoreColumn.ReadOnly = true;
            // 
            // TotalCompletedReservationsColumn
            // 
            this.TotalCompletedReservationsColumn.HeaderText = "Total completed reservations";
            this.TotalCompletedReservationsColumn.MinimumWidth = 6;
            this.TotalCompletedReservationsColumn.Name = "TotalCompletedReservationsColumn";
            this.TotalCompletedReservationsColumn.ReadOnly = true;
            // 
            // AmountPayableColumn
            // 
            this.AmountPayableColumn.HeaderText = "Amount payable";
            this.AmountPayableColumn.MinimumWidth = 6;
            this.AmountPayableColumn.Name = "AmountPayableColumn";
            this.AmountPayableColumn.ReadOnly = true;
            // 
            // CheckInColumn
            // 
            this.CheckInColumn.HeaderText = "Check-in at";
            this.CheckInColumn.MinimumWidth = 6;
            this.CheckInColumn.Name = "CheckInColumn";
            this.CheckInColumn.ReadOnly = true;
            // 
            // AdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.Controls.Add(this.ResultsPanel);
            this.Controls.Add(this.AdvancedSearchGroupBox);
            this.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdvancedSearch";
            this.Size = new System.Drawing.Size(1250, 700);
            ((System.ComponentModel.ISupportInitialize)(this.MaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NightNum)).EndInit();
            this.AdvancedSearchGroupBox.ResumeLayout(false);
            this.AdvancedSearchGroupBox.PerformLayout();
            this.ResultsPanel.ResumeLayout(false);
            this.ResultsPanel.PerformLayout();
            this.SearchResultsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ResultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button SimpleSearchBtn;
        private System.Windows.Forms.ComboBox AmenityComboBox3;
        private System.Windows.Forms.Label Amenity3Label;
        private System.Windows.Forms.ComboBox AmenityComboBox2;
        private System.Windows.Forms.Label Amenity2Label;
        private System.Windows.Forms.ComboBox AmenityComboBox1;
        private System.Windows.Forms.Label Amenity1Label;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.NumericUpDown MaxPrice;
        private System.Windows.Forms.Label MaxPriceLabel;
        private System.Windows.Forms.Label StartPriceLabel;
        private System.Windows.Forms.Label PeopleLabel;
        private System.Windows.Forms.NumericUpDown PeopleNum;
        private System.Windows.Forms.NumericUpDown StartPrice;
        private System.Windows.Forms.Label NightLabel;
        private System.Windows.Forms.NumericUpDown NightNum;
        private System.Windows.Forms.Label ForLabel;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.ComboBox TitleComboBox;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ComboBox AttractionComboBox;
        private System.Windows.Forms.Label AttractionLabel;
        private System.Windows.Forms.ComboBox AreaComboBox;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.GroupBox AdvancedSearchGroupBox;
        private System.Windows.Forms.Panel ResultsPanel;
        private System.Windows.Forms.Label CountLabel;
        private System.Windows.Forms.GroupBox SearchResultsGroupBox;
        private System.Windows.Forms.DataGridView ResultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PropertyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AreaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageScoreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalCompletedReservationsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPayableColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckInColumn;
    }
}

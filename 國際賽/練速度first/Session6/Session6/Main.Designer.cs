namespace Session6
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.FilterPanel = new System.Windows.Forms.Panel();
            this.FilterGroupBox = new System.Windows.Forms.GroupBox();
            this.GuestComboBox = new System.Windows.Forms.ComboBox();
            this.HostComboBox = new System.Windows.Forms.ComboBox();
            this.AreaComboBox = new System.Windows.Forms.ComboBox();
            this.ToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.GuestLabel = new System.Windows.Forms.Label();
            this.HostLabel = new System.Windows.Forms.Label();
            this.AreaLabel = new System.Windows.Forms.Label();
            this.ToLabel = new System.Windows.Forms.Label();
            this.FromLabel = new System.Windows.Forms.Label();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.TabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RatioGroupBox = new System.Windows.Forms.GroupBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FinancialSummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.FinancialSummaryPanel = new System.Windows.Forms.Panel();
            this.ScoresSummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.ScoresSummaryPanel = new System.Windows.Forms.Panel();
            this.ListingGroupBox = new System.Windows.Forms.GroupBox();
            this.ListingsSummaryPanel = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ServiceDataGridView = new System.Windows.Forms.DataGridView();
            this.AddonServicesGroupBox = new System.Windows.Forms.GroupBox();
            this.AddonServicesPanel = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TransactionTitleLabel = new System.Windows.Forms.Label();
            this.TransactionDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HostDataGridView = new System.Windows.Forms.DataGridView();
            this.FilterPanel.SuspendLayout();
            this.FilterGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.TabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.RatioGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.FinancialSummaryGroupBox.SuspendLayout();
            this.ScoresSummaryGroupBox.SuspendLayout();
            this.ListingGroupBox.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDataGridView)).BeginInit();
            this.AddonServicesGroupBox.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HostDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterPanel
            // 
            this.FilterPanel.Controls.Add(this.FilterGroupBox);
            this.FilterPanel.Controls.Add(this.IconPictureBox);
            this.FilterPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FilterPanel.Location = new System.Drawing.Point(0, 0);
            this.FilterPanel.Name = "FilterPanel";
            this.FilterPanel.Size = new System.Drawing.Size(318, 732);
            this.FilterPanel.TabIndex = 2;
            // 
            // FilterGroupBox
            // 
            this.FilterGroupBox.Controls.Add(this.GuestComboBox);
            this.FilterGroupBox.Controls.Add(this.HostComboBox);
            this.FilterGroupBox.Controls.Add(this.AreaComboBox);
            this.FilterGroupBox.Controls.Add(this.ToDateTimePicker);
            this.FilterGroupBox.Controls.Add(this.FromDateTimePicker);
            this.FilterGroupBox.Controls.Add(this.ResetBtn);
            this.FilterGroupBox.Controls.Add(this.ApplyBtn);
            this.FilterGroupBox.Controls.Add(this.GuestLabel);
            this.FilterGroupBox.Controls.Add(this.HostLabel);
            this.FilterGroupBox.Controls.Add(this.AreaLabel);
            this.FilterGroupBox.Controls.Add(this.ToLabel);
            this.FilterGroupBox.Controls.Add(this.FromLabel);
            this.FilterGroupBox.Location = new System.Drawing.Point(12, 179);
            this.FilterGroupBox.Name = "FilterGroupBox";
            this.FilterGroupBox.Size = new System.Drawing.Size(284, 532);
            this.FilterGroupBox.TabIndex = 1;
            this.FilterGroupBox.TabStop = false;
            this.FilterGroupBox.Text = "Filters";
            // 
            // GuestComboBox
            // 
            this.GuestComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GuestComboBox.FormattingEnabled = true;
            this.GuestComboBox.Location = new System.Drawing.Point(32, 350);
            this.GuestComboBox.Name = "GuestComboBox";
            this.GuestComboBox.Size = new System.Drawing.Size(224, 28);
            this.GuestComboBox.TabIndex = 1;
            // 
            // HostComboBox
            // 
            this.HostComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HostComboBox.FormattingEnabled = true;
            this.HostComboBox.Location = new System.Drawing.Point(31, 283);
            this.HostComboBox.Name = "HostComboBox";
            this.HostComboBox.Size = new System.Drawing.Size(224, 28);
            this.HostComboBox.TabIndex = 1;
            // 
            // AreaComboBox
            // 
            this.AreaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaComboBox.FormattingEnabled = true;
            this.AreaComboBox.Location = new System.Drawing.Point(31, 220);
            this.AreaComboBox.Name = "AreaComboBox";
            this.AreaComboBox.Size = new System.Drawing.Size(224, 28);
            this.AreaComboBox.TabIndex = 1;
            // 
            // ToDateTimePicker
            // 
            this.ToDateTimePicker.CustomFormat = " ";
            this.ToDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDateTimePicker.Location = new System.Drawing.Point(31, 145);
            this.ToDateTimePicker.Name = "ToDateTimePicker";
            this.ToDateTimePicker.Size = new System.Drawing.Size(224, 27);
            this.ToDateTimePicker.TabIndex = 1;
            this.ToDateTimePicker.ValueChanged += new System.EventHandler(this.FromDateTimePicker_ValueChanged);
            // 
            // FromDateTimePicker
            // 
            this.FromDateTimePicker.CustomFormat = " ";
            this.FromDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDateTimePicker.Location = new System.Drawing.Point(31, 84);
            this.FromDateTimePicker.Name = "FromDateTimePicker";
            this.FromDateTimePicker.Size = new System.Drawing.Size(224, 27);
            this.FromDateTimePicker.TabIndex = 1;
            this.FromDateTimePicker.ValueChanged += new System.EventHandler(this.FromDateTimePicker_ValueChanged);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetBtn.Location = new System.Drawing.Point(31, 462);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(224, 43);
            this.ResetBtn.TabIndex = 1;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyBtn.Location = new System.Drawing.Point(31, 413);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(224, 43);
            this.ApplyBtn.TabIndex = 1;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // GuestLabel
            // 
            this.GuestLabel.AutoSize = true;
            this.GuestLabel.Location = new System.Drawing.Point(27, 323);
            this.GuestLabel.Name = "GuestLabel";
            this.GuestLabel.Size = new System.Drawing.Size(59, 20);
            this.GuestLabel.TabIndex = 1;
            this.GuestLabel.Text = "Guest:";
            // 
            // HostLabel
            // 
            this.HostLabel.AutoSize = true;
            this.HostLabel.Location = new System.Drawing.Point(27, 256);
            this.HostLabel.Name = "HostLabel";
            this.HostLabel.Size = new System.Drawing.Size(50, 20);
            this.HostLabel.TabIndex = 1;
            this.HostLabel.Text = "Host:";
            // 
            // AreaLabel
            // 
            this.AreaLabel.AutoSize = true;
            this.AreaLabel.Location = new System.Drawing.Point(28, 193);
            this.AreaLabel.Name = "AreaLabel";
            this.AreaLabel.Size = new System.Drawing.Size(49, 20);
            this.AreaLabel.TabIndex = 1;
            this.AreaLabel.Text = "Area:";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(27, 118);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(33, 20);
            this.ToLabel.TabIndex = 1;
            this.ToLabel.Text = "To:";
            // 
            // FromLabel
            // 
            this.FromLabel.AutoSize = true;
            this.FromLabel.Location = new System.Drawing.Point(27, 57);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(53, 20);
            this.FromLabel.TabIndex = 1;
            this.FromLabel.Text = "From:";
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("IconPictureBox.Image")));
            this.IconPictureBox.Location = new System.Drawing.Point(12, 30);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(284, 112);
            this.IconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IconPictureBox.TabIndex = 1;
            this.IconPictureBox.TabStop = false;
            // 
            // TabControlMain
            // 
            this.TabControlMain.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.TabControlMain.Controls.Add(this.tabPage1);
            this.TabControlMain.Controls.Add(this.tabPage2);
            this.TabControlMain.Controls.Add(this.tabPage3);
            this.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlMain.Location = new System.Drawing.Point(318, 0);
            this.TabControlMain.Multiline = true;
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(969, 732);
            this.TabControlMain.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RatioGroupBox);
            this.tabPage1.Controls.Add(this.FinancialSummaryGroupBox);
            this.tabPage1.Controls.Add(this.ScoresSummaryGroupBox);
            this.tabPage1.Controls.Add(this.ListingGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(29, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(936, 724);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Universal Report";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RatioGroupBox
            // 
            this.RatioGroupBox.Controls.Add(this.chart);
            this.RatioGroupBox.Location = new System.Drawing.Point(467, 8);
            this.RatioGroupBox.Name = "RatioGroupBox";
            this.RatioGroupBox.Size = new System.Drawing.Size(428, 343);
            this.RatioGroupBox.TabIndex = 4;
            this.RatioGroupBox.TabStop = false;
            this.RatioGroupBox.Text = "Monthly Vacancy Ratio";
            // 
            // chart
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(6, 26);
            this.chart.Name = "chart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn100;
            series3.Legend = "Legend1";
            series3.Name = "Vacant";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn100;
            series4.Legend = "Legend1";
            series4.Name = "Reserved";
            this.chart.Series.Add(series3);
            this.chart.Series.Add(series4);
            this.chart.Size = new System.Drawing.Size(409, 300);
            this.chart.TabIndex = 4;
            this.chart.Text = "chart1";
            // 
            // FinancialSummaryGroupBox
            // 
            this.FinancialSummaryGroupBox.Controls.Add(this.FinancialSummaryPanel);
            this.FinancialSummaryGroupBox.Location = new System.Drawing.Point(481, 368);
            this.FinancialSummaryGroupBox.Name = "FinancialSummaryGroupBox";
            this.FinancialSummaryGroupBox.Size = new System.Drawing.Size(406, 316);
            this.FinancialSummaryGroupBox.TabIndex = 1;
            this.FinancialSummaryGroupBox.TabStop = false;
            this.FinancialSummaryGroupBox.Text = "Financial Summary";
            // 
            // FinancialSummaryPanel
            // 
            this.FinancialSummaryPanel.AutoScroll = true;
            this.FinancialSummaryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinancialSummaryPanel.Location = new System.Drawing.Point(3, 23);
            this.FinancialSummaryPanel.Name = "FinancialSummaryPanel";
            this.FinancialSummaryPanel.Size = new System.Drawing.Size(400, 290);
            this.FinancialSummaryPanel.TabIndex = 0;
            // 
            // ScoresSummaryGroupBox
            // 
            this.ScoresSummaryGroupBox.Controls.Add(this.ScoresSummaryPanel);
            this.ScoresSummaryGroupBox.Location = new System.Drawing.Point(22, 368);
            this.ScoresSummaryGroupBox.Name = "ScoresSummaryGroupBox";
            this.ScoresSummaryGroupBox.Size = new System.Drawing.Size(406, 316);
            this.ScoresSummaryGroupBox.TabIndex = 1;
            this.ScoresSummaryGroupBox.TabStop = false;
            this.ScoresSummaryGroupBox.Text = "Scores Summary";
            // 
            // ScoresSummaryPanel
            // 
            this.ScoresSummaryPanel.AutoScroll = true;
            this.ScoresSummaryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScoresSummaryPanel.Location = new System.Drawing.Point(3, 23);
            this.ScoresSummaryPanel.Name = "ScoresSummaryPanel";
            this.ScoresSummaryPanel.Size = new System.Drawing.Size(400, 290);
            this.ScoresSummaryPanel.TabIndex = 0;
            // 
            // ListingGroupBox
            // 
            this.ListingGroupBox.Controls.Add(this.ListingsSummaryPanel);
            this.ListingGroupBox.Location = new System.Drawing.Point(19, 26);
            this.ListingGroupBox.Name = "ListingGroupBox";
            this.ListingGroupBox.Size = new System.Drawing.Size(406, 316);
            this.ListingGroupBox.TabIndex = 0;
            this.ListingGroupBox.TabStop = false;
            this.ListingGroupBox.Text = "Property or Listings Summary";
            // 
            // ListingsSummaryPanel
            // 
            this.ListingsSummaryPanel.AutoScroll = true;
            this.ListingsSummaryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListingsSummaryPanel.Location = new System.Drawing.Point(3, 23);
            this.ListingsSummaryPanel.Name = "ListingsSummaryPanel";
            this.ListingsSummaryPanel.Size = new System.Drawing.Size(400, 290);
            this.ListingsSummaryPanel.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ServiceDataGridView);
            this.tabPage2.Controls.Add(this.AddonServicesGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(29, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(936, 724);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Service Report";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ServiceDataGridView
            // 
            this.ServiceDataGridView.AllowUserToAddRows = false;
            this.ServiceDataGridView.AllowUserToDeleteRows = false;
            this.ServiceDataGridView.AllowUserToResizeColumns = false;
            this.ServiceDataGridView.AllowUserToResizeRows = false;
            this.ServiceDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.ServiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ServiceDataGridView.Location = new System.Drawing.Point(42, 293);
            this.ServiceDataGridView.MultiSelect = false;
            this.ServiceDataGridView.Name = "ServiceDataGridView";
            this.ServiceDataGridView.ReadOnly = true;
            this.ServiceDataGridView.RowHeadersVisible = false;
            this.ServiceDataGridView.RowHeadersWidth = 51;
            this.ServiceDataGridView.RowTemplate.Height = 27;
            this.ServiceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceDataGridView.Size = new System.Drawing.Size(835, 364);
            this.ServiceDataGridView.TabIndex = 2;
            this.ServiceDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.ServiceDataGridView_CellFormatting);
            // 
            // AddonServicesGroupBox
            // 
            this.AddonServicesGroupBox.Controls.Add(this.AddonServicesPanel);
            this.AddonServicesGroupBox.Location = new System.Drawing.Point(39, 26);
            this.AddonServicesGroupBox.Name = "AddonServicesGroupBox";
            this.AddonServicesGroupBox.Size = new System.Drawing.Size(838, 229);
            this.AddonServicesGroupBox.TabIndex = 1;
            this.AddonServicesGroupBox.TabStop = false;
            this.AddonServicesGroupBox.Text = "Addon Services";
            // 
            // AddonServicesPanel
            // 
            this.AddonServicesPanel.AutoScroll = true;
            this.AddonServicesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddonServicesPanel.Location = new System.Drawing.Point(3, 23);
            this.AddonServicesPanel.Name = "AddonServicesPanel";
            this.AddonServicesPanel.Size = new System.Drawing.Size(832, 203);
            this.AddonServicesPanel.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TransactionTitleLabel);
            this.tabPage3.Controls.Add(this.TransactionDataGridView);
            this.tabPage3.Controls.Add(this.HostDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(29, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(936, 724);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Host Analysis";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TransactionTitleLabel
            // 
            this.TransactionTitleLabel.AutoSize = true;
            this.TransactionTitleLabel.Location = new System.Drawing.Point(49, 357);
            this.TransactionTitleLabel.Name = "TransactionTitleLabel";
            this.TransactionTitleLabel.Size = new System.Drawing.Size(0, 20);
            this.TransactionTitleLabel.TabIndex = 4;
            // 
            // TransactionDataGridView
            // 
            this.TransactionDataGridView.AllowUserToAddRows = false;
            this.TransactionDataGridView.AllowUserToDeleteRows = false;
            this.TransactionDataGridView.AllowUserToResizeColumns = false;
            this.TransactionDataGridView.AllowUserToResizeRows = false;
            this.TransactionDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.TransactionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.TransactionDataGridView.Location = new System.Drawing.Point(41, 395);
            this.TransactionDataGridView.MultiSelect = false;
            this.TransactionDataGridView.Name = "TransactionDataGridView";
            this.TransactionDataGridView.ReadOnly = true;
            this.TransactionDataGridView.RowHeadersVisible = false;
            this.TransactionDataGridView.RowHeadersWidth = 51;
            this.TransactionDataGridView.RowTemplate.Height = 27;
            this.TransactionDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TransactionDataGridView.Size = new System.Drawing.Size(835, 267);
            this.TransactionDataGridView.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Date";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 74;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Amount";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 95;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Commission";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 131;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Description";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 124;
            // 
            // HostDataGridView
            // 
            this.HostDataGridView.AllowUserToAddRows = false;
            this.HostDataGridView.AllowUserToDeleteRows = false;
            this.HostDataGridView.AllowUserToResizeColumns = false;
            this.HostDataGridView.AllowUserToResizeRows = false;
            this.HostDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.HostDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HostDataGridView.Location = new System.Drawing.Point(41, 26);
            this.HostDataGridView.MultiSelect = false;
            this.HostDataGridView.Name = "HostDataGridView";
            this.HostDataGridView.ReadOnly = true;
            this.HostDataGridView.RowHeadersVisible = false;
            this.HostDataGridView.RowHeadersWidth = 51;
            this.HostDataGridView.RowTemplate.Height = 27;
            this.HostDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HostDataGridView.Size = new System.Drawing.Size(835, 245);
            this.HostDataGridView.TabIndex = 3;
            this.HostDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HostDataGridView_CellClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 732);
            this.Controls.Add(this.TabControlMain);
            this.Controls.Add(this.FilterPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.Text = "Seoul Stay - Reporting Dashboard";
            this.FilterPanel.ResumeLayout(false);
            this.FilterGroupBox.ResumeLayout(false);
            this.FilterGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.TabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.RatioGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.FinancialSummaryGroupBox.ResumeLayout(false);
            this.ScoresSummaryGroupBox.ResumeLayout(false);
            this.ListingGroupBox.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceDataGridView)).EndInit();
            this.AddonServicesGroupBox.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HostDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel FilterPanel;
        private System.Windows.Forms.GroupBox FilterGroupBox;
        private System.Windows.Forms.ComboBox GuestComboBox;
        private System.Windows.Forms.ComboBox HostComboBox;
        private System.Windows.Forms.ComboBox AreaComboBox;
        private System.Windows.Forms.DateTimePicker ToDateTimePicker;
        private System.Windows.Forms.DateTimePicker FromDateTimePicker;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button ApplyBtn;
        private System.Windows.Forms.Label GuestLabel;
        private System.Windows.Forms.Label HostLabel;
        private System.Windows.Forms.Label AreaLabel;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.TabControl TabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox RatioGroupBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.GroupBox FinancialSummaryGroupBox;
        private System.Windows.Forms.Panel FinancialSummaryPanel;
        private System.Windows.Forms.GroupBox ScoresSummaryGroupBox;
        private System.Windows.Forms.Panel ScoresSummaryPanel;
        private System.Windows.Forms.GroupBox ListingGroupBox;
        private System.Windows.Forms.Panel ListingsSummaryPanel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ServiceDataGridView;
        private System.Windows.Forms.GroupBox AddonServicesGroupBox;
        private System.Windows.Forms.Panel AddonServicesPanel;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label TransactionTitleLabel;
        private System.Windows.Forms.DataGridView TransactionDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridView HostDataGridView;
    }
}


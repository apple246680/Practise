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
            this.ResultDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SimpleSearchBtn = new System.Windows.Forms.Button();
            this.AmenityComboBox3 = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.AmenityComboBox2 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.AmenityComboBox1 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.MaxPrice = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PeopleNum = new System.Windows.Forms.NumericUpDown();
            this.StartPrice = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.NightNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TitleComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AttractionComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AreaComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NightNum)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultDataGridView
            // 
            this.ResultDataGridView.AllowUserToAddRows = false;
            this.ResultDataGridView.AllowUserToDeleteRows = false;
            this.ResultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.ResultDataGridView.EnableHeadersVisualStyles = false;
            this.ResultDataGridView.Location = new System.Drawing.Point(246, 432);
            this.ResultDataGridView.Name = "ResultDataGridView";
            this.ResultDataGridView.ReadOnly = true;
            this.ResultDataGridView.RowHeadersVisible = false;
            this.ResultDataGridView.RowHeadersWidth = 51;
            this.ResultDataGridView.RowTemplate.Height = 27;
            this.ResultDataGridView.Size = new System.Drawing.Size(900, 321);
            this.ResultDataGridView.TabIndex = 3;
            this.ResultDataGridView.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Property";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Area";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Average Score";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total completed reservations";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Amount payable";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Check-in at";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(791, 241);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(220, 38);
            this.SearchBtn.TabIndex = 29;
            this.SearchBtn.Text = "Search properties...";
            this.SearchBtn.UseVisualStyleBackColor = true;
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(623, 241);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(162, 38);
            this.ClearBtn.TabIndex = 28;
            this.ClearBtn.Text = "Clear form";
            this.ClearBtn.UseVisualStyleBackColor = true;
            // 
            // SimpleSearchBtn
            // 
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
            this.AmenityComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AmenityComboBox3.FormattingEnabled = true;
            this.AmenityComboBox3.Location = new System.Drawing.Point(895, 202);
            this.AmenityComboBox3.Name = "AmenityComboBox3";
            this.AmenityComboBox3.Size = new System.Drawing.Size(253, 25);
            this.AmenityComboBox3.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(800, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "Amenity:";
            // 
            // AmenityComboBox2
            // 
            this.AmenityComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AmenityComboBox2.FormattingEnabled = true;
            this.AmenityComboBox2.Location = new System.Drawing.Point(532, 199);
            this.AmenityComboBox2.Name = "AmenityComboBox2";
            this.AmenityComboBox2.Size = new System.Drawing.Size(253, 25);
            this.AmenityComboBox2.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(437, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Amenity:";
            // 
            // AmenityComboBox1
            // 
            this.AmenityComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AmenityComboBox1.FormattingEnabled = true;
            this.AmenityComboBox1.Location = new System.Drawing.Point(159, 199);
            this.AmenityComboBox1.Name = "AmenityComboBox1";
            this.AmenityComboBox1.Size = new System.Drawing.Size(253, 25);
            this.AmenityComboBox1.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(64, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Amenity:";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(758, 151);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(253, 25);
            this.TypeComboBox.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(623, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "Property Type:";
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
            this.MaxPrice.Size = new System.Drawing.Size(120, 24);
            this.MaxPrice.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(357, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Maximum price:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Starting price:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1097, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "people";
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
            this.PeopleNum.Size = new System.Drawing.Size(120, 24);
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
            this.StartPrice.Size = new System.Drawing.Size(120, 24);
            this.StartPrice.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(861, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "night and";
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
            this.NightNum.Size = new System.Drawing.Size(120, 24);
            this.NightNum.TabIndex = 11;
            this.NightNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(676, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "for";
            // 
            // ToDate
            // 
            this.ToDate.CustomFormat = "dd/MM/yyyy";
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDate.Location = new System.Drawing.Point(432, 90);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(200, 24);
            this.ToDate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "To:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "From:";
            // 
            // TitleComboBox
            // 
            this.TitleComboBox.FormattingEnabled = true;
            this.TitleComboBox.Location = new System.Drawing.Point(909, 42);
            this.TitleComboBox.Name = "TitleComboBox";
            this.TitleComboBox.Size = new System.Drawing.Size(253, 25);
            this.TitleComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(780, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Property Title:";
            // 
            // AttractionComboBox
            // 
            this.AttractionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AttractionComboBox.FormattingEnabled = true;
            this.AttractionComboBox.Location = new System.Drawing.Point(519, 39);
            this.AttractionComboBox.Name = "AttractionComboBox";
            this.AttractionComboBox.Size = new System.Drawing.Size(253, 25);
            this.AttractionComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Attraction:";
            // 
            // AreaComboBox
            // 
            this.AreaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AreaComboBox.FormattingEnabled = true;
            this.AreaComboBox.Location = new System.Drawing.Point(145, 38);
            this.AreaComboBox.Name = "AreaComboBox";
            this.AreaComboBox.Size = new System.Drawing.Size(253, 25);
            this.AreaComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Area:";
            // 
            // FromDate
            // 
            this.FromDate.CustomFormat = "dd/MM/yyyy";
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDate.Location = new System.Drawing.Point(135, 85);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(200, 24);
            this.FromDate.TabIndex = 7;
            this.FromDate.ValueChanged += new System.EventHandler(this.FromDate_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchBtn);
            this.groupBox1.Controls.Add(this.ClearBtn);
            this.groupBox1.Controls.Add(this.SimpleSearchBtn);
            this.groupBox1.Controls.Add(this.AmenityComboBox3);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.AmenityComboBox2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.AmenityComboBox1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.TypeComboBox);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.MaxPrice);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.StartPrice);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.PeopleNum);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.NightNum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ToDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.FromDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TitleComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AttractionComboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.AreaComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1208, 285);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Advanced Search";
            // 
            // AdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.Controls.Add(this.ResultDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdvancedSearch";
            this.Size = new System.Drawing.Size(1250, 800);
            ((System.ComponentModel.ISupportInitialize)(this.ResultDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeopleNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NightNum)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ResultDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button SimpleSearchBtn;
        private System.Windows.Forms.ComboBox AmenityComboBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox AmenityComboBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox AmenityComboBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown MaxPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown PeopleNum;
        private System.Windows.Forms.NumericUpDown StartPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NightNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TitleComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AttractionComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AreaComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

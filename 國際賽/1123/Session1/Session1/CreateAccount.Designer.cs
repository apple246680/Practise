namespace Session1
{
    partial class CreateAccount
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
            this.InformationGroupBox = new System.Windows.Forms.GroupBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.FamilyCountLabel = new System.Windows.Forms.Label();
            this.RetypePasswordLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextbox = new System.Windows.Forms.TextBox();
            this.BirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.RetypePasswordTextbox = new System.Windows.Forms.TextBox();
            this.FamilyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.FemleRadioButton = new System.Windows.Forms.RadioButton();
            this.AgreeTermsCheckBox = new System.Windows.Forms.CheckBox();
            this.CreateAccountLabel = new System.Windows.Forms.Label();
            this.ReturnLoginButton = new System.Windows.Forms.Button();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.InformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FamilyNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // InformationGroupBox
            // 
            this.InformationGroupBox.Controls.Add(this.CreateAccountLabel);
            this.InformationGroupBox.Controls.Add(this.AgreeTermsCheckBox);
            this.InformationGroupBox.Controls.Add(this.FemleRadioButton);
            this.InformationGroupBox.Controls.Add(this.MaleRadioButton);
            this.InformationGroupBox.Controls.Add(this.FamilyNumericUpDown);
            this.InformationGroupBox.Controls.Add(this.RetypePasswordTextbox);
            this.InformationGroupBox.Controls.Add(this.PasswordTextBox);
            this.InformationGroupBox.Controls.Add(this.BirthdayDateTimePicker);
            this.InformationGroupBox.Controls.Add(this.FullNameTextbox);
            this.InformationGroupBox.Controls.Add(this.UsernameTextBox);
            this.InformationGroupBox.Controls.Add(this.RetypePasswordLabel);
            this.InformationGroupBox.Controls.Add(this.FamilyCountLabel);
            this.InformationGroupBox.Controls.Add(this.PasswordLabel);
            this.InformationGroupBox.Controls.Add(this.BirthdayLabel);
            this.InformationGroupBox.Controls.Add(this.FullNameLabel);
            this.InformationGroupBox.Controls.Add(this.UsernameLabel);
            this.InformationGroupBox.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationGroupBox.Location = new System.Drawing.Point(49, 24);
            this.InformationGroupBox.Name = "InformationGroupBox";
            this.InformationGroupBox.Size = new System.Drawing.Size(1080, 421);
            this.InformationGroupBox.TabIndex = 0;
            this.InformationGroupBox.TabStop = false;
            this.InformationGroupBox.Text = "Your Information";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.Location = new System.Drawing.Point(49, 72);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(62, 15);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username:";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullNameLabel.Location = new System.Drawing.Point(49, 139);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(62, 15);
            this.FullNameLabel.TabIndex = 1;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthdayLabel.Location = new System.Drawing.Point(49, 206);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(54, 15);
            this.BirthdayLabel.TabIndex = 2;
            this.BirthdayLabel.Text = "Birthday:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(49, 273);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(60, 15);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "Password:";
            // 
            // FamilyCountLabel
            // 
            this.FamilyCountLabel.AutoSize = true;
            this.FamilyCountLabel.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FamilyCountLabel.Location = new System.Drawing.Point(458, 141);
            this.FamilyCountLabel.Name = "FamilyCountLabel";
            this.FamilyCountLabel.Size = new System.Drawing.Size(154, 15);
            this.FamilyCountLabel.TabIndex = 4;
            this.FamilyCountLabel.Text = "Number of Family Members:";
            // 
            // RetypePasswordLabel
            // 
            this.RetypePasswordLabel.AutoSize = true;
            this.RetypePasswordLabel.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetypePasswordLabel.Location = new System.Drawing.Point(458, 275);
            this.RetypePasswordLabel.Name = "RetypePasswordLabel";
            this.RetypePasswordLabel.Size = new System.Drawing.Size(99, 15);
            this.RetypePasswordLabel.TabIndex = 5;
            this.RetypePasswordLabel.Text = "Retype Password:";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTextBox.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.UsernameTextBox.Location = new System.Drawing.Point(117, 72);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(335, 22);
            this.UsernameTextBox.TabIndex = 6;
            // 
            // FullNameTextbox
            // 
            this.FullNameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.FullNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FullNameTextbox.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.FullNameTextbox.Location = new System.Drawing.Point(117, 139);
            this.FullNameTextbox.Name = "FullNameTextbox";
            this.FullNameTextbox.Size = new System.Drawing.Size(335, 22);
            this.FullNameTextbox.TabIndex = 7;
            // 
            // BirthdayDateTimePicker
            // 
            this.BirthdayDateTimePicker.CalendarFont = new System.Drawing.Font("Open Sans", 8.25F);
            this.BirthdayDateTimePicker.CalendarForeColor = System.Drawing.Color.Black;
            this.BirthdayDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.BirthdayDateTimePicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.BirthdayDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.BirthdayDateTimePicker.CalendarTrailingForeColor = System.Drawing.Color.Black;
            this.BirthdayDateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.BirthdayDateTimePicker.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.BirthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BirthdayDateTimePicker.Location = new System.Drawing.Point(117, 206);
            this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            this.BirthdayDateTimePicker.Size = new System.Drawing.Size(335, 22);
            this.BirthdayDateTimePicker.TabIndex = 8;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.PasswordTextBox.Location = new System.Drawing.Point(117, 273);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(335, 22);
            this.PasswordTextBox.TabIndex = 9;
            // 
            // RetypePasswordTextbox
            // 
            this.RetypePasswordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.RetypePasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RetypePasswordTextbox.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.RetypePasswordTextbox.Location = new System.Drawing.Point(563, 275);
            this.RetypePasswordTextbox.Name = "RetypePasswordTextbox";
            this.RetypePasswordTextbox.Size = new System.Drawing.Size(335, 22);
            this.RetypePasswordTextbox.TabIndex = 10;
            // 
            // FamilyNumericUpDown
            // 
            this.FamilyNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.FamilyNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FamilyNumericUpDown.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.FamilyNumericUpDown.Location = new System.Drawing.Point(619, 133);
            this.FamilyNumericUpDown.Name = "FamilyNumericUpDown";
            this.FamilyNumericUpDown.Size = new System.Drawing.Size(279, 22);
            this.FamilyNumericUpDown.TabIndex = 11;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.MaleRadioButton.Location = new System.Drawing.Point(552, 72);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(50, 19);
            this.MaleRadioButton.TabIndex = 12;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemleRadioButton
            // 
            this.FemleRadioButton.AutoSize = true;
            this.FemleRadioButton.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.FemleRadioButton.Location = new System.Drawing.Point(720, 72);
            this.FemleRadioButton.Name = "FemleRadioButton";
            this.FemleRadioButton.Size = new System.Drawing.Size(62, 19);
            this.FemleRadioButton.TabIndex = 13;
            this.FemleRadioButton.TabStop = true;
            this.FemleRadioButton.Text = "Female";
            this.FemleRadioButton.UseVisualStyleBackColor = true;
            // 
            // AgreeTermsCheckBox
            // 
            this.AgreeTermsCheckBox.AutoSize = true;
            this.AgreeTermsCheckBox.Enabled = false;
            this.AgreeTermsCheckBox.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.AgreeTermsCheckBox.Location = new System.Drawing.Point(197, 354);
            this.AgreeTermsCheckBox.Name = "AgreeTermsCheckBox";
            this.AgreeTermsCheckBox.Size = new System.Drawing.Size(214, 19);
            this.AgreeTermsCheckBox.TabIndex = 14;
            this.AgreeTermsCheckBox.Text = "I agree to the Terms and Conditions.";
            this.AgreeTermsCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreateAccountLabel
            // 
            this.CreateAccountLabel.AutoSize = true;
            this.CreateAccountLabel.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountLabel.Location = new System.Drawing.Point(599, 355);
            this.CreateAccountLabel.Name = "CreateAccountLabel";
            this.CreateAccountLabel.Size = new System.Drawing.Size(139, 15);
            this.CreateAccountLabel.TabIndex = 15;
            this.CreateAccountLabel.Text = "View Terms and Conditions";
            this.CreateAccountLabel.Click += new System.EventHandler(this.CreateAccountLabel_Click);
            // 
            // ReturnLoginButton
            // 
            this.ReturnLoginButton.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnLoginButton.Location = new System.Drawing.Point(992, 451);
            this.ReturnLoginButton.Name = "ReturnLoginButton";
            this.ReturnLoginButton.Size = new System.Drawing.Size(137, 56);
            this.ReturnLoginButton.TabIndex = 3;
            this.ReturnLoginButton.Text = "Return login form";
            this.ReturnLoginButton.UseVisualStyleBackColor = true;
            this.ReturnLoginButton.Click += new System.EventHandler(this.ReturnLoginButton_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(849, 451);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(137, 56);
            this.RegisterButton.TabIndex = 4;
            this.RegisterButton.Text = "Register && login";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.ReturnLoginButton);
            this.Controls.Add(this.InformationGroupBox);
            this.Font = new System.Drawing.Font("Open Sans Light", 8.25F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "CreateAccount";
            this.Size = new System.Drawing.Size(1200, 600);
            this.InformationGroupBox.ResumeLayout(false);
            this.InformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FamilyNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox InformationGroupBox;
        private System.Windows.Forms.Label RetypePasswordLabel;
        private System.Windows.Forms.Label FamilyCountLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.DateTimePicker BirthdayDateTimePicker;
        private System.Windows.Forms.TextBox FullNameTextbox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.RadioButton FemleRadioButton;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.NumericUpDown FamilyNumericUpDown;
        private System.Windows.Forms.TextBox RetypePasswordTextbox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.CheckBox AgreeTermsCheckBox;
        private System.Windows.Forms.Label CreateAccountLabel;
        private System.Windows.Forms.Button ReturnLoginButton;
        private System.Windows.Forms.Button RegisterButton;
    }
}

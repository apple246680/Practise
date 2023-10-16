namespace Session1
{
    partial class CreateAccountForm
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
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.ReturnLoginBtn = new System.Windows.Forms.Button();
            this.InformationGroupBox = new System.Windows.Forms.GroupBox();
            this.ViewTermsLinkLabel = new System.Windows.Forms.LinkLabel();
            this.TermsCheckBox = new System.Windows.Forms.CheckBox();
            this.RetypePasswordLabel = new System.Windows.Forms.Label();
            this.FamilyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FamilyCountLabel = new System.Windows.Forms.Label();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.BirthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BirthdayLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.RetypePasswordTextBox = new System.Windows.Forms.TextBox();
            this.InformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FamilyNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.RegisterBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            this.RegisterBtn.Location = new System.Drawing.Point(716, 328);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(132, 37);
            this.RegisterBtn.TabIndex = 11;
            this.RegisterBtn.Text = "Register && login";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // ReturnLoginBtn
            // 
            this.ReturnLoginBtn.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            this.ReturnLoginBtn.Location = new System.Drawing.Point(854, 328);
            this.ReturnLoginBtn.Name = "ReturnLoginBtn";
            this.ReturnLoginBtn.Size = new System.Drawing.Size(165, 37);
            this.ReturnLoginBtn.TabIndex = 12;
            this.ReturnLoginBtn.Text = "Return login form";
            this.ReturnLoginBtn.UseVisualStyleBackColor = true;
            this.ReturnLoginBtn.Click += new System.EventHandler(this.ReturnLoginBtn_Click);
            // 
            // InformationGroupBox
            // 
            this.InformationGroupBox.Controls.Add(this.ViewTermsLinkLabel);
            this.InformationGroupBox.Controls.Add(this.TermsCheckBox);
            this.InformationGroupBox.Controls.Add(this.RetypePasswordLabel);
            this.InformationGroupBox.Controls.Add(this.FamilyNumericUpDown);
            this.InformationGroupBox.Controls.Add(this.FamilyCountLabel);
            this.InformationGroupBox.Controls.Add(this.FemaleRadioButton);
            this.InformationGroupBox.Controls.Add(this.MaleRadioButton);
            this.InformationGroupBox.Controls.Add(this.PasswordTextBox);
            this.InformationGroupBox.Controls.Add(this.PasswordLabel);
            this.InformationGroupBox.Controls.Add(this.BirthdayDateTimePicker);
            this.InformationGroupBox.Controls.Add(this.BirthdayLabel);
            this.InformationGroupBox.Controls.Add(this.FullNameTextBox);
            this.InformationGroupBox.Controls.Add(this.FullNameLabel);
            this.InformationGroupBox.Controls.Add(this.UsernameTextBox);
            this.InformationGroupBox.Controls.Add(this.UsernameLabel);
            this.InformationGroupBox.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            this.InformationGroupBox.Location = new System.Drawing.Point(74, 37);
            this.InformationGroupBox.Name = "InformationGroupBox";
            this.InformationGroupBox.Size = new System.Drawing.Size(945, 285);
            this.InformationGroupBox.TabIndex = 0;
            this.InformationGroupBox.TabStop = false;
            this.InformationGroupBox.Text = "Yourr Information";
            // 
            // ViewTermsLinkLabel
            // 
            this.ViewTermsLinkLabel.ActiveLinkColor = System.Drawing.Color.Black;
            this.ViewTermsLinkLabel.AutoSize = true;
            this.ViewTermsLinkLabel.Font = new System.Drawing.Font("Open Sans", 12F);
            this.ViewTermsLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.ViewTermsLinkLabel.Location = new System.Drawing.Point(465, 248);
            this.ViewTermsLinkLabel.Name = "ViewTermsLinkLabel";
            this.ViewTermsLinkLabel.Size = new System.Drawing.Size(264, 28);
            this.ViewTermsLinkLabel.TabIndex = 10;
            this.ViewTermsLinkLabel.TabStop = true;
            this.ViewTermsLinkLabel.Text = "View Terms and Conditions";
            this.ViewTermsLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ViewTermsLinkLabel_LinkClicked);
            // 
            // TermsCheckBox
            // 
            this.TermsCheckBox.AutoSize = true;
            this.TermsCheckBox.Enabled = false;
            this.TermsCheckBox.Font = new System.Drawing.Font("Open Sans", 12F);
            this.TermsCheckBox.Location = new System.Drawing.Point(26, 247);
            this.TermsCheckBox.Name = "TermsCheckBox";
            this.TermsCheckBox.Size = new System.Drawing.Size(384, 32);
            this.TermsCheckBox.TabIndex = 9;
            this.TermsCheckBox.Text = "I agree to the Terms amd Connditions";
            this.TermsCheckBox.UseVisualStyleBackColor = true;
            // 
            // RetypePasswordLabel
            // 
            this.RetypePasswordLabel.AutoSize = true;
            this.RetypePasswordLabel.Font = new System.Drawing.Font("Open Sans", 12F);
            this.RetypePasswordLabel.Location = new System.Drawing.Point(476, 184);
            this.RetypePasswordLabel.Name = "RetypePasswordLabel";
            this.RetypePasswordLabel.Size = new System.Drawing.Size(175, 28);
            this.RetypePasswordLabel.TabIndex = 0;
            this.RetypePasswordLabel.Text = "Retype Password:";
            // 
            // FamilyNumericUpDown
            // 
            this.FamilyNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.FamilyNumericUpDown.Font = new System.Drawing.Font("Open Sans Light", 12F);
            this.FamilyNumericUpDown.Location = new System.Drawing.Point(751, 102);
            this.FamilyNumericUpDown.Name = "FamilyNumericUpDown";
            this.FamilyNumericUpDown.Size = new System.Drawing.Size(54, 35);
            this.FamilyNumericUpDown.TabIndex = 8;
            // 
            // FamilyCountLabel
            // 
            this.FamilyCountLabel.AutoSize = true;
            this.FamilyCountLabel.Font = new System.Drawing.Font("Open Sans", 12F);
            this.FamilyCountLabel.Location = new System.Drawing.Point(476, 102);
            this.FamilyCountLabel.Name = "FamilyCountLabel";
            this.FamilyCountLabel.Size = new System.Drawing.Size(277, 28);
            this.FamilyCountLabel.TabIndex = 0;
            this.FamilyCountLabel.Text = "Number of Family Members:";
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Font = new System.Drawing.Font("Open Sans", 12F);
            this.FemaleRadioButton.Location = new System.Drawing.Point(596, 67);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(100, 32);
            this.FemaleRadioButton.TabIndex = 7;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Font = new System.Drawing.Font("Open Sans", 12F);
            this.MaleRadioButton.Location = new System.Drawing.Point(512, 67);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(78, 32);
            this.MaleRadioButton.TabIndex = 6;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Font = new System.Drawing.Font("Open Sans Light", 12F);
            this.PasswordTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.PasswordTextBox.Location = new System.Drawing.Point(211, 177);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(259, 35);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Open Sans", 12F);
            this.PasswordLabel.Location = new System.Drawing.Point(80, 176);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(107, 28);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Password:";
            // 
            // BirthdayDateTimePicker
            // 
            this.BirthdayDateTimePicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.BirthdayDateTimePicker.CustomFormat = " / /";
            this.BirthdayDateTimePicker.Font = new System.Drawing.Font("Open Sans Light", 12F);
            this.BirthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BirthdayDateTimePicker.Location = new System.Drawing.Point(211, 136);
            this.BirthdayDateTimePicker.Name = "BirthdayDateTimePicker";
            this.BirthdayDateTimePicker.Size = new System.Drawing.Size(259, 35);
            this.BirthdayDateTimePicker.TabIndex = 3;
            // 
            // BirthdayLabel
            // 
            this.BirthdayLabel.AutoSize = true;
            this.BirthdayLabel.Font = new System.Drawing.Font("Open Sans", 12F);
            this.BirthdayLabel.Location = new System.Drawing.Point(80, 134);
            this.BirthdayLabel.Name = "BirthdayLabel";
            this.BirthdayLabel.Size = new System.Drawing.Size(95, 28);
            this.BirthdayLabel.TabIndex = 0;
            this.BirthdayLabel.Text = "Birthday:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.FullNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FullNameTextBox.Font = new System.Drawing.Font("Open Sans Light", 12F);
            this.FullNameTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.FullNameTextBox.Location = new System.Drawing.Point(211, 93);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(259, 35);
            this.FullNameTextBox.TabIndex = 2;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Open Sans", 12F);
            this.FullNameLabel.Location = new System.Drawing.Point(80, 93);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(110, 28);
            this.FullNameLabel.TabIndex = 0;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.UsernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UsernameTextBox.Font = new System.Drawing.Font("Open Sans Light", 12F);
            this.UsernameTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.UsernameTextBox.Location = new System.Drawing.Point(211, 52);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(259, 35);
            this.UsernameTextBox.TabIndex = 1;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Open Sans", 12F);
            this.UsernameLabel.Location = new System.Drawing.Point(80, 52);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(114, 28);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username:";
            // 
            // RetypePasswordTextBox
            // 
            this.RetypePasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.RetypePasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RetypePasswordTextBox.Font = new System.Drawing.Font("Open Sans Light", 12F);
            this.RetypePasswordTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.RetypePasswordTextBox.Location = new System.Drawing.Point(731, 221);
            this.RetypePasswordTextBox.Name = "RetypePasswordTextBox";
            this.RetypePasswordTextBox.Size = new System.Drawing.Size(259, 35);
            this.RetypePasswordTextBox.TabIndex = 5;
            this.RetypePasswordTextBox.UseSystemPasswordChar = true;
            // 
            // CreateAccountForm
            // 
            this.AcceptButton = this.RegisterBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(1054, 390);
            this.Controls.Add(this.RetypePasswordTextBox);
            this.Controls.Add(this.InformationGroupBox);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.ReturnLoginBtn);
            this.Font = new System.Drawing.Font("Open Sans Light", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "CreateAccountForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seoul Stay - Create Account";
            this.InformationGroupBox.ResumeLayout(false);
            this.InformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FamilyNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button ReturnLoginBtn;
        private System.Windows.Forms.GroupBox InformationGroupBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.DateTimePicker BirthdayDateTimePicker;
        private System.Windows.Forms.Label BirthdayLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.CheckBox TermsCheckBox;
        private System.Windows.Forms.Label RetypePasswordLabel;
        private System.Windows.Forms.NumericUpDown FamilyNumericUpDown;
        private System.Windows.Forms.Label FamilyCountLabel;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox RetypePasswordTextBox;
        private System.Windows.Forms.LinkLabel ViewTermsLinkLabel;
    }
}
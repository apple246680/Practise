namespace Session1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.LoginGroupBox = new System.Windows.Forms.GroupBox();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.KeepSignCheckBox = new System.Windows.Forms.CheckBox();
            this.EmployeeTextBox = new System.Windows.Forms.TextBox();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CreateAccountLabel = new System.Windows.Forms.Label();
            this.CreateLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.LoginGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(273, 12);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(442, 119);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.Controls.Add(this.ShowPasswordCheckBox);
            this.LoginGroupBox.Controls.Add(this.KeepSignCheckBox);
            this.LoginGroupBox.Controls.Add(this.EmployeeTextBox);
            this.LoginGroupBox.Controls.Add(this.UserTextBox);
            this.LoginGroupBox.Controls.Add(this.PasswordTextBox);
            this.LoginGroupBox.Controls.Add(this.PasswordLabel);
            this.LoginGroupBox.Controls.Add(this.UserLabel);
            this.LoginGroupBox.Controls.Add(this.EmployeeLabel);
            this.LoginGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginGroupBox.Font = new System.Drawing.Font("Open Sans SemiBold", 12F);
            this.LoginGroupBox.Location = new System.Drawing.Point(73, 137);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.Size = new System.Drawing.Size(818, 250);
            this.LoginGroupBox.TabIndex = 0;
            this.LoginGroupBox.TabStop = false;
            this.LoginGroupBox.Text = "Login";
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Open Sans", 12F);
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(600, 140);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(179, 32);
            this.ShowPasswordCheckBox.TabIndex = 5;
            this.ShowPasswordCheckBox.Text = "Show Password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // KeepSignCheckBox
            // 
            this.KeepSignCheckBox.AutoSize = true;
            this.KeepSignCheckBox.Font = new System.Drawing.Font("Open Sans", 12F);
            this.KeepSignCheckBox.Location = new System.Drawing.Point(600, 87);
            this.KeepSignCheckBox.Name = "KeepSignCheckBox";
            this.KeepSignCheckBox.Size = new System.Drawing.Size(203, 32);
            this.KeepSignCheckBox.TabIndex = 4;
            this.KeepSignCheckBox.Text = "Keep me signed in";
            this.KeepSignCheckBox.UseVisualStyleBackColor = true;
            // 
            // EmployeeTextBox
            // 
            this.EmployeeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.EmployeeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeeTextBox.Font = new System.Drawing.Font("Open Sans Light", 12F);
            this.EmployeeTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.EmployeeTextBox.Location = new System.Drawing.Point(200, 60);
            this.EmployeeTextBox.Name = "EmployeeTextBox";
            this.EmployeeTextBox.Size = new System.Drawing.Size(394, 35);
            this.EmployeeTextBox.TabIndex = 1;
            // 
            // UserTextBox
            // 
            this.UserTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.UserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserTextBox.Font = new System.Drawing.Font("Open Sans Light", 12F);
            this.UserTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.UserTextBox.Location = new System.Drawing.Point(200, 113);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(394, 35);
            this.UserTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.PasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextBox.Font = new System.Drawing.Font("Open Sans Light", 12F);
            this.PasswordTextBox.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.PasswordTextBox.Location = new System.Drawing.Point(200, 166);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(394, 35);
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.UseSystemPasswordChar = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(81, 166);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(107, 28);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Password:";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(81, 113);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(61, 28);
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Text = "User:";
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeLabel.Location = new System.Drawing.Point(81, 60);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(108, 28);
            this.EmployeeLabel.TabIndex = 0;
            this.EmployeeLabel.Text = "Employee:";
            // 
            // LoginButton
            // 
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Open Sans", 12F);
            this.LoginButton.Image = ((System.Drawing.Image)(resources.GetObject("LoginButton.Image")));
            this.LoginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginButton.Location = new System.Drawing.Point(273, 425);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(212, 56);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Open Sans", 12F);
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(491, 425);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(176, 56);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CreateAccountLabel
            // 
            this.CreateAccountLabel.AutoSize = true;
            this.CreateAccountLabel.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountLabel.Location = new System.Drawing.Point(268, 499);
            this.CreateAccountLabel.Name = "CreateAccountLabel";
            this.CreateAccountLabel.Size = new System.Drawing.Size(228, 28);
            this.CreateAccountLabel.TabIndex = 3;
            this.CreateAccountLabel.Text = "Don\'t have on account?";
            // 
            // CreateLinkLabel
            // 
            this.CreateLinkLabel.ActiveLinkColor = System.Drawing.Color.Black;
            this.CreateLinkLabel.AutoSize = true;
            this.CreateLinkLabel.Font = new System.Drawing.Font("Open Sans", 12F);
            this.CreateLinkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.CreateLinkLabel.Location = new System.Drawing.Point(533, 499);
            this.CreateLinkLabel.Name = "CreateLinkLabel";
            this.CreateLinkLabel.Size = new System.Drawing.Size(113, 28);
            this.CreateLinkLabel.TabIndex = 4;
            this.CreateLinkLabel.TabStop = true;
            this.CreateLinkLabel.Text = "Create one";
            this.CreateLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateLinkLabel_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.CreateLinkLabel);
            this.Controls.Add(this.CreateAccountLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LoginGroupBox);
            this.Controls.Add(this.LogoPictureBox);
            this.Font = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seoul Stay - Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.GroupBox LoginGroupBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.CheckBox KeepSignCheckBox;
        private System.Windows.Forms.TextBox EmployeeTextBox;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label CreateAccountLabel;
        private System.Windows.Forms.LinkLabel CreateLinkLabel;
    }
}


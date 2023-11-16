namespace Session1
{
    partial class Login
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
            this.LoginGroupBox = new System.Windows.Forms.GroupBox();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.KeepSignedCheckbox = new System.Windows.Forms.CheckBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.CreateBodyLabel = new System.Windows.Forms.Label();
            this.CreateLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.LoginGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.Controls.Add(this.ShowPassword);
            this.LoginGroupBox.Controls.Add(this.KeepSignedCheckbox);
            this.LoginGroupBox.Controls.Add(this.PasswordTextbox);
            this.LoginGroupBox.Controls.Add(this.UserTextBox);
            this.LoginGroupBox.Controls.Add(this.EmployeeTextBox);
            this.LoginGroupBox.Controls.Add(this.PasswordLabel);
            this.LoginGroupBox.Controls.Add(this.UserLabel);
            this.LoginGroupBox.Controls.Add(this.EmployeeLabel);
            this.LoginGroupBox.Font = new System.Drawing.Font("Open Sans SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.LoginGroupBox.Location = new System.Drawing.Point(102, 187);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.Size = new System.Drawing.Size(760, 136);
            this.LoginGroupBox.TabIndex = 1;
            this.LoginGroupBox.TabStop = false;
            this.LoginGroupBox.Text = "Login";
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Location = new System.Drawing.Point(562, 99);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(158, 28);
            this.ShowPassword.TabIndex = 9;
            this.ShowPassword.Text = "Show Password";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // KeepSignedCheckbox
            // 
            this.KeepSignedCheckbox.AutoSize = true;
            this.KeepSignedCheckbox.Location = new System.Drawing.Point(562, 40);
            this.KeepSignedCheckbox.Name = "KeepSignedCheckbox";
            this.KeepSignedCheckbox.Size = new System.Drawing.Size(182, 28);
            this.KeepSignedCheckbox.TabIndex = 6;
            this.KeepSignedCheckbox.Text = "Keep me signed in";
            this.KeepSignedCheckbox.UseVisualStyleBackColor = true;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(285, 101);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(271, 30);
            this.PasswordTextbox.TabIndex = 5;
            this.PasswordTextbox.UseSystemPasswordChar = true;
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(285, 69);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(271, 30);
            this.UserTextBox.TabIndex = 4;
            // 
            // EmployeeTextBox
            // 
            this.EmployeeTextBox.Location = new System.Drawing.Point(285, 37);
            this.EmployeeTextBox.Name = "EmployeeTextBox";
            this.EmployeeTextBox.Size = new System.Drawing.Size(271, 30);
            this.EmployeeTextBox.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(184, 103);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(93, 24);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password:";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Location = new System.Drawing.Point(184, 71);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(53, 24);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "User:";
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Location = new System.Drawing.Point(184, 40);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(95, 24);
            this.EmployeeLabel.TabIndex = 0;
            this.EmployeeLabel.Text = "Employee:";
            // 
            // CreateBodyLabel
            // 
            this.CreateBodyLabel.AutoSize = true;
            this.CreateBodyLabel.Font = new System.Drawing.Font("Open Sans Light", 10F);
            this.CreateBodyLabel.Location = new System.Drawing.Point(373, 399);
            this.CreateBodyLabel.Name = "CreateBodyLabel";
            this.CreateBodyLabel.Size = new System.Drawing.Size(186, 24);
            this.CreateBodyLabel.TabIndex = 8;
            this.CreateBodyLabel.Text = "Don\'t have an account?";
            // 
            // CreateLabel
            // 
            this.CreateLabel.AutoSize = true;
            this.CreateLabel.Font = new System.Drawing.Font("Open Sans Light", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateLabel.Location = new System.Drawing.Point(564, 399);
            this.CreateLabel.Name = "CreateLabel";
            this.CreateLabel.Size = new System.Drawing.Size(94, 24);
            this.CreateLabel.TabIndex = 2;
            this.CreateLabel.Text = "Create one";
            this.CreateLabel.Click += new System.EventHandler(this.CreateLabel_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Image = global::Session1.Properties.Resources.Screenshot_2023_11_16_094145;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(487, 329);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(121, 63);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Image = global::Session1.Properties.Resources.Screenshot_2023_11_16_094054;
            this.LoginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginButton.Location = new System.Drawing.Point(350, 329);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(121, 63);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Login";
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::Session1.Properties.Resources.WSC2022SE_TP09_Logo_actual_en;
            this.LogoPictureBox.Location = new System.Drawing.Point(308, 23);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(315, 153);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.Controls.Add(this.CreateBodyLabel);
            this.Controls.Add(this.CreateLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoginGroupBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LogoPictureBox);
            this.Font = new System.Drawing.Font("Open Sans Light", 8.25F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1000, 527);
            this.Load += new System.EventHandler(this.Login_Load);
            this.LoginGroupBox.ResumeLayout(false);
            this.LoginGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.GroupBox LoginGroupBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox EmployeeTextBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.CheckBox KeepSignedCheckbox;
        private System.Windows.Forms.Label CreateBodyLabel;
        private System.Windows.Forms.Label CreateLabel;
    }
}

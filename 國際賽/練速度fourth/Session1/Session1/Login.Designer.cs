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
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.KeepSignedCheckBox = new System.Windows.Forms.CheckBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.UserTextbox = new System.Windows.Forms.TextBox();
            this.EmployeeTextbox = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.CreateAccountBodyLabel = new System.Windows.Forms.Label();
            this.CreateAccountLabel = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.LoginGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.Controls.Add(this.ShowPasswordCheckBox);
            this.LoginGroupBox.Controls.Add(this.KeepSignedCheckBox);
            this.LoginGroupBox.Controls.Add(this.PasswordTextbox);
            this.LoginGroupBox.Controls.Add(this.UserTextbox);
            this.LoginGroupBox.Controls.Add(this.EmployeeTextbox);
            this.LoginGroupBox.Controls.Add(this.PasswordLabel);
            this.LoginGroupBox.Controls.Add(this.UserLabel);
            this.LoginGroupBox.Controls.Add(this.EmployeeLabel);
            this.LoginGroupBox.Font = new System.Drawing.Font("Open Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginGroupBox.Location = new System.Drawing.Point(154, 296);
            this.LoginGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginGroupBox.Size = new System.Drawing.Size(746, 173);
            this.LoginGroupBox.TabIndex = 1;
            this.LoginGroupBox.TabStop = false;
            this.LoginGroupBox.Text = "Login";
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.ForeColor = System.Drawing.Color.Black;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(478, 110);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(143, 26);
            this.ShowPasswordCheckBox.TabIndex = 7;
            this.ShowPasswordCheckBox.Text = "Show Password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // KeepSignedCheckBox
            // 
            this.KeepSignedCheckBox.AutoSize = true;
            this.KeepSignedCheckBox.ForeColor = System.Drawing.Color.Black;
            this.KeepSignedCheckBox.Location = new System.Drawing.Point(478, 67);
            this.KeepSignedCheckBox.Name = "KeepSignedCheckBox";
            this.KeepSignedCheckBox.Size = new System.Drawing.Size(165, 26);
            this.KeepSignedCheckBox.TabIndex = 6;
            this.KeepSignedCheckBox.Text = "Keep me signed in";
            this.KeepSignedCheckBox.UseVisualStyleBackColor = true;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.ForeColor = System.Drawing.Color.Black;
            this.PasswordTextbox.Location = new System.Drawing.Point(143, 124);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(297, 28);
            this.PasswordTextbox.TabIndex = 5;
            this.PasswordTextbox.UseSystemPasswordChar = true;
            // 
            // UserTextbox
            // 
            this.UserTextbox.ForeColor = System.Drawing.Color.Black;
            this.UserTextbox.Location = new System.Drawing.Point(143, 87);
            this.UserTextbox.Name = "UserTextbox";
            this.UserTextbox.Size = new System.Drawing.Size(297, 28);
            this.UserTextbox.TabIndex = 4;
            // 
            // EmployeeTextbox
            // 
            this.EmployeeTextbox.ForeColor = System.Drawing.Color.Black;
            this.EmployeeTextbox.Location = new System.Drawing.Point(143, 48);
            this.EmployeeTextbox.Name = "EmployeeTextbox";
            this.EmployeeTextbox.Size = new System.Drawing.Size(297, 28);
            this.EmployeeTextbox.TabIndex = 3;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Open Sans", 9F);
            this.PasswordLabel.ForeColor = System.Drawing.Color.Black;
            this.PasswordLabel.Location = new System.Drawing.Point(43, 124);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(81, 22);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password:";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Open Sans", 9F);
            this.UserLabel.ForeColor = System.Drawing.Color.Black;
            this.UserLabel.Location = new System.Drawing.Point(43, 87);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(46, 22);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "User:";
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Font = new System.Drawing.Font("Open Sans", 9F);
            this.EmployeeLabel.ForeColor = System.Drawing.Color.Black;
            this.EmployeeLabel.Location = new System.Drawing.Point(43, 48);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(82, 22);
            this.EmployeeLabel.TabIndex = 0;
            this.EmployeeLabel.Text = "Employee:";
            // 
            // CreateAccountBodyLabel
            // 
            this.CreateAccountBodyLabel.AutoSize = true;
            this.CreateAccountBodyLabel.Font = new System.Drawing.Font("Open Sans", 9F);
            this.CreateAccountBodyLabel.ForeColor = System.Drawing.Color.Black;
            this.CreateAccountBodyLabel.Location = new System.Drawing.Point(307, 552);
            this.CreateAccountBodyLabel.Name = "CreateAccountBodyLabel";
            this.CreateAccountBodyLabel.Size = new System.Drawing.Size(168, 22);
            this.CreateAccountBodyLabel.TabIndex = 4;
            this.CreateAccountBodyLabel.Text = "Don\'t have an account?";
            // 
            // CreateAccountLabel
            // 
            this.CreateAccountLabel.AutoSize = true;
            this.CreateAccountLabel.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountLabel.Location = new System.Drawing.Point(482, 556);
            this.CreateAccountLabel.Name = "CreateAccountLabel";
            this.CreateAccountLabel.Size = new System.Drawing.Size(84, 22);
            this.CreateAccountLabel.TabIndex = 5;
            this.CreateAccountLabel.Text = "Create one";
            this.CreateAccountLabel.Click += new System.EventHandler(this.CreateAccountLabel_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Image = global::Session1.Properties.Resources._277_exit;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(419, 493);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(74, 56);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Open Sans SemiBold", 9F);
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.Image = global::Session1.Properties.Resources._276_enter;
            this.LoginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginButton.Location = new System.Drawing.Point(339, 493);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(74, 56);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::Session1.Properties.Resources.WSC2022SE_TP09_Logo_actual_en;
            this.LogoPictureBox.Location = new System.Drawing.Point(339, 31);
            this.LogoPictureBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(320, 257);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.Controls.Add(this.CreateAccountLabel);
            this.Controls.Add(this.CreateAccountBodyLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LoginGroupBox);
            this.Controls.Add(this.LogoPictureBox);
            this.Font = new System.Drawing.Font("Open Sans Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1000, 800);
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
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.CheckBox KeepSignedCheckBox;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.TextBox UserTextbox;
        private System.Windows.Forms.TextBox EmployeeTextbox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label CreateAccountBodyLabel;
        private System.Windows.Forms.Label CreateAccountLabel;
    }
}

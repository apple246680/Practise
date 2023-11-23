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
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.EmployeeTextbox = new System.Windows.Forms.TextBox();
            this.UserTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.KeepSignedCheckbox = new System.Windows.Forms.CheckBox();
            this.ShowPasswordCheckbox = new System.Windows.Forms.CheckBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.CreateAccountBodyLabel = new System.Windows.Forms.Label();
            this.CreateAccountLabel = new System.Windows.Forms.Label();
            this.LoginGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginGroupBox
            // 
            this.LoginGroupBox.Controls.Add(this.ShowPasswordCheckbox);
            this.LoginGroupBox.Controls.Add(this.KeepSignedCheckbox);
            this.LoginGroupBox.Controls.Add(this.PasswordTextbox);
            this.LoginGroupBox.Controls.Add(this.UserTextbox);
            this.LoginGroupBox.Controls.Add(this.EmployeeTextbox);
            this.LoginGroupBox.Controls.Add(this.PasswordLabel);
            this.LoginGroupBox.Controls.Add(this.UserLabel);
            this.LoginGroupBox.Controls.Add(this.EmployeeLabel);
            this.LoginGroupBox.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F);
            this.LoginGroupBox.Location = new System.Drawing.Point(231, 182);
            this.LoginGroupBox.Name = "LoginGroupBox";
            this.LoginGroupBox.Size = new System.Drawing.Size(707, 233);
            this.LoginGroupBox.TabIndex = 1;
            this.LoginGroupBox.TabStop = false;
            this.LoginGroupBox.Text = "Login";
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.EmployeeLabel.Location = new System.Drawing.Point(56, 64);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(61, 15);
            this.EmployeeLabel.TabIndex = 0;
            this.EmployeeLabel.Text = "Employee:";
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.UserLabel.Location = new System.Drawing.Point(56, 125);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(33, 15);
            this.UserLabel.TabIndex = 1;
            this.UserLabel.Text = "User:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.PasswordLabel.Location = new System.Drawing.Point(56, 182);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(60, 15);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password:";
            // 
            // EmployeeTextbox
            // 
            this.EmployeeTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.EmployeeTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmployeeTextbox.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.EmployeeTextbox.Location = new System.Drawing.Point(124, 64);
            this.EmployeeTextbox.Name = "EmployeeTextbox";
            this.EmployeeTextbox.Size = new System.Drawing.Size(335, 22);
            this.EmployeeTextbox.TabIndex = 3;
            // 
            // UserTextbox
            // 
            this.UserTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.UserTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserTextbox.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.UserTextbox.Location = new System.Drawing.Point(124, 123);
            this.UserTextbox.Name = "UserTextbox";
            this.UserTextbox.Size = new System.Drawing.Size(335, 22);
            this.UserTextbox.TabIndex = 4;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.PasswordTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordTextbox.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.PasswordTextbox.Location = new System.Drawing.Point(124, 182);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(335, 22);
            this.PasswordTextbox.TabIndex = 5;
            // 
            // KeepSignedCheckbox
            // 
            this.KeepSignedCheckbox.AutoSize = true;
            this.KeepSignedCheckbox.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.KeepSignedCheckbox.Location = new System.Drawing.Point(490, 105);
            this.KeepSignedCheckbox.Name = "KeepSignedCheckbox";
            this.KeepSignedCheckbox.Size = new System.Drawing.Size(121, 19);
            this.KeepSignedCheckbox.TabIndex = 6;
            this.KeepSignedCheckbox.Text = "Keep me signed in";
            this.KeepSignedCheckbox.UseVisualStyleBackColor = true;
            // 
            // ShowPasswordCheckbox
            // 
            this.ShowPasswordCheckbox.AutoSize = true;
            this.ShowPasswordCheckbox.Font = new System.Drawing.Font("Open Sans", 8.25F);
            this.ShowPasswordCheckbox.Location = new System.Drawing.Point(490, 159);
            this.ShowPasswordCheckbox.Name = "ShowPasswordCheckbox";
            this.ShowPasswordCheckbox.Size = new System.Drawing.Size(108, 19);
            this.ShowPasswordCheckbox.TabIndex = 7;
            this.ShowPasswordCheckbox.Text = "Show Password";
            this.ShowPasswordCheckbox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckbox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckbox_CheckedChanged);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Image = global::Session1.Properties.Resources.exit;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(596, 431);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(137, 56);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Font = new System.Drawing.Font("Open Sans SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.Image = global::Session1.Properties.Resources.login;
            this.LoginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginButton.Location = new System.Drawing.Point(405, 431);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(137, 56);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = global::Session1.Properties.Resources.WSC2022SE_TP09_Logo_actual_en;
            this.LogoPictureBox.Location = new System.Drawing.Point(405, 28);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(352, 148);
            this.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPictureBox.TabIndex = 0;
            this.LogoPictureBox.TabStop = false;
            // 
            // CreateAccountBodyLabel
            // 
            this.CreateAccountBodyLabel.AutoSize = true;
            this.CreateAccountBodyLabel.Location = new System.Drawing.Point(422, 553);
            this.CreateAccountBodyLabel.Name = "CreateAccountBodyLabel";
            this.CreateAccountBodyLabel.Size = new System.Drawing.Size(120, 15);
            this.CreateAccountBodyLabel.TabIndex = 4;
            this.CreateAccountBodyLabel.Text = "Don\'t have an account?";
            // 
            // CreateAccountLabel
            // 
            this.CreateAccountLabel.AutoSize = true;
            this.CreateAccountLabel.Font = new System.Drawing.Font("Open Sans Light", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountLabel.Location = new System.Drawing.Point(559, 553);
            this.CreateAccountLabel.Name = "CreateAccountLabel";
            this.CreateAccountLabel.Size = new System.Drawing.Size(61, 15);
            this.CreateAccountLabel.TabIndex = 5;
            this.CreateAccountLabel.Text = "Create one";
            this.CreateAccountLabel.Click += new System.EventHandler(this.CreateAccountLabel_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.Controls.Add(this.CreateAccountLabel);
            this.Controls.Add(this.CreateAccountBodyLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LoginGroupBox);
            this.Controls.Add(this.LogoPictureBox);
            this.Font = new System.Drawing.Font("Open Sans Light", 8.25F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1200, 600);
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
        private System.Windows.Forms.Label EmployeeLabel;
        private System.Windows.Forms.CheckBox ShowPasswordCheckbox;
        private System.Windows.Forms.CheckBox KeepSignedCheckbox;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.TextBox UserTextbox;
        private System.Windows.Forms.TextBox EmployeeTextbox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label CreateAccountBodyLabel;
        private System.Windows.Forms.Label CreateAccountLabel;
    }
}

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Back = new System.Windows.Forms.Button();
            this.Agree = new System.Windows.Forms.CheckBox();
            this.Family = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Female = new System.Windows.Forms.RadioButton();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.RetypePassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.FullName = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.View = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Family)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(919, 495);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(230, 47);
            this.Back.TabIndex = 6;
            this.Back.Text = "Return login form";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Agree
            // 
            this.Agree.AutoSize = true;
            this.Agree.Enabled = false;
            this.Agree.Location = new System.Drawing.Point(123, 374);
            this.Agree.Name = "Agree";
            this.Agree.Size = new System.Drawing.Size(237, 19);
            this.Agree.TabIndex = 9;
            this.Agree.Text = "I agree to the Terms and Conditions.";
            this.Agree.UseVisualStyleBackColor = true;
            // 
            // Family
            // 
            this.Family.Location = new System.Drawing.Point(786, 141);
            this.Family.Name = "Family";
            this.Family.Size = new System.Drawing.Size(142, 25);
            this.Family.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(521, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Number of Family Members:";
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(800, 87);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(69, 19);
            this.Female.TabIndex = 6;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(609, 91);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(57, 19);
            this.Male.TabIndex = 6;
            this.Male.TabStop = true;
            this.Male.Text = "Male";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Birthday
            // 
            this.Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Birthday.Location = new System.Drawing.Point(132, 198);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(362, 25);
            this.Birthday.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Birthday:";
            // 
            // RetypePassword
            // 
            this.RetypePassword.Location = new System.Drawing.Point(674, 265);
            this.RetypePassword.MaxLength = 50;
            this.RetypePassword.Name = "RetypePassword";
            this.RetypePassword.Size = new System.Drawing.Size(362, 25);
            this.RetypePassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(512, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Retype Password:";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(132, 265);
            this.Password.MaxLength = 50;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(362, 25);
            this.Password.TabIndex = 1;
            // 
            // FullName
            // 
            this.FullName.Location = new System.Drawing.Point(132, 141);
            this.FullName.MaxLength = 50;
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(362, 25);
            this.FullName.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(132, 88);
            this.Username.MaxLength = 50;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(362, 25);
            this.Username.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Full Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username: ";
            // 
            // Register
            // 
            this.Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register.Location = new System.Drawing.Point(659, 495);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(230, 47);
            this.Register.TabIndex = 5;
            this.Register.Text = "Register & login";
            this.Register.UseMnemonic = false;
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.View);
            this.groupBox1.Controls.Add(this.Agree);
            this.groupBox1.Controls.Add(this.Family);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Female);
            this.groupBox1.Controls.Add(this.Male);
            this.groupBox1.Controls.Add(this.Birthday);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.RetypePassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Password);
            this.groupBox1.Controls.Add(this.FullName);
            this.groupBox1.Controls.Add(this.Username);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(133, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1044, 455);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // View
            // 
            this.View.AutoSize = true;
            this.View.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Underline);
            this.View.Location = new System.Drawing.Point(619, 369);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(223, 22);
            this.View.TabIndex = 11;
            this.View.TabStop = true;
            this.View.Text = "View terms and Conditions";
            this.View.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.View_LinkClicked);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 550);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.groupBox1);
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seoul Stay-CreateAccount";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateAccount_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Family)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.CheckBox Agree;
        private System.Windows.Forms.NumericUpDown Family;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.DateTimePicker Birthday;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RetypePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox FullName;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel View;
    }
}
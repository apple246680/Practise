using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public partial class CreateAccount : UserControl
    {

        /// <summary>
        /// InitializeComponent Create Accunt Form
        /// </summary>
        public CreateAccount()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Show Login Form
        /// </summary>
        private void ReturnLoginFormBtn_Click(object sender, EventArgs e)
        {
            Global.ShowLoginForm();
        }
        /// <summary>
        /// Watch Terms
        /// </summary>
        private void TermsLabel_Click(object sender, EventArgs e)
        {
            new Terms().ShowDialog();
            AgreeTermsCheckbox.Enabled = true;
        }
        /// <summary>
        /// Register Form
        /// </summary>
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            var entities = new Session1Entities();
            if (string.IsNullOrWhiteSpace(UsernameTextBox.Text)||
                string.IsNullOrWhiteSpace(PasswordTextBox.Text)||
                string.IsNullOrWhiteSpace(FullNameTextBox.Text)||
                string.IsNullOrWhiteSpace(RetypeTextBox.Text)
                )
            {
                entities.LogRecords.Add(new LogRecords
                {
                    GUID = Guid.NewGuid(),
                    FormName = "Register",
                    Task = "unsuccessful",
                    UsersID = Global.userID,
                    LogDT = DateTime.Now
                });
                entities.SaveChanges();
                MessageBox.Show("Input data can't blank.");
                return;
            }
            if (PasswordTextBox.Text!=RetypeTextBox.Text)
            {
                entities.LogRecords.Add(new LogRecords
                {
                    GUID = Guid.NewGuid(),
                    FormName = "Register",
                    Task = "unsuccessful",
                    UsersID = Global.userID,
                    LogDT = DateTime.Now
                });
                entities.SaveChanges();
                MessageBox.Show("Retype Password !=Password");
                return;
            }
            if (AgreeTermsCheckbox.Checked==false)
            {
                entities.LogRecords.Add(new LogRecords
                {
                    GUID = Guid.NewGuid(),
                    FormName = "Register",
                    Task = "unsuccessful",
                    UsersID = Global.userID,
                    LogDT = DateTime.Now
                });
                entities.SaveChanges();
                MessageBox.Show("Please Agree Terms");
                return;
            }
            Global.userID=Global.Register(UsernameTextBox.Text,FullNameTextBox.Text,BirthdayDateTimePicker.Value,PasswordTextBox.Text,MaleRadioButton.Checked,(int)FamilyNumericUpDown.Value).ID;
            entities.LogRecords.Add(new LogRecords
            {
                GUID = Guid.NewGuid(),
                FormName = "Register",
                Task = "Successful",
                UsersID = Global.userID,
                LogDT = DateTime.Now
            });
            entities.SaveChanges();
            Global.ShowManagementForm();
        }
    }
}

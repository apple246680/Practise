using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace Session1
{
    public partial class CreateAccountForm : Form
    {
        /// <summary>
        /// InitializeComponent CreateAccountForm
        /// </summary>
        public CreateAccountForm()
        {
            InitializeComponent();
        }
        int close = 1;
        /// <summary>
        /// Button style
        /// </summary>
        private void button_Down(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(229, 26, 46);
        }
        /// <summary>
        /// Button style
        /// </summary>
        private void button_Up(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(85, 85, 85);
        }
        /// <summary>
        /// Show TermsForm
        /// </summary>
        private void TermsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Visible = false;
            new TermsForm().ShowDialog();
            TermsCheckBox.Enabled = true;
            Visible = true;
        }
        /// <summary>
        /// Closing CreateAccountForm
        /// </summary>
        private void CreateAccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (close)
            {
                case 1:
                    Application.Exit();
                    break;
                case 2:
                    Global.LoginForm.Visible = true;
                    break;
                case 3:
                    break;
            }
        }
        /// <summary>
        /// Return to LoginForm
        /// </summary>
        private void ReturnLoginFormBtn_Click(object sender, EventArgs e)
        {
            close = 2;
            CreateAccountForm_FormClosing(null,null);
        }
        /// <summary>
        /// Register the Application and Login
        /// </summary>
        private void RegisterAndLoginBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(UsernameTextBox.Text) || String.IsNullOrWhiteSpace(PasswordTextBox.Text) || String.IsNullOrWhiteSpace(RetypePasswordTextbox.Text) || String.IsNullOrWhiteSpace(FullNameTextBox.Text))
            {
                MessageBox.Show("Input can't be empty.");
                return;
            }
            if (PasswordTextBox.Text != RetypePasswordTextbox.Text)
            {
                MessageBox.Show("Password and ReType-Password is not equals.");
                return;
            }
            if (!TermsCheckBox.Checked)
            {
                MessageBox.Show("Please View Terms Document And Click Agree Conditions First.");
                return;
            }
            Global.accountID = Global.Register(UsernameTextBox.Text, FullNameTextBox.Text, PasswordTextBox.Text, BirthdayDateTimePicker.Value, (int)FamilyNumericUpDown.Value, MaleRadioButton.Checked).ID;
            new ManagementForm().Show();
            close = 2;
            Close();
            MessageBox.Show("OK");
        }
    }
}

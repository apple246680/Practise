using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Session1
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }
        private void ReturnLoginBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(UsernameTextBox.Text) || String.IsNullOrWhiteSpace(PasswordTextBox.Text) || String.IsNullOrWhiteSpace(RetypePasswordTextBox.Text) || String.IsNullOrWhiteSpace(FullNameTextBox.Text))
            {
                MessageBox.Show("Input can't be empty.");
                return;
            }
            if (PasswordTextBox.Text != RetypePasswordTextBox.Text)
            {
                MessageBox.Show("Password and ReType-Password is not equals.");
                return;
            }
            if (!TermsCheckBox.Checked)
            {
                MessageBox.Show("Please View Terms Document And Click Agree Conditions First.");
                return;
            }
            var user = Global.register(UsernameTextBox.Text, FullNameTextBox.Text, PasswordTextBox.Text, BirthdayDateTimePicker.Value, (int)FamilyNumericUpDown.Value, MaleRadioButton.Checked);
            MessageBox.Show("OK");
            Global.accountID = user.ID;
            new ManagementForm().Show();
            Close();
        }
        private void ViewTermsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Visible = false;
            new ViewTerms().ShowDialog();
            TermsCheckBox.Enabled = true;
            Visible = true;
        }
    }
}

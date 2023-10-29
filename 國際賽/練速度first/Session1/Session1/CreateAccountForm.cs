using System;
using System.Windows.Forms;
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
            Global.accountID = Global.register(UsernameTextBox.Text, FullNameTextBox.Text, PasswordTextBox.Text, BirthdayDateTimePicker.Value, (int)FamilyNumericUpDown.Value, MaleRadioButton.Checked).ID;
            new ManagementForm().Show();
            Close();
            MessageBox.Show("OK");
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
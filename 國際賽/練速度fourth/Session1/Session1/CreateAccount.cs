using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public partial class CreateAccount : UserControl
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void ReturnLoginFormBtn_Click(object sender, EventArgs e)
        {
            Global.ShowLoginForm();
        }

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
            Global.userID = Global.Register(UsernameTextBox.Text, FullNameTextBox.Text, PasswordTextBox.Text, BirthdayDateTimePicker.Value, (int)FamilyNumericUpDown.Value, MaleRadioButton.Checked).ID;
            Global.ShowManagementForm();
            MessageBox.Show("OK");
        }
    }
}

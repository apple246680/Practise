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

        private void CreateAccountLabel_Click(object sender, EventArgs e)
        {
            Global.ShowTermsForm();
            AgreeTermsCheckBox.Enabled = true;
        }

        private void ReturnLoginButton_Click(object sender, EventArgs e)
        {
            Global.ShowLoginForm();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                Global.LoginUser=Global.Register(UsernameTextBox.Text,FullNameTextbox.Text,PasswordTextBox.Text,MaleRadioButton.Checked,BirthdayDateTimePicker.Value,(int)FamilyNumericUpDown.Value).ID;
                Global.ShowManagementForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

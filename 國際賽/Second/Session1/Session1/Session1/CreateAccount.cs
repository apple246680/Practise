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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
            Init();
        }
        public void Init()
        {
            UsernameTextbox.Text = string.Empty;
            FullNameTextbox.Text = string.Empty;
            BirthdayDateTimePicker.CustomFormat = " ";
            PasswordTextbox.Text = string.Empty;
            RetypePasswordTextbox.Text = string.Empty;
            FamilyNumberNumericUpDown.Value=0;  
            MaleRadioButton.Checked = true;
            AgreeUELACheckBox.Enabled = false;
        }
        private void BackLoginBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void UELALinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EULA eULA = new EULA();
            Visible = false;
            eULA.ShowDialog();
            AgreeUELACheckBox.Enabled = true;
            Visible=true;
        }
        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (PasswordTextbox.Text.Length<=5)
            {
                MessageBox.Show("password length <=5");
                return;
            }
            if (String.IsNullOrWhiteSpace(UsernameTextbox.Text) || String.IsNullOrWhiteSpace(PasswordTextbox.Text) || String.IsNullOrWhiteSpace(RetypePasswordTextbox.Text) || String.IsNullOrWhiteSpace(FullNameTextbox.Text))
            {
                MessageBox.Show("Input can't be empty.");
                return;
            }
            if (!AgreeUELACheckBox.Checked)
            {
                MessageBox.Show("Please View Terms Document And Click Agree Conditions First.");
                return;
            }
            if (PasswordTextbox.Text==RetypePasswordTextbox.Text)
            {
                var user=Global.register(UsernameTextbox.Text,FullNameTextbox.Text,BirthdayDateTimePicker.Value,PasswordTextbox.Text,MaleRadioButton.Checked,(int)FamilyNumberNumericUpDown.Value);
                MessageBox.Show("OK");
                Global.accountID = user.ID;
                Management management = new Management();
                Close();
                Global.login.Visible = false;
                management.Show();
            }
            else
            {
                MessageBox.Show("errpr");
            }

        }
    }
}

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
            int a=0;
        }
    }
}

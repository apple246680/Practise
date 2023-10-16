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

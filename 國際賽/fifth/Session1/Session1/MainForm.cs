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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Global.mainForm= this;
            InitializeComponent();
        }
        private void CreateLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Visible=false;
            var CreateAccountform = new CreateAccountForm().ShowDialog();
            if (CreateAccountform == DialogResult.Cancel)
            Visible = true;
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            Visible = false;
            new ManagementForm().Show();
        }
    }
}

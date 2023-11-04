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
        public CreateAccountForm()
        {
            InitializeComponent();
        }
        int close = 1;

        private void button_Down(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(229, 26, 46);
        }

        private void button_Up(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(85, 85, 85);
        }

        private void TermsLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Visible = false;
            new TermsForm().ShowDialog();
            TermsCheckBox.Enabled = true;
            Visible = true;
        }

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
        private void ReturnLoginFormBtn_Click(object sender, EventArgs e)
        {
            close = 2;
            CreateAccountForm_FormClosing(null,null);
        }
    }
}

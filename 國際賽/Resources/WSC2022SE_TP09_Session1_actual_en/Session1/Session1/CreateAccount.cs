using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
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
            thisclose = true;
        }
        bool thisclose;
        private void View_Click(object sender, EventArgs e)
        {
            ViewForm viewForm = new ViewForm();
            viewForm.ShowDialog();
            Agree.Enabled = true;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            thisclose = false;
            Close();
        }

        private void CreateAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (thisclose)
                Global.login.Close();
            else
            {
                Global.login.Visible = true;
                Login.init();
            }
        }

        private void Register_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Username.Text)|| String.IsNullOrWhiteSpace(Password.Text)|| String.IsNullOrWhiteSpace(RetypePassword.Text)|| String.IsNullOrWhiteSpace(FullName.Text))
            {
                MessageBox.Show("Input can't be empty.");
                return;
            }
            if (Password.Text!=RetypePassword.Text)
            {
                MessageBox.Show("Password and ReType-Password is not equals.");
                return;
            }
            if (!Agree.Checked)
            {
                MessageBox.Show("Please View Terms Document And Click Agree Conditions First.");
                return;
            }
            var user = Global.register(Username.Text,FullName.Text,Password.Text,Birthday.Value,(int)Family.Value,Male.Checked);
            MessageBox.Show("OK");
            Global.accountID = user.ID;
            Management management = new Management();
            thisclose = false;
            Close();
            Global.login.Visible = false;
            management.Show();
        }
    }
}

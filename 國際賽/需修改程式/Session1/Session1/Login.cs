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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CreateAccountLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Global.MainForm.Controls.Clear();
            var createAccount = new CreateAccount() { Dock = DockStyle.Fill };
            Global.MainForm.Controls.Add(createAccount);
            createAccount.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ShowManagement()
        {
            var management = new Management() { Dock = DockStyle.Fill };
            Global.MainForm.Controls.Clear();
            Global.MainForm.Controls.Add(management);
            management.Show();

        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var entities = new Session1Entities();
            if (Global.userID.HasValue)
            {
                ShowManagement();
                return;
            }
            if (!string.IsNullOrWhiteSpace(EmployeeTextbox.Text))
            {
                var user = entities.Users.SingleOrDefault(x=>x.Username==EmployeeTextbox.Text && x.UserTypeID == 1);
                if (user == null)
                {
                    MessageBox.Show("Employee is wrong.");
                    return;
                }
                if (!string.IsNullOrWhiteSpace(UserTextbox.Text))
                {
                    if (!entities.Users.Any(x=>x.Username==UserTextbox.Text&&x.UserTypeID==2))
                    {
                        MessageBox.Show("Employee username is wrong.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Username cannot white.");
                    return;
                }
                Global.userID = user.ID;
            }
            else
            {

            }
        }
    }
}

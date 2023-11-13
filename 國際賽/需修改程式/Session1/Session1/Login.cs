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

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var entities = new Session1Entities();
            if (Global.userID.HasValue)
            {
                Global.ShowManagement();
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
                if (user.Password!=PasswordTextbox.Text)
                {
                    MessageBox.Show("Password is wrong");
                }
                Global.userID = user.ID;
            }
            else
            {
                var user = entities.Users.SingleOrDefault(x => x.Username == UserTextbox.Text);
                if (user == null)
                {
                    MessageBox.Show("Username is wrong");
                    return;
                }
                if (user.Password != PasswordTextbox.Text)
                {
                    MessageBox.Show("Password is wrong");
                    return;
                }
                Global.userID = user.ID;
            }
            if (KeepMeSignedInCheckbox.Checked)
            {
                Properties.Settings.Default.KeepLogin = Global.userID.ToString();
            }
            else
            {
                Properties.Settings.Default.KeepLogin = "";
            }
            Properties.Settings.Default.Save();
            Global.ShowManagement();
            MessageBox.Show("Success!");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.KeepLogin!="")
            {
                Global.userID = long.Parse(Properties.Settings.Default.KeepLogin);
                LoginBtn_Click(null,null);
            }
        }
    }
}

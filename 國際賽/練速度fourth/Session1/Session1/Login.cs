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

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextbox.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateAccountLabel_Click(object sender, EventArgs e)
        {
            Global.main.Controls.Clear();
            Global.main.Controls.Add(new CreateAccount() {Dock=DockStyle.Fill});
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.KeepLogin!="")
            {
                Global.userID = int.Parse(Properties.Settings.Default.KeepLogin);
                LoginButton_Click(null,null);
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var entities = new Session1Entities();
            if (Global.userID.HasValue)
            {
                Global.ShowManagementForm();
                return;
            }
            if (!string.IsNullOrWhiteSpace(EmployeeTextbox.Text))
            {
                var user = entities.Users.SingleOrDefault(x=>x.Username==EmployeeTextbox.Text&&x.UserTypeID==1);
                if (user == null)
                {
                    MessageBox.Show("Employee is wrong.");
                    return;
                }
                if (!string.IsNullOrWhiteSpace(UserTextbox.Text))
                {
                    if (entities.Users.Any(x=>x.Username==UserTextbox.Text&&x.UserTypeID==1))
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
                    return;
                }
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
            }
            Global.userID = entities.Users.Single(x => x.Username == UserTextbox.Text).ID; ;
            if (KeepSignedCheckBox.Checked)
            {
                Properties.Settings.Default.KeepLogin = Global.userID.ToString();
            }
            else
            {
                Properties.Settings.Default.KeepLogin = "";
            }
            Properties.Settings.Default.Save();
            Global.ShowManagementForm();
            MessageBox.Show("Success!");
        }
    }
}

using System;
using System.Linq;
using System.Windows.Forms;

namespace Session1
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
            PasswordTextbox.UseSystemPasswordChar = true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ShowPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextbox.UseSystemPasswordChar=!ShowPasswordCheckbox.Checked;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.KeepSigned!="")
            {
                Global.LoginUser = long.Parse(Properties.Settings.Default.KeepSigned);
                Global.ShowManagementForm();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var entities = new Session1Entities();
            var user = entities.Users.FirstOrDefault(x=>x.Username==UserTextbox.Text&&x.UserTypeID==2);
            if (!string.IsNullOrWhiteSpace(EmployeeTextbox.Text))
            {
                var employee = entities.Users.FirstOrDefault(x => x.Username == EmployeeTextbox.Text && x.UserTypeID == 1);
                if (employee!=null)
                {
                    if (user==null)
                    {
                        MessageBox.Show("No found Employee's user.");
                        return;
                    }
                    if (employee.Password!=PasswordTextbox.Text)
                    {
                        MessageBox.Show("Employee passord is wrong.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("No found Employee.");
                    return;
                }
            }
            else
            {
                if (user == null)
                {
                    MessageBox.Show("No found user.");
                    return;
                }
                if (user.Password != PasswordTextbox.Text)
                {
                    MessageBox.Show("User passord is wrong.");
                    return;
                }
            }
            Global.LoginUser = user.ID;
            Global.ShowManagementForm();
        }

        private void CreateAccountLabel_Click(object sender, EventArgs e)
        {
            Global.ShowCreateAccountForm();
        }
    }
}
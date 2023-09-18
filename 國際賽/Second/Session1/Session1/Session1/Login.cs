using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
namespace Session1
{
    public partial class Login : Form
    {
        public Login()
        {
            Global.login = this;
            InitializeComponent();
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Session1Entities entities = new Session1Entities();
            if (!string.IsNullOrEmpty(EmpTextBox.Text))
            {
                var user = entities.Users.SingleOrDefault(x=>x.Username==EmpTextBox.Text&&x.Password==PasswordTextBox.Text&&x.UserTypeID==1);
                if (user == null)
                {
                    MessageBox.Show("Employee naem or password is wrong.");
                    return;
                }
                Global.accountID = user.ID;
            }
            else
            {
                var user = entities.Users.SingleOrDefault(x => x.Username == UserTextBox.Text && x.Password == PasswordTextBox.Text && x.UserTypeID == 2);
                if (user == null)
                {
                    MessageBox.Show("Username or password is wrong.");
                    return;
                }
                Global.accountID = user.ID;
            }
            if (KeepSign.Checked)
                Properties.Settings.Default.KeepLogin = Global.accountID.ToString();
            else
                Properties.Settings.Default.KeepLogin = "";
            Properties.Settings.Default.Save();
            Visible = false;
            MessageBox.Show("Success!");
        }
        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar=!ShowPassword.Checked;
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Properties.Settings.Default.KeepLogin))
            {
                Global.accountID = Convert.ToInt32(Properties.Settings.Default.KeepLogin);
                LoginBtn_Click(sender, e);
            }
        }

        private void Create_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            Visible=false;
            createAccount.ShowDialog();
            Visible = true;
        }
    }
}

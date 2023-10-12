using System;
using System.Linq;
using System.Windows.Forms;
namespace Session1
{
    public partial class Login : Form
    {
        public Login()
        {
            Global.login = this;
            InitializeComponent();
            if (!String.IsNullOrEmpty(Properties.Settings.Default.KeepLogin))
            {
                Global.accountID = int.Parse(Properties.Settings.Default.KeepLogin);
                LoginBtn_Click(null, null);
            }
        }
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Session1Entities entities = new Session1Entities();
            if (Global.accountID.HasValue)
            {
                Visible = false;
                new Management().ShowDialog();
                return;
            }
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
                Properties.Settings.Default.KeepLogin = null;
            Properties.Settings.Default.Save();
            Visible = false;
            MessageBox.Show("Success!");
            new Management().ShowDialog();
            Visible = true;
        }
        private void ShowPassword_CheckedChanged(object sender, EventArgs e)=>PasswordTextBox.UseSystemPasswordChar=!ShowPassword.Checked;
        public void ExitBtn_Click(object sender, EventArgs e)=>Close();
        private void Create_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Visible= false;
            new CreateAccount().ShowDialog();
            Visible = true;
        }
    }
}

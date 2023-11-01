using System;
using System.Linq;
using System.Windows.Forms;
namespace Session1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Global.mainForm= this;
        }
        private void CreateLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPasswordCheckBox.Focus();
            Visible=false;
            var CreateAccountform = new CreateAccountForm().ShowDialog();
            if (CreateAccountform == DialogResult.Cancel)
            Visible = true;
        }
        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = !ShowPasswordCheckBox.Checked;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {

            var management = new ManagementForm();
            Session1Entities entities = new Session1Entities();
            if (Global.accountID.HasValue)
            {
                Visible = false;
                management.Show();
                return;
            }
            if (!string.IsNullOrEmpty(EmployeeTextBox.Text))
            {
                var user = entities.Users.SingleOrDefault(x => x.Username == EmployeeTextBox.Text && x.Password == PasswordTextBox.Text && x.UserTypeID == 1);
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
            if (KeepSignCheckBox.Checked)
                Properties.Settings.Default.KeepLogin = Global.accountID.ToString();
            else
                Properties.Settings.Default.KeepLogin = "";
            Properties.Settings.Default.Save();
            Visible = false;
            MessageBox.Show("Success!");
            management.Show();
        }
    }
}
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
    public partial class LoginForm : Form
    {
        /// <summary>
        /// InitializeComponent LoginForm
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            Global.LoginForm = this;
        }
        /// <summary>
        /// button style
        /// </summary>
        private void button_Down(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(229,26,46);
        }
        /// <summary>
        /// button style
        /// </summary>
        private void button_Up(object sender, MouseEventArgs e)
        {
            ((Button)sender).ForeColor = Color.FromArgb(85, 85, 85);
        }
        /// <summary>
        /// Go to CreateAccountForm
        /// </summary>
        private void CreateAccountLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Visible=false;
            new CreateAccountForm().Show();
        }
        /// <summary>
        /// Is Showpassword
        /// </summary>
        private void ShowPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextbox.UseSystemPasswordChar = !ShowPasswordCheckbox.Checked;
        }
        /// <summary>
        /// Exit the Application
        /// </summary>
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Login the Application
        /// </summary>
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var management = new ManagementForm();
            Session1Entities entities = new Session1Entities();
            if (Global.accountID.HasValue)
            {
                Visible = false;
                management.Show();
                return;
            }
            if (!string.IsNullOrEmpty(EmployeeTextbox.Text))
            {
                var user = entities.Users.SingleOrDefault(x => x.Username == EmployeeTextbox.Text && x.Password == PasswordTextbox.Text && x.UserTypeID == 1);
                if (user == null)
                {
                    MessageBox.Show("Employee naem or password is wrong.");
                    return;
                }
                Global.accountID = user.ID;
            }
            else
            {
                var user = entities.Users.SingleOrDefault(x => x.Username == UserTextbox.Text && x.Password == PasswordTextbox.Text && x.UserTypeID == 2);
                if (user == null)
                {
                    MessageBox.Show("Username or password is wrong.");
                    return;
                }
                Global.accountID = user.ID;
            }
            if (KeepMeSignedInCheckbox.Checked)
            {
                Properties.Settings.Default.KeepLogin = Global.accountID.ToString();
            }
            else
            {
                Properties.Settings.Default.KeepLogin = "";
            }
            Properties.Settings.Default.Save();
            Visible = false;
            MessageBox.Show("Success!");
            management.Show();
        }
    }
}

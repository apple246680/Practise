using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public partial class Login : UserControl
    {
        /// <summary>
        /// InitializeComponent Login Form
        /// </summary>
        public Login()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Exit the Application
        /// </summary>
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Show Password or Hide Password
        /// </summary>
        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTextbox.UseSystemPasswordChar = !ShowPassword.Checked;
        }
        /// <summary>
        /// Judge Have KeepLogin Account
        /// </summary>
        private void Login_Load(object sender, EventArgs e)
        {
            Global.userID = Properties.Settings.Default.KeepLogin == ""?0:long.Parse(Properties.Settings.Default.KeepLogin);
            LoginButton_Click(null, null);
        }
        /// <summary>
        /// Login
        /// </summary>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (Global.userID!=0)
            {
                Global.ShowManagementForm();
                return;
            }
            var entities = new Session1Entities();
            Users user=new Users();
            if (!string.IsNullOrWhiteSpace(EmployeeTextBox.Text))
            {
                var EmpUser = entities.Users.FirstOrDefault(x=>x.Username==EmployeeTextBox.Text&&x.UserTypeID==1);
                if (user == null) 
                {
                    entities.LogRecords.Add(new LogRecords  
                    {
                        GUID = Guid.NewGuid(),
                        FormName = "Login",
                        Task = "unsuccessful",
                        UsersID = Global.userID,
                        LogDT = DateTime.Now
                    });
                    entities.SaveChanges();
                    MessageBox.Show("No found employee.");
                    return;
                }
                user = entities.Users.FirstOrDefault(x=>x.Username==UserTextBox.Text&&x.UserTypeID==2);
                if (user == null)
                {
                    entities.LogRecords.Add(new LogRecords
                    {
                        GUID = Guid.NewGuid(),
                        FormName = "Login",
                        Task = "unsuccessful",
                        UsersID = Global.userID,
                        LogDT = DateTime.Now
                    });
                    entities.SaveChanges();
                    MessageBox.Show("No found user");
                    return;
                }
                if (EmpUser.Password!=PasswordTextbox.Text)
                {
                    entities.LogRecords.Add(new LogRecords
                    {
                        GUID = Guid.NewGuid(),
                        FormName = "Login",
                        Task = "unsuccessful",
                        UsersID = Global.userID,
                        LogDT = DateTime.Now
                    });
                    MessageBox.Show("Employee password error.");
                    entities.SaveChanges();
                    return;
                }
            }
            else if(!string.IsNullOrWhiteSpace(UserTextBox.Text))
            {
                user = entities.Users.FirstOrDefault(x => x.Username == UserTextBox.Text && x.UserTypeID == 2);
                if (user == null)
                {
                    entities.LogRecords.Add(new LogRecords
                    {
                        GUID = Guid.NewGuid(),
                        FormName = "Login",
                        Task = "unsuccessful",
                        UsersID = Global.userID,
                        LogDT = DateTime.Now
                    });
                    entities.SaveChanges();
                    MessageBox.Show("No found user");
                    return;
                }
                if (user.Password != PasswordTextbox.Text)
                {
                    entities.LogRecords.Add(new LogRecords
                    {
                        GUID = Guid.NewGuid(),
                        FormName = "Login",
                        Task = "unsuccessful",
                        UsersID = Global.userID,
                        LogDT = DateTime.Now
                    });
                    entities.SaveChanges();
                    MessageBox.Show("User password error.");
                    return;
                }
            }
            if (KeepSignedCheckbox.Checked)
            {
                Properties.Settings.Default.KeepLogin = user.ID.ToString();
                Properties.Settings.Default.Save();
            }
            if (user.ID!=0)
            {
                Global.userID=user.ID;
                entities.LogRecords.Add(new LogRecords
                {
                    GUID=Guid.NewGuid(),
                    FormName="Login",
                    Task= "Successful",
                    UsersID= Global.userID,
                    LogDT=DateTime.Now
                });
                entities.SaveChanges();
                Global.ShowManagementForm();
                MessageBox.Show("Successful");
            }
        }
        /// <summary>
        /// Show Create Account Form
        /// </summary>
        private void CreateLabel_Click(object sender, EventArgs e)
        {
            var createAccount=new CreateAccount() {Dock=DockStyle.Fill};
            Global.MainForm.Controls.Clear();
            Global.MainForm.Controls.Add(createAccount);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public static class Global
    {
        public static Main MainForm { get; set; }
        public static long? userID { get; set; }
        /// <summary>
        /// Register Account
        /// </summary>
        public static Users Register(string Username,string FullName,DateTime Birthday,string Password,bool Gender,int FamilyCount)
        {
            if (Password.Length<5)
            {
                throw new Exception("Password Length need 5");
            }
            var entities = new Session1Entities();
            if (entities.Users.Any(x=>x.Username==Username))
            {
                throw new Exception("User is exit");
            }
            var user = entities.Users.Add(new Users
            {
                GUID=Guid.NewGuid(),
                UserTypeID=2,
                Username=Username,
                Password=Password,
                HashPassword= ComputeSha256Hash(Password),
                FullName=FullName,
                Gender=Gender,
                FamilyCount=FamilyCount,
                BirthDate=Birthday.Date,
            });
            entities.SaveChanges();
            return user;
        }
        /// <summary>
        /// Show Login Form
        /// </summary>
        public static void ShowLoginForm()
        {
            var login = new Login() { Dock = DockStyle.Fill };
            MainForm.Text = "Seoul Stay - Welcome";
            MainForm.Controls.Clear();
            MainForm.Controls.Add(login);
        }
        /// <summary>
        /// Show Management Form
        /// </summary>
        public static void ShowManagementForm()
        {
            var management = new Management() { Dock = DockStyle.Fill };
            MainForm.Text = "Seoul Stay - Management";
            MainForm.Controls.Clear();
            MainForm.Controls.Add(management);
        }
        /// <summary>
        /// Sha256 hash password
        /// </summary>
        public static string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}

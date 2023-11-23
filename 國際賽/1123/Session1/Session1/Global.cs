using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Session1
{
    public class Global
    {
        public static Main Main { get; set; }
        public static long? LoginUser { get; set; }
        public static void ShowLoginForm()
        {
            Main.Text = "Seoul Stay - Welcome";
            Main.Controls.Clear();
            Main.Controls.Add(new Login { Dock = DockStyle.Fill });
        }
        public static void ShowCreateAccountForm()
        {
            Main.Text = "Seoul Stay - Create Account";
            Main.Controls.Clear();
            Main.Controls.Add(new CreateAccount { Dock = DockStyle.Fill });
        }
        public static void ShowManagementForm()
        {
            Main.Text = "Seoul Stay - Management";
            Main.Controls.Clear();
            Main.Controls.Add(new Management { Dock = DockStyle.Fill });
        }
        public static void ShowTermsForm()
        {
            Main.Text = "Seoul Stay - Terms";
            Main.Controls.Clear();
            Main.Controls.Add(new Terms { Dock = DockStyle.Fill });
        }
        public static User Register(string Username, string Fullname, string Password, bool Gender, DateTime birthday, int FamilyCount)
        {
            var entities = new Session1Entities();
            if (string.IsNullOrWhiteSpace(Username)||string.IsNullOrWhiteSpace(Fullname)||string.IsNullOrWhiteSpace(Password)||string.IsNullOrWhiteSpace(Gender.ToString())||string.IsNullOrWhiteSpace(birthday.ToString())||string.IsNullOrWhiteSpace(FamilyCount.ToString()))
            {
                throw new Exception("Some key is blank.");
            }
            if (entities.Users.Any(x=>x.Username==Username))
            {
                throw new Exception("Register account already exists.");
            }
            if (Password.Length<5)
            {
                throw new Exception("Password length <5.");
            }
            var user = entities.Users.Add(new User
            {
                Username = Username,
                FullName = Fullname,
                Password = Password,
                Gender = Gender,
                HashPassword = Hash256(Password),
                BirthDate = birthday.Date,
                FamilyCount = FamilyCount,
                UserTypeID=2,
                GUID=Guid.NewGuid(),    
            });
            entities.SaveChanges();
            return user;
        }
        public static string Hash256(string Password)
        {
            var stringbuild = new StringBuilder();
            using (var hash = SHA256.Create())
            {
                foreach (var hashsomekey in hash.ComputeHash(Encoding.UTF8.GetBytes(Password)).ToList())
                {
                    stringbuild.Append(hashsomekey.ToString("x2"));
                };
            }
            return stringbuild.ToString();
        }
    }
}

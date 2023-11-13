using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session1
{
    public class Global
    {
        public static Main main { get; set; }
        public static long? userID {  get; set; }
        public static long? AddItemID { get; set; }
        public static Users Register(string Username,string FullName,string Password,DateTime Birthday,int FamilyCount,bool Gender)
        {
            var entities = new Session1Entities();
            if (entities.Users.Any(x=>x.Username==Username))
            {
                throw new ArgumentException("Username is exits.");
            }
            if (Password.Length<5)
            {
                throw new AggregateException("Password length need least five.");
            }
            var user = entities.Users.Add(new Users
            {
                GUID=Guid.NewGuid(),
                Username=Username,
                FullName=FullName,
                Password=Password,
                Gender=Gender,
                BirthDate=Birthday,
                FamilyCount=FamilyCount,
                UserTypeID=2
            });
            entities.SaveChanges();
            return user;
        }
        public static void ShowLoginForm()
        {
            main.Controls.Clear();
            main.Controls.Add(new Login() { Dock = DockStyle.Fill });
        }
        public static void ShowManagementForm() 
        {
            main.Controls.Clear();
            main.Controls.Add(new Management() { Dock = DockStyle.Fill });
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Session1;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Session1UnitTestProject
{
    [TestClass]
    public class RegisterUnitTest
    {
        /// <summary>
        /// Test Register
        /// </summary>
        [TestMethod]
        public void RegisterTest()
        {
            string Username = "aaa";
            string Password = "12345";
            string FullName = "132";
            bool Gender=true;
            int FamilyCount = 0;
            DateTime Birthday = DateTime.Now;
            var entities = new Session1Entities();
            if (entities.Users.Any(x => x.Username == Username))
            {
                Assert.Fail("This account already exists");
            }
            if (Password.Length < 5)
            {
                Assert.Fail("Password length does not meet the requirements.");
            }
            if (string.IsNullOrWhiteSpace(Username)||string.IsNullOrWhiteSpace(Password)|| string.IsNullOrWhiteSpace(FullName))
            {
                Assert.Fail("Some key fields are left blank");
            }
            var user = entities.Users.Add(new Users
            {
                GUID = Guid.NewGuid(),
                UserTypeID = 2,
                Username = Username,
                Password= Password,
                HashPassword = Global.ComputeSha256Hash(Password),
                FullName = FullName,
                Gender = Gender,
                FamilyCount = FamilyCount,
                BirthDate = Birthday.Date,
            });
            try
            {
                entities.SaveChanges();
            }
            catch (Exception e)
            {
                Assert.IsFalse(entities.Users.Any(x=>x.Username == Username), "Failed to add account");
            }
            entities.Users.Remove(user);
            entities.SaveChanges();
        }
        
    }
}

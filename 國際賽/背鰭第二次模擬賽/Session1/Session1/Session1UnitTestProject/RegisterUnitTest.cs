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
                Assert.Fail("The account has been successfully added.");
            }
            if (Password.Length < 5)
            {
                Assert.Fail("Password length does not meet the requirements.");
            }
            if (string.IsNullOrWhiteSpace(Username)||string.IsNullOrWhiteSpace(Password)|| string.IsNullOrWhiteSpace(FullName))
            {
                Assert.Fail("Some key fields are left blank");
            }
            var user = entities.Users.Add(new User
            {
                GUID = Guid.NewGuid(),
                UserTypeID = 2,
                Username = Username,
                Password = Global.ComputeSha256Hash(Password),
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
                Assert.Fail(e.Message);
            }
            entities.Users.Remove(user);
            entities.SaveChanges();
        }
        
    }
}

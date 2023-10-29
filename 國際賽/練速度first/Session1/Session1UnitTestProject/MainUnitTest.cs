using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Session1;
using System.Linq;
namespace Session1UnitTestProject
{
    [TestClass]
    public class MainUnitTest
    {
        [TestMethod]
        public void TestUserRegister()
        {
            string username = "test";
            string password = "test123";
            string fullname = "test test";
            DateTime birthdaty = DateTime.Now.Date;
            int familyCount = 1;
            var user = Global.register(username, fullname, password, birthdaty, familyCount, true);
            using (Session1Entities entities = new Session1Entities())
            {
                user = entities.Users.SingleOrDefault(t => t.ID == user.ID);
                Assert.IsTrue(user != null, "Register user is not found.");
                Assert.IsTrue(user.Username == username, "Register user Username value different.");
                Assert.IsTrue(user.Password == password, "Register Password value different.");
                Assert.IsTrue(user.FullName == fullname, "Register FullName value different.");
                Assert.IsTrue(user.Gender == true, "Register Gender value different.");
                Assert.IsTrue(user.BirthDate == birthdaty, "Register BirthDate value different.");
                Assert.IsTrue(user.FamilyCount == familyCount, "Register FamilyCount value different.");
                entities.Users.Remove(entities.Users.SingleOrDefault(t => t.ID == user.ID));
                entities.SaveChanges();
            }
        }
    }
}

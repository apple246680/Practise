using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Session1Entities entities = new Session1Entities();
            var aa = entities.Users.SingleOrDefault(t => t.Username == "test");
            if (aa != null)
            {
                throw new ArgumentException("Username is exists.");
            }
            var user=entities.Users.Add(new Users
            {
                GUID = Guid.NewGuid(),
                Username = "test",
                Password = "test123",
                BirthDate = DateTime.Now.Date,
                FullName = "test test",
                FamilyCount = 0,
                Gender = true,
                UserTypeID = 2
            });
            entities.SaveChanges();
            entities = new Session1Entities();
            var users = entities.Users.SingleOrDefault(t => t.ID == user.ID);
            Assert.IsTrue(users != null, "Register user is not found.");
            Assert.IsTrue(users.Username == "test", "Register user Username value different.");
            Assert.IsTrue(users.Password == "test123", "Register Password value different.");
            Assert.IsTrue(users.FullName == "test test", "Register FullName value different.");
            Assert.IsTrue(users.Gender == true, "Register Gender value different.");
            Assert.IsTrue(users.BirthDate == DateTime.Now.Date, "Register BirthDate value different.");
            Assert.IsTrue(users.FamilyCount == 0, "Register FamilyCount value different.");
            entities.Users.Remove(entities.Users.SingleOrDefault(t => t.ID == users.ID));
            entities.SaveChanges();
        }
    }
}

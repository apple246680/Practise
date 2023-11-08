using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Session3;
using System.Linq;

namespace Session3UnitTestProject
{
    [TestClass]
    public class Session3UnitTest
    {
        /// <summary>
        /// Test User can Register?
        /// </summary>
        [TestMethod]
        [DataRow("dadada", "dadada", "dadadad", true, 1)]
        [DataRow("aagag", "aagag", "aagag", true, 1)]
        [DataRow("aaa", "12345", "Min-Seo Young-Ho", true, 1)]
        public void TestUserRegister(string username, string password, string fullname, bool gender, int familyCount)
        {
            var birthday = DateTime.Today;
            Users user;
            try
            {
                user = GlobalClass.Register(username, fullname, password, birthday, familyCount, gender);
                using (var entities = new Session3Entities())
                {
                    user = entities.Users.SingleOrDefault(t => t.ID == user.ID);
                    Assert.IsTrue(user != null, "Register user is not found.");
                    Assert.IsTrue(user.Username == username, "Register user Username value different.");
                    Assert.IsTrue(user.Password == password, "Register Password value different.");
                    Assert.IsTrue(user.FullName == fullname, "Register FullName value different.");
                    Assert.IsTrue(user.Gender == gender, "Register Gender value different.");
                    Assert.IsTrue(user.BirthDate == birthday, "Register BirthDate value different.");
                    Assert.IsTrue(user.FamilyCount == familyCount, "Register FamilyCount value different.");
                    entities.Users.Remove(entities.Users.SingleOrDefault(t => t.ID == user.ID));
                    entities.SaveChanges();
                }
            }
            catch (ArgumentException ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test ItemScore
        /// </summary>
        [TestMethod]
        public void TestItemScore()
        {
            try
            {
                GlobalClass.CheckScore();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test ItemAvailableDate
        /// </summary>
        [TestMethod]
        public void TestItemAvailableDate()
        {
            try
            {
                GlobalClass.CheckItemDate();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}

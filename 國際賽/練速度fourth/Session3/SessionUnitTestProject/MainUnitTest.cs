using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Session3;
using System.Runtime.ConstrainedExecution;
using System.Data.Entity;
using System.Linq;

namespace SessionUnitTestProject
{
    [TestClass]
    public class MainUnitTest
    {
        [TestMethod]
        [DataRow("aaaaa", "aaaaa", "aaaaa",true,1)]
        [DataRow("bbbbb", "bbbbb", "bbbbb", false, 1)]
        [DataRow("ccccc", "ccccc", "ccccc", true, 2)]
        public void TestUserRegister(string Username,string Password,string FullName,bool Gender,int FamilyCount)
        {
            var birthday = DateTime.Today;
            User user;
            try
            {
                user = Global.Register(Username,Password,FullName,birthday,Gender,FamilyCount);
                var entities = new Session3Entities();
                user = entities.Users.SingleOrDefault(t => t.ID == user.ID);
                Assert.IsTrue(user != null, "Register user is not found");
                Assert.IsTrue(user.Username==Username,"Register user Username value different.");
                Assert.IsTrue(user.Password == Password, "Register Password value different.");
                Assert.IsTrue(user.FullName == FullName, "Register FullName value different.");
                Assert.IsTrue(user.Gender == Gender, "Register Gender value different.");
                Assert.IsTrue(user.BirthDate == birthday, "Register BirthDate value different.");
                Assert.IsTrue(user.FamilyCount == FamilyCount, "Register FamilyCount value different.");
                entities.Users.Remove(user);
                entities.SaveChanges();
            }
            catch (Exception e)
            {
                Assert.Fail(e.Message);
            }
        }
        [TestMethod]
        public void TestItemAvailableDate()
        {
            try
            {
                Global.CheckItemDate();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        public void TestItemScore()
        {
            try
            {
                Global.CheckScore();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}

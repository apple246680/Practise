using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckScore()
        {
            try
            {
                Session3Entities entities = new Session3Entities();
                var itemsScore = entities.ItemScores.Where(t => t.Value > 5 || t.Value < 0).ToList();
                if (itemsScore.Count > 0)
                {
                    throw new Exception($"No score associated with any of the properties or listings should have higher score than 5 and lower score than 0." +
                        $"{Environment.NewLine}Error Data: {String.Join(Environment.NewLine, itemsScore.Select(t => $"ItemScoreId : {t.ID}  Value : {t.Value}"))}");
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        public void CheckItemDate()
        {
            try
            {
                Session3Entities entities = new Session3Entities();
                DateTime date = new DateTime(2017, 02, 19).Date;
                var items = entities.Items.Where(t => t.ItemPrices.Any(x => x.Date <= date)).ToList();
                if (items.Count > 0)
                {
                    throw new Exception($"No property or listing should have availabilities before 19/02/2017." +
                        $"{Environment.NewLine}Error Data : {String.Join(Environment.NewLine, items.Select(t => $"Item ID: {t.ID}"))}");
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        [TestMethod]
        [DataRow("dadada", "dadada", "dadadad", true, 1)]
        [DataRow("aagag", "aagag", "aagag", true, 1)]
        [DataRow("mahdi", "1234", "Min-Seo Young-Ho", true, 1)]
        public void TestUserRegister(string username, string password, string fullname, bool gender, int failyCount)
        {
            try
            {
                var date = DateTime.Now;
                Session3Entities entities = new Session3Entities();
                var user = entities.Users.SingleOrDefault(t => t.Username == username);
                if (user != null)
                    throw new ArgumentException("Username is exists.");
                if (password.Length < 5)
                    throw new ArgumentException("Password length need least five.");
                user = entities.Users.Add(new Users
                {
                    GUID = Guid.NewGuid(),
                    Username = username,
                    Password = password,
                    BirthDate = date,
                    FullName = fullname,
                    FamilyCount = failyCount,
                    Gender = gender,
                    UserTypeID = 2
                });
                entities.SaveChanges();
                user = entities.Users.SingleOrDefault(t => t.ID == user.ID);
                Assert.IsTrue(user != null, "Register user is not found.");
                Assert.IsTrue(user.Username == username, "Register user Username value different.");
                Assert.IsTrue(user.Password == password, "Register Password value different.");
                Assert.IsTrue(user.FullName == fullname, "Register FullName value different.");
                Assert.IsTrue(user.Gender == gender, "Register Gender value different.");
                Assert.IsTrue(user.BirthDate == date, "Register BirthDate value different.");
                Assert.IsTrue(user.FamilyCount == failyCount, "Register FamilyCount value different.");
                entities.Users.Remove(entities.Users.SingleOrDefault(t => t.ID == user.ID));
                entities.SaveChanges();
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Session2;
using System.Linq;
namespace Session2UnitTestProject
{
    [TestClass]
    public class Session2UnitTest
    {
        /// <summary>
        /// Test if any properties are available today
        /// </summary>
        [TestMethod]
        public void CheckItemDate()
        {
            try
            {
                var entities = new Session2Entities();
                DateTime date = DateTime.Now.Date;
                var items = entities.Items.Where(t => t.ItemPrices.Any(x => x.Date <= date)).ToList();
                if (items.Count > 0)
                {
                    throw new Exception($"No property or listing should have availabilities before {date.ToString("dd/MM/yyyy")}.\r\nError Data : \r\n{String.Join(Environment.NewLine, items.Select(t => $"Item ID: {t.ID}"))}");
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test have any Score higher 5 and lower 0
        /// </summary>
        [TestMethod]
        public void CheckScore()
        {
            try
            {
                var entities = new Session2Entities();
                var itemsScore = entities.ItemScores.Where(t => t.Value > 5 || t.Value < 0).ToList();
                if (itemsScore.Count > 0)
                {
                    throw new Exception($"No score associated with any of the properties or listings should have higher score than 5 and lower score than 0.\r\nError Data: \r\n{String.Join(Environment.NewLine, itemsScore.Select(t => $"ItemScoreId : {t.ID}  Value : {t.Value}"))}");
                }
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
        /// <summary>
        /// Test cannot duplicate register user
        /// </summary>
        [TestMethod]
        [DataRow("sirvard", "9090", "Nerses Sirvard", false, 5)]
        public void AccountAlreadyExists(string Username, string Password, string FullName, bool? Gender, int? Family)
        {
            var entities = new Session2Entities();
            if (entities.Users.Any(x => x.Username == Username))
            {
                return;
            }
            var user = entities.Users.Add(new User
            {
                GUID = Guid.NewGuid(),
                Username = Username,
                Password = Password,
                BirthDate = DateTime.Now,
                FullName = FullName,
                FamilyCount = Family.Value,
                Gender = Gender.Value,
                UserTypeID = 2
            });
            entities.SaveChanges();
            entities.Users.Remove(user);
            entities.SaveChanges();
            Assert.Fail("Register Account Successful");
        }
    }
}

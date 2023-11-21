using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Session1;
using System.Linq;
namespace Session1UnitTestProject
{
    [TestClass]
    public class RegisterUnitTest
    {
        /// <summary>
        /// Test Account can Register?
        /// </summary>
        [TestMethod]
        [DataRow("app", "12345", "12345", true, 0)]
        public void AccountBeenSuccessfullyAddedTest(string Username, string Password, string FullName, bool? Gender, int? Family)
        {
            var entities = new Session1Entities();
            if (entities.Users.Any(x => x.Username == Username)|| Password.Length < 5|| Username == "" || Password == "" || FullName == "" || !Gender.HasValue || !Family.HasValue)
            {
                return;
            }
            var user = entities.Users.Add(new Users
            {
                GUID = Guid.NewGuid(),
                Username = Username,
                Password = Password,
                BirthDate = DateTime.Now,
                FullName = FullName,
                FamilyCount = Family.Value,
                Gender = Gender.Value,
                UserTypeID = 2,
                HashPassword=Global.ComputeSha256Hash(Password)
            });
            entities.SaveChanges();
            entities.Users.Remove(user);
            entities.SaveChanges();
        }
        /// <summary>
        /// Test Account is already Exisits
        /// </summary>
        [TestMethod]
        [DataRow("sirvard", "9090", "Nerses Sirvard", false, 5)]
        public void AccountAlreadyExists(string Username, string Password, string FullName, bool? Gender, int? Family)
        {
            var entities = new Session1Entities();
            if (entities.Users.Any(x => x.Username == Username) || Password.Length < 5 || Username == "" || Password == "" || FullName == "" || !Gender.HasValue || !Family.HasValue)
            {
                return;
            }
            var user = entities.Users.Add(new Users
            {
                GUID = Guid.NewGuid(),
                Username = Username,
                Password = Password,
                BirthDate = DateTime.Now,
                FullName = FullName,
                FamilyCount = Family.Value,
                Gender = Gender.Value,
                UserTypeID = 2,
                HashPassword = Global.ComputeSha256Hash(Password)
            });
            entities.SaveChanges();
            entities.Users.Remove(user);
            entities.SaveChanges();
        }
        /// <summary>
        /// Test password length is less than 5
        /// </summary>
        [TestMethod]
        [DataRow("app", "9090", "Nerses", false, 5)]
        public void PasswordLengthNotNeetRequirements(string Username, string Password, string FullName, bool? Gender, int? Family)
        {
            var entities = new Session1Entities();
            if (entities.Users.Any(x => x.Username == Username) || Password.Length < 5 || Username == "" || Password == "" || FullName == "" || !Gender.HasValue || !Family.HasValue)
            {
                return;
            }
            var user = entities.Users.Add(new Users
            {
                GUID = Guid.NewGuid(),
                Username = Username,
                Password = Password,
                BirthDate = DateTime.Now,
                FullName = FullName,
                FamilyCount = Family.Value,
                Gender = Gender.Value,
                UserTypeID = 2,
                HashPassword = Global.ComputeSha256Hash(Password)
            });
            entities.SaveChanges();
            entities.Users.Remove(user);
            entities.SaveChanges();
        }
        /// <summary>
        /// Test whether the input value is blank
        /// </summary>
        [TestMethod]
        [DataRow("app", "90901", "", null, 5)]
        public void SomeKeyFieldsLeftBlank(string Username, string Password, string FullName, bool? Gender, int? Family)
        {
            var entities = new Session1Entities();
            if (entities.Users.Any(x => x.Username == Username) || Password.Length < 5 || Username == "" || Password == "" || FullName == "" || !Gender.HasValue || !Family.HasValue)
            {
                return;
            }
            var user = entities.Users.Add(new Users
            {
                GUID = Guid.NewGuid(),
                Username = Username,
                Password = Password,
                BirthDate = DateTime.Now,
                FullName = FullName,
                FamilyCount = Family.Value,
                Gender = Gender.Value,
                UserTypeID = 2,
                HashPassword = Global.ComputeSha256Hash(Password)
            });
            entities.SaveChanges();
            entities.Users.Remove(user);
            entities.SaveChanges();
        }
    }
}
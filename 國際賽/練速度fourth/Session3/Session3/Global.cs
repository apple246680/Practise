using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session3
{
    public class Global
    {
        public static User Register(string Username, string Password, string FullName,DateTime birthday, bool Gender, int FamilyCount)
        {
            var entities=new Session3Entities();
            var user = entities.Users.SingleOrDefault(x=>x.Username==Username);
            if (user != null)
            {
                throw new Exception("Username is exits.");
            }
            if (Password.Length<5)
            {
                throw new Exception("Password length need least five.");
            }
            user = entities.Users.Add(new User
            {
                Username=Username,
                Password=Password,
                FullName=FullName,
                GUID=Guid.NewGuid(),
                Gender=Gender,
                BirthDate=birthday,
                FamilyCount=FamilyCount,
                UserTypeID=2
            });
            entities.SaveChanges();
            return user;
        }
        public static void CheckItemDate()
        {
            var date=new DateTime(2017,02,19).Date;
            var items=new Session3Entities().Items.Where(x=>x.ItemPrices.Any(y=>y.Date<=date)).ToList();
            if (items.Count>0)
            {
                throw new Exception("Properties or listings should not be available before February 19, 2017." +
                    $"\r\nError Data : {string.Join("\r\n",items.Select(x=>$"Item ID: {x.ID}"))}");
            }
        }
        public static void CheckScore()
        {
            var itemScore=new Session3Entities().ItemScores.Where(x=>x.Value>5||x.Value<0).ToList();
            if (itemScore.Count>0) 
            {
                throw new Exception("Scores for all properties or listings must be between 0 and 5." +
                    $"\r\nError Data : {String.Join(Environment.NewLine, itemScore.Select(t => $"ItemScoreId : {t.ID}  Value : {t.Value}"))}");
            }
        }
    }
}

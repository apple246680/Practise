using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
{
    public static class Global
    {
        public static long? accountID;
        public static Login login;
        public static User register(string username,string fullname,DateTime birthdday,string password,bool gender,int count)
        {
            Session1Entities entities=new Session1Entities();
            if (password.Length<=5)
                throw new ArgumentException("password<=5");
            if (entities.Users.Any(x => x.Username == username))
                throw new ArgumentException("have account");
            entities.Users.Add(new User
            {
                GUID=Guid.NewGuid(),
                UserTypeID=2,
                Username=username,
                Password=password,
                FullName=fullname,
                Gender=gender,
                BirthDate=birthdday,
                FamilyCount=count
            });
            entities.SaveChanges();
        }
    }
}

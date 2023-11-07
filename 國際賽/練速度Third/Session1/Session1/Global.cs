﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
{
    public static class Global
    {
        public static LoginForm LoginForm { get; set; }
        public static long? accountID { get; set; }
        public static Users Register(string username, string fullname, string password, DateTime bitthday, int familycount, bool gender)
        {
            var entities = new Session1Entities();
            var user = entities.Users.SingleOrDefault(x => x.Username == username);
            if (user != null)
            {
                throw new ArgumentException("Username is exists.");
            }
            if (password.Length < 5)
            {
                throw new ArgumentException("Password length need least five.");
            }
            user = entities.Users.Add(new Users
            {
                GUID = Guid.NewGuid(),
                Username = username,
                Password = password,
                BirthDate = bitthday,
                FullName = fullname,
                FamilyCount = familycount,
                Gender = gender,
                UserTypeID = 2
            });
            entities.SaveChanges();
            return user;
        }
    }
}

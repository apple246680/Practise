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
            if (!entities.Users.Any(x=>x.Username=="test"))
            {

            }
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace forCrowd.WealthEconomy.BusinessObjects.Tests
{
    [TestClass]
    public class UserTests
    {
        [TestMethod]
        public void NewUser_ShouldCreate_TypeOfUser()
        {
         var newUser =   new User("A valid username?", "A valid email address?");
            Assert.IsInstanceOfType(newUser,typeof(User));
        }
    }
}

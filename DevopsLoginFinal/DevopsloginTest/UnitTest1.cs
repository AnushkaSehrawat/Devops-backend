using DevopsLoginFinal.Logic;
using DevopsLoginFinal.Models;
using System;
using Xunit;

namespace DevopsloginTest
{
    public class UnitTest1
    {
        [Theory]
        //[InlineData("anushka","abc")]
        //[InlineData("abc","xyz")]
        [MemberData(nameof(TestDataGenerator.GetUserDataFromDataGenerator), MemberType = typeof(TestDataGenerator))]
        public void Test1(User user1, User user2)
        {
            Login login = new Login();
            Assert.False(login.verifyLogin(user1));
            Assert.True(login.verifyLogin(user2));
        }
    }
}

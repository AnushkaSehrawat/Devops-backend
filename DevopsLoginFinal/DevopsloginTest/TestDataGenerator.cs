using DevopsLoginFinal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevopsloginTest
{
    class TestDataGenerator
    {
        public static IEnumerable<object[]> GetUserDataFromDataGenerator()
        {
            yield return new object[]
            {
              new User {name= "Tribbiani", password= "anushhka"},
              new User {name = "anushka", password= "anushka"},
            };
        }
     }
}

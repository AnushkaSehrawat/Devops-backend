using DevopsLoginFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevopsLoginFinal.Logic
    {
    public class Login
        {
        public bool verifyLogin(User user)
            {
            if (user.name == "anushka" && user.password == "anushka")
                {
                return true;
                }
            return false;
            }
        }
    }

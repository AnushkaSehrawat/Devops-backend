using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DevopsLoginFinal.Models;
using DevopsLoginFinal.Logic;

namespace DevopsLoginFinal.Controllers
    {
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
        {
        [HttpPost]
        public bool postLogin([FromBody] User user)
            {
            Login login = new Login();
            return login.verifyLogin(user);
            }
        }
    }
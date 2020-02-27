using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpringMvcApp.Entities;

namespace Spring_MVC_App.Controllers
{
    public class UserController : Controller
    {
        public bool Register(User user)
        {
            //Register for user
            return true;
        }

        public bool Signin(string UserName, string Password)
        {
            //signin for user
            return true;
        }

        public bool ChangePassword(string Password)
        {
            //change password
            return true;
        }

        public IActionResult GetUser(int UserId)
        {
            //Get user by id
            return View();
        }
    }
}
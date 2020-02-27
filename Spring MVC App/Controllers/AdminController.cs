using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpringMvcApp.Entities;

namespace Spring_Mvc_App.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult GetUserList()
        {
            //Get UserList
            return View();
        }

        public bool DeleteUser(List<int> UserId)
        {
            //Delete singleUser or bulk User
            return true;
        }

        public bool MakeAdmin(int UserId)
        {
            //Make user as Admin
            return true;
        }

        public IActionResult GetUser(int UserId)
        {
            //Get User by id
            User user = new User();
            return View();
        }

        public bool UpdateUser(User user)
        {
            //update user
            return true;
        }
    }
}
using SpringMvcApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpringMvcApp.BusinessLayer.Interfaces
{
    public interface IUserServices
    {
        bool Register(User user);
        bool Signin(string UserName, string Password);
        bool ChangePassword(string Password);
        User GetUser(int UserId);
        
    }
}

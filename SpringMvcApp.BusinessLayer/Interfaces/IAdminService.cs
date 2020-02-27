using SpringMvcApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpringMvcApp.BusinessLayer.Interfaces
{
   public interface IAdminService
    {
        List<User> GetUserList();
        bool DeleteUser(List<int> UserId);
        bool MakeAdmin(int UserId);
        User GetUserById(int UserId);
        bool UpdateUser(User user);

    }
}

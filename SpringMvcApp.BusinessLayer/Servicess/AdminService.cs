using SpringMvcApp.BusinessLayer.Interfaces;
using SpringMvcApp.DataLayer.NHibernate;
using SpringMvcApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpringMvcApp.BusinessLayer.Servicess
{
    public class AdminService : IAdminService
    {

        private readonly IMapperSession _session;

        public AdminService(IMapperSession session)
        {
            _session = session;
        }

        public bool DeleteUser(List<int> UserId)
        {
            return true;
        }

        public User GetUserById(int UserId)
        {
            User user = new User();
            return user;
        }

        public bool MakeAdmin(int UserId)
        {
            return true;
        }

        public bool UpdateUser(User user)
        {
            return true;
        }

        public List<User> GetUserList()
        {
            List<User> userlist = new List<User>();
            return userlist;

        }
    }
}

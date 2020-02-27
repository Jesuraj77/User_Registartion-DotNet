using SpringMvcApp.BusinessLayer.Interfaces;
using SpringMvcApp.DataLayer.NHibernate;
using SpringMvcApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpringMvcApp.BusinessLayer.Servicess
{
    public class UserService : IUserServices
    {
        private readonly IMapperSession _session;

        public UserService(IMapperSession session)
        {
            _session = session;
        }


        public bool ChangePassword(string Password)
        {
            return true;
        }

        public User GetUser(int UserId)
        {
            User user = new User();
            return user;
        }

        public bool Register(User user)
        {
            return true;
        }

        public bool Signin(string UserName, string Password)
        {
            return true;
        }
    }
}

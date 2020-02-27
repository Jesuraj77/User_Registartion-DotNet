using FluentNHibernate.Mapping;
using SpringMvcApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpringMvcApp.DataLayer.Mapping
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {

            Id(x => x.Id);

            Map(x => x.UserName);

            Map(x => x.Password);
            Map(x => x.ConfirmPassword);
            Map(x => x.Email);
            Map(x => x.Photo);
            

            Table("User");

        }
    }
}
    

using NSubstitute;
using SpringMvcApp.BusinessLayer.Servicess;
using SpringMvcApp.DataLayer.NHibernate;
using SpringMvcApp.Entities;
using SpringMvcApp.Test.Execption;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SpringMvcApp.Test.TestCases
{
   public class ExeptionTest
    {
       
        private readonly UserService _service;
        private readonly AdminService _services;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();

        public ExeptionTest()
        {
            _service = new UserService(_session);
        }

        User user = new User { Id = 1, UserName = "Mary", Password = "123456789", ConfirmPassword = "123456789", Email = "John@gamail.com" };


        [Fact]
        public void ExceptionTestFor_UserNotFound()
        {
            //Assert
            var ex = Assert.Throws<UserNotFoundException>(() => _services.GetUserById(200));
            Assert.Equal("User Not Found ", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_ValidUser_InvalidPassword()
        {
            User user = new User { Id = 1, UserName = "Mary", Password = "123456789", ConfirmPassword = "123456789", Email = "John@gamail.com" };
            //Action
            //Assert
            var ex = Assert.Throws<InvalidCredentialsExceptions>(() => _service.Signin("abc", "987654321"));
            Assert.Equal("Please enter valid usename & password", ex.Messages);
        }

        [Fact]
        public void ExceptionTestFor_InvalidUser_validPassword()
        {
            //Action
            //Assert
            var ex = Assert.Throws<InvalidCredentialsExceptions>(() => _service.Signin("abc", "987654321"));
            Assert.Equal("Please enter valid usename & password", ex.Messages);
        }
        [Fact]
        public void ExceptionTestFor_UserApprovalToMakeAdmin()
        {
            //Action
            //Assert
            var ex = Assert.Throws<InvalidCredentialsExceptions>(() => _services.MakeAdmin(user.Id));
            Assert.Equal("User has not accepted your admin request", ex.Messages);
        }

    }
}

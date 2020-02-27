using NSubstitute;
using SpringMvcApp.BusinessLayer.Servicess;
using SpringMvcApp.DataLayer.NHibernate;
using SpringMvcApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SpringMvcApp.Test.TestCases
{
   public class BoundaryTest
    {
        private readonly UserService _service;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();

        public BoundaryTest()
        {
            _service = new UserService(_session);
        }
        User user = new User
        {
            Id = 1,
            UserName = "Mary",
            Password = "123456789",
            ConfirmPassword = "123456789",
            Email = "John@gamail.com",
            Photo = "rose.jpeg"
        };

        [Fact]
        public void BoundaryTest_ForPassword_Length()
        {
            var MinLength = 8;
            var MaxLength = 25;

            //Action
            var actualLength = user.Password.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ForUserName_Length()
        {
            //Arrange
            var MinLength = 0;
            var MaxLength = 50;

            //Action
            var actualLength = user.UserName.Length;

            //Assert
            Assert.InRange(actualLength, MinLength, MaxLength);
        }

        [Fact]
        public void BoundaryTest_ForProfilePhoto()
        {
            //Arrange
            //Action
            var actualLength = user.UserName.Length;

            //Assert
            Assert.Contains(".jpeg", user.Photo);
        }
    }
}

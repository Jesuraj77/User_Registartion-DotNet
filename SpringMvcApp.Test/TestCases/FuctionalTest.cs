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
   public class FuctionalTest
    {

        private readonly UserService _service;
        private readonly AdminService _services;
        private readonly IMapperSession _session = Substitute.For<IMapperSession>();
        public FuctionalTest()
            {
                _service = new UserService(_session);
            }

            [Fact]
            public void Test_For_Valid_Registration()
            {
            //Arrange
            User user = new User
            {
                Id = 1,
                UserName = "Mary",
                Password = "123456789",
                ConfirmPassword = "123456789",
                Email = "John@gamail.com",
                Photo = "rose.jpeg"
            };
            //Action
            var IsRegistered = _service.Register(user);
                //Assert
                Assert.Equal(true, IsRegistered);
                Assert.True(IsRegistered);
            }



            [Fact]
            public void Test_For_Valid_SignIn()
            {
            //Arrange
            User user = new User
            {
                Id = 1,
                UserName = "Mary",
                Password = "123456789",
                ConfirmPassword = "123456789",
                Email = "John@gamail.com",
                Photo = "rose.jpeg"
            };
            //Action
            var IsLogged = _service.Signin(user.UserName, user.Password);
                //Assert
                Assert.Equal(true, IsLogged);
                Assert.True(IsLogged);
            }


            [Fact]
            public void Test_For_Valid_ChangePassword()
            {
            //Arrange
            User user = new User
            {
                Id = 1,
                UserName = "Mary",
                Password = "123456789",
                ConfirmPassword = "123456789",
                Email = "John@gamail.com",
                Photo = "rose.jpeg"
            };
            //Action
            var IsChanged = _service.ChangePassword(user.Password);
                //Assert
                Assert.Equal(true, IsChanged);
                Assert.True(IsChanged);
            }


            [Fact]
            public void Test_For_Valid_GetUserList()
            {
                //Arrange
                //Action
                var userList = _services.GetUserList();

                //Assert
                Assert.NotNull(userList);
            }


            [Fact]
            public void Test_For_Valid_DeleteUser()
            {
                //Arrange
                //Action
                var IsDeleted = _services.DeleteUser(new List<int> { 1, 2, 3 });

                //Assert
                Assert.Equal(true, IsDeleted);
                Assert.True(IsDeleted);

            }

            [Fact]
            public void Test_For_Valid_MakeAdmin()
            {
            //Arrange
            User user = new User
            {
                Id = 1,
                UserName = "Mary",
                Password = "123456789",
                ConfirmPassword = "123456789",
                Email = "John@gamail.com",
                Photo = "rose.jpeg"
            };
            var IsMade = _services.MakeAdmin(user.Id);

                //Assert
                Assert.Equal(true, IsMade);
                Assert.True(IsMade);
            }

            [Fact]
            public void Test_For_Valid_GetUser()
            {
            //Arrange
            User user = new User
            {
                Id = 1,
                UserName = "Mary",
                Password = "123456789",
                ConfirmPassword = "123456789",
                Email = "John@gamail.com",
                Photo = "rose.jpeg"
            };
            var gotuser = _service.GetUser(user.Id);

                //Assert
                Assert.NotNull(gotuser);
            }

            [Fact]
            public void Test_For_Valid_UpdateUser()
            {
            //Arrange
            User user = new User
            {
                Id = 1,
                UserName = "Mary",
                Password = "123456789",
                ConfirmPassword = "123456789",
                Email = "John@gamail.com",
                Photo = "rose.jpeg"
            };
            var IsUpdated = _services.UpdateUser(user);

                //Assert
                Assert.Equal(true, IsUpdated);
                Assert.True(IsUpdated);
            }

            [Fact]
            public void ExceptionTestFor_ValidFormatEmail()
            {
            //Arrange
            User user = new User
            {
                Id = 1,
                UserName = "Mary",
                Password = "123456789",
                ConfirmPassword = "123456789",
                Email = "John@gamail.com",
                Photo = "rose.jpeg"
            };
            //Assert
            Assert.Contains("@", user.Email);
            }
        }
}

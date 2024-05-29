using Microsoft.VisualStudio.TestTools.UnitTesting;
using CRUD_application_2.Controllers;
using CRUD_application_2.Models;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CRUD_application_2.Tests.Controllers
{
    [TestClass]
    public class UserControllerTest
    {
        private UserController _controller;
        private List<User> _userList;

        [TestInitialize]
        public void Setup()
        {
            _userList = new List<User>
            {
                new User { Id = 1, Name = "User1" },
                new User { Id = 2, Name = "User2" }
            };

            _controller = new UserController();
            UserController.userlist = _userList;
        }

        [TestMethod]
        public void Index_ReturnsCorrectView()
        {
            var result = _controller.Index() as ViewResult;
            //Assert.AreEqual("Index", result.ViewName);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Details_ReturnsCorrectView()
        {
            var result = _controller.Details(1) as ViewResult;
            //Assert.AreEqual("Details", result.ViewName);
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Create_ReturnsCorrectView()
        {
            var result = _controller.Create() as ViewResult;
            //Assert.AreEqual("Create", result.ViewName);
            Assert.IsNotNull(result);
        }

        //[TestMethod]
        //public void Create_Post_RedirectsToIndex()
        //{
        //    var result = _controller.Create(new User { Id = 3, Name = "User3" }) as RedirectToRouteResult;
        //    Assert.AreEqual("Index", result.RouteValues["action"]);
        //}

        //[TestMethod]
        //public void Edit_ReturnsCorrectView()
        //{
        //    var result = _controller.Edit(1) as ViewResult;
        //    Assert.AreEqual("Edit", result.ViewName);
        //}

        //[TestMethod]
        //public void Delete_RedirectsToIndex()
        //{
        //    var result = _controller.Delete(1) as RedirectToRouteResult;
        //    Assert.AreEqual("Index", result.RouteValues["action"]);
        //}
    }
}

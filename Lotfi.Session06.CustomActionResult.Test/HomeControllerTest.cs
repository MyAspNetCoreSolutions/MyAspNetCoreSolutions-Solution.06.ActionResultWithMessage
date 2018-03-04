using Lotfi.Session06.CustomActionResult.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection;
using Xunit;

namespace Lotfi.Session06.CustomActionResult.Test
{
    public class HomeControllerTest
    {
        [Fact]
        public void IndexTest()
        {
            //arenge
            HomeController homeController = new HomeController();
            //act
            var result = homeController.Index();
            //Assert
            Assert.Equal("Index", result.ViewName);
        }

        [Fact]
        public void AboutTest_ExpectWarningType()
        {
            //arenge
            HomeController homeController = new HomeController();
            //act
            var result = homeController.About();
            PropertyInfo[] prop = result.GetType().GetProperties();
            var type = prop[0].GetValue(result);
            var title = prop[1].GetValue(result);
            var body = prop[2].GetValue(result);
            //Assert
            Assert.Equal("warning", type);
            Assert.Equal("Warning", title);
            Assert.Equal("Fill from About", body);
           
        }

        [Fact]
        public void ContactTest_ExpectDangerType()
        {
            //arenge
            HomeController homeController = new HomeController();
            //act
            var result = homeController.Contact();
            PropertyInfo[] prop = result.GetType().GetProperties();
            var type = prop[0].GetValue(result);
            var title = prop[1].GetValue(result);
            var body = prop[2].GetValue(result);
            //Assert
            Assert.Equal("danger", type);
            Assert.Equal("Danger", title);
            Assert.Equal(" Fill from Contact", body);
        }
        

    }
}

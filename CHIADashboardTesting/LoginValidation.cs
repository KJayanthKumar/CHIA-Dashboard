using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHIADashboardApplication;
using CHIADashboardApplication.Models;
using CHIADashboardApplication.Controllers;
using System.Web.Mvc;

namespace CHIADashboardTesting
{
    [TestFixture]
    public class LoginValidation
    {
        [Test]
        public void EmptyUserNameAndPassword()
        {
            var obj = new ChiaApplicationController();
            LoginModel uspw = new LoginModel();
            uspw.UserName = " ";
            uspw.Password = " ";
            var actResult = obj.GetChia(uspw) as RedirectResult;
            Assert.That(actResult.Url, Is.EqualTo("~/ChiaApplication/Login"));
            Assert.That(ChiaApplicationController.ErrorMessage, Is.EqualTo("UserName or Password cannot be Empty!"));
        }

        [Test]
        public void EmptyUserName()
        {
            var obj = new ChiaApplicationController();
            LoginModel uspw = new LoginModel();
            uspw.UserName = " ";
            uspw.Password = "Summer2018!";
            var actResult = obj.GetChia(uspw) as RedirectResult;
            Assert.That(actResult.Url, Is.EqualTo("~/ChiaApplication/Login"));
            Assert.That(ChiaApplicationController.ErrorMessage, Is.EqualTo("UserName or Password cannot be Empty!"));
        }

        [Test]
        public void EmptyPassword()
        {
            var obj = new ChiaApplicationController();
            LoginModel uspw = new LoginModel();
            uspw.UserName = "jk063102";
            uspw.Password = " ";
            var actResult = obj.GetChia(uspw) as RedirectResult;
            Assert.That(actResult.Url, Is.EqualTo("~/ChiaApplication/Login"));
            Assert.That(ChiaApplicationController.ErrorMessage, Is.EqualTo("UserName or Password cannot be Empty!"));
        }

        [Test]
        public void ValidUserNamePassword()
        {
            var obj = new ChiaApplicationController();
            LoginModel uspw = new LoginModel();
            uspw.UserName = "jk063102";
            uspw.Password = "Summer2018!";
            var actResult = obj.GetChia(uspw) as ViewResult;
            ChiaDetails model = (ChiaDetails)actResult.Model;
            Assert.That(actResult.ViewName, Is.EqualTo("GetChiaList"));
            Assert.That(model.FromDate, Is.EqualTo(null));
            Assert.That(model.ToDate, Is.EqualTo(null));
            Assert.That(model.issueInfo.Count, Is.EqualTo(0));
        }

        [Test]
        public void InValidUserName()
        {
            var obj = new ChiaApplicationController();
            LoginModel uspw = new LoginModel();
            uspw.UserName = "AB3102";
            uspw.Password = "Summer2018!";
            var actResult = obj.GetChia(uspw) as RedirectResult;
            Assert.That(actResult.Url, Is.EqualTo("~/ChiaApplication/Login"));
            Assert.That(ChiaApplicationController.ErrorMessage == "Logon failure: unknown user name or bad password.\r\n" || ChiaApplicationController.ErrorMessage == "The user name or password is incorrect.\r\n");
            //Assert.That(ChiaApplicationController.ErrorMessage, Is.EqualTo("The user name or password is incorrect.\r\n"));
        }

        [Test]
        public void InValidPassword()
        {
            var obj = new ChiaApplicationController();
            LoginModel uspw = new LoginModel();
            uspw.UserName = "jk063102";
            uspw.Password = "Summer2";
            var actResult = obj.GetChia(uspw) as RedirectResult;
            Assert.That(actResult.Url, Is.EqualTo("~/ChiaApplication/Login"));
            Assert.That(ChiaApplicationController.ErrorMessage == "Logon failure: unknown user name or bad password.\r\n" || ChiaApplicationController.ErrorMessage == "The user name or password is incorrect.\r\n");
        }
    }
}

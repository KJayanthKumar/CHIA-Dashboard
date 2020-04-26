using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHIADashboardApplication;
using CHIADashboardApplication.Models;
using CHIADashboardApplication.Controllers;
using System.Web.Mvc;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace CHIADashboardTesting
{
    [TestFixture]
    class CHIAListValidation
    {
        [Test]
        public void GettingCHIAIssues()
        {
            string FromDate = "2018-01-01";
            string ToDate = "2018-06-06";
            string From = Convert.ToDateTime(FromDate).ToString("yyyy/MM/dd");
            string To = Convert.ToDateTime(ToDate).ToString("yyyy/MM/dd");
            ChiaApplicationController.user = "jk063102";
            ChiaApplicationController.pwd = "Summer2018!";
            ChiaApplicationController.from = FromDate;
            ChiaApplicationController.to = ToDate;
            var obj = new ChiaApplicationController();
            var actResult = obj.GettingCHIAIssues() as ChiaDetails;
            Assert.That(actResult.issueInfo.Count > 0);
            Assert.That(ChiaApplicationController.from, Is.EqualTo("2018-01-01"));
            Assert.That(ChiaApplicationController.to, Is.EqualTo("2018-06-06"));
        }

        [Test]
        public void GettingRemotelinks()
        {
            ChiaApplicationController.user = "jk063102";
            ChiaApplicationController.pwd = "Summer2018!";
            string CHIA_No = "CHIA-28551";
            Dictionary<string, string> CRList = new Dictionary<string, string>();
            var obj1 = new ChiaApplicationController();
            obj1.getremotelinks(CHIA_No, ref CRList);
            Assert.That(CRList.Count > 0);
            Assert.That(CRList.ContainsKey("GLB-294"));
            Assert.That(CRList.ContainsValue("https://jira2.cerner.com/browse/GLB-294"));
        }

        [Test]
        public void WhenClickOnPagination()
        {
            var obj = new ChiaApplicationController();
            var actResult = obj.GetChiaList() as ViewResult;
            ChiaDetails chiaDetails = (ChiaDetails)actResult.Model;
            Assert.That(chiaDetails.issueInfo.Count > 0);
            Assert.That(actResult.View, Is.EqualTo(null));
        }

        [Test]
        public void WhenClickOnSort()
        {
            var obj = new ChiaApplicationController();
            var actResult = obj.GetChiaList() as ViewResult;
            ChiaDetails chiaDetails = (ChiaDetails)actResult.Model;
            Assert.That(chiaDetails.issueInfo.Count > 0);
            Assert.That(actResult.View, Is.EqualTo(null));
        }

        //[Test]
        //public void SubmitButton()
        //{
        //    var obj = new ChiaApplicationController();
        //    string FromDate = "2018-01-01";
        //    string ToDate = "2018-06-06";
        //    DateTime From = Convert.ToDateTime(FromDate);
        //    DateTime To = Convert.ToDateTime(ToDate);
        //    var actResult = obj.Submit(From, To) as RedirectResult;
        //    Assert.That(actResult.Url, Is.EqualTo("~/ChiaApplication/GetChiaList"));
        //    Assert.That(ChiaApplicationController.from, Is.EqualTo("2018/01/01"));
        //    Assert.That(ChiaApplicationController.to, Is.EqualTo("2018/06/06"));
        //}
    }
}

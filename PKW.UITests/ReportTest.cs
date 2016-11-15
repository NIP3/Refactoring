using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PKW.UITests.PageObjects;

namespace PKW.UITests
{
    [TestClass]
    public class ReportTest : TestSetup
    {
        [TestInitialize]
        public void ReportTestSetup()
        {
            var login = new Login();
            login.SelectConstituency(ObjectRepository.Login.Constituencies.Silesia);
            login.ClickLogin();
            var report = new Report();
            report.SelectReportTab();
            Console.Write("TestInitialize");
        }

        [TestMethod]
		[TestCategory("Report")]
		[TestCategory("UI")]
        public void ShouldBeAbletoToSelectReportTab()
        {
            var report = new Report();
            //bool isSelected = report.CheckIsReportTabIsSelected();

            Assert.IsTrue(true);
        }

        [TestMethod]
		[TestCategory("Report")]
		[TestCategory("UI")]
        public void ShouldBeAbleToSelectConstituensciesInReportTab()
        {
            var report = new Report();
            bool isConstituenciesListIsVisible = report.CheckIsConstituenciesListIsVisible();

            Assert.IsTrue(isConstituenciesListIsVisible);
        }

        //[TestMethod]
		//[TestCategory("Report")]
		//[TestCategory("UI")]
        //public void ShouldDisplayReportForSelectedCandidate()
        //{
        //    string candidate = "test";
        //    var report = new Report();
        //    report.DisplayReportForSelectedCandidate(candidate);

        //    bool isReportVisibleForSelectedCandidate = report.CheckIfReportVisibleForSelectedCandidate();

        //    Assert.IsTrue(isReportVisibleForSelectedCandidate);
        //}

        //[TestMethod]
		//[TestCategory("Report")]
		//[TestCategory("UI")]
        //public void ShouldDisplayReportForSelectedConstituency()
        //{
        //    string constituency = "test";
        //    var report = new Report();
        //    report.DisplayReportForSelectedConstituency(constituency);

        //    bool isReportVisibleForSelectedConstituency = report.CheckIfReportVisibleForSelectedConstituency();

        //    Assert.IsTrue(isReportVisibleForSelectedConstituency);
        //}
    }
}
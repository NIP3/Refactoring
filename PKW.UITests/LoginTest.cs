using System.Diagnostics;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PKW.UITests.PageObjects;

namespace PKW.UITests
{
    [TestClass]
    public class LoginTest : TestSetup
    {
        [TestMethod]
		[TestCategory("Login")]
		[TestCategory("UI")]
        public void ShouldBeAbleToSelectConstituencies()
        {
            var login = new Login();
            login.SelectConstituency(ObjectRepository.Login.Constituencies.Silesia);
            login.ClickLogin();
            var voting = new Voting();
            Assert.AreEqual(voting.MainWindow.Title, ObjectRepository.Voting.WindowTitle);
        }

        [TestMethod]
		[TestCategory("Login")]
		[TestCategory("UI")]
        public void ShouldCloseApp()
        {
            new Login().ClickCancel();
            Thread.Sleep(1000);
            Assert.AreEqual(0, Process.GetProcessesByName(ObjectRepository.ApplicationProcessName).Length);
        }
    }
}
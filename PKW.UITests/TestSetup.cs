using Microsoft.VisualStudio.TestTools.UnitTesting;
using PKW.UITests.PageObjects;

namespace PKW.UITests
{
    [TestClass]
    public class TestSetup
    {
        private VotingApplication _votingApplication;
        private VotingService _votingService;

        [TestInitialize]
        public void Setup()
        {
            _votingService = new VotingService();
            _votingApplication = new VotingApplication();
        }

        [TestCleanup]
        public void TearDown()
        {
            _votingApplication.Close();
            _votingService.Close();
        }
    }
}
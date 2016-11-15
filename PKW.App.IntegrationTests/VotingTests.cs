using System.Collections.Generic;
using System.Linq;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PKW.App.Models;
using PKW.Contracts;
using PKW.ControlCenter;
using PKW.ControlCenter.Data;
using ConstituencyModel = PKW.ControlCenter.Data.ConstituencyModel;

namespace PKW.App.IntegrationTests
{
    /// <summary>
    /// Summary description for VotingTests
    /// </summary>
    [TestClass]
    public class VotingTests
    {
        private TestContext _testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get { return _testContextInstance; }
            set { _testContextInstance = value; }
        }

        private IVotingService _votingService;

        private IUnityContainer _ioc;

        #region Additional test attributes

        [TestInitialize]
        public void Init()
        {
            _ioc = new UnityContainer();
            ControlCenter.UnityBootstrapper.Register(_ioc);
            _votingService = _ioc.Resolve<IVotingService>();
        }

        #endregion

        [TestMethod]
        [TestCategory("Integration")]
        public void ShouldGetProperCandidatesCount()
        {
            //Given
            IDataRepository repository = _ioc.Resolve<IDataRepository>();
            repository.Add(new CandidatesModel() {Id = 1, Name = "Adam Kowalski"});
            repository.Add(new CandidatesModel() {Id = 2, Name = "Jan Nowak"});
            repository.Add(new CandidatesModel() {Id = 3, Name = "Trzeci Kandydat"});
            var expectedCandidatesCount = 3;
            //When
            var candidates = _votingService.GetCandidates().ToArray();
            //Then
            Assert.AreEqual(expectedCandidatesCount, candidates.Length);
        }

        [TestMethod]
        [TestCategory("Integration")]
        public void ShouldGetProperConstituenciesCount()
        {
            //Given
            IDataRepository repository = _ioc.Resolve<IDataRepository>();
            repository.Add(new CandidatesModel() {Id = 1, Name = "Adam Kowalski"});
            repository.Add(new ConstituencyModel()
            {
                Id = 1,
                Name = "Okreg 1",
            });
            repository.Add(new ConstituencyModel()
            {
                Id = 2,
                Name = "Okreg 2",
            });
            var expectedConstituencyList = 2;
            //When
            var constituencies = _votingService.GetConstituencies().ToArray();
            //Then
            Assert.AreEqual(expectedConstituencyList, constituencies.Length);
        }

        [TestMethod]
        [TestCategory("Integration")]
        public void ShouldSumVotesForAllConstituencies()
        {
            //Given
            IDataRepository repository = _ioc.Resolve<IDataRepository>();
            int candidateId = 1;
            string candidateName = "Adam Kowalski";
            repository.Add(new CandidatesModel() {Id = candidateId, Name = candidateName});
            repository.Add(new ConstituencyModel() {Id = 1, Name = "Okreg 1"});
            repository.Add(new ConstituencyModel() {Id = 2, Name = "Okreg 2"});

            var firstConstituencyVotes = 10;
            var secondConstituencyVotes = 7;
            var excpectedVotes = firstConstituencyVotes + secondConstituencyVotes;
            var firstConstituencyResults = new List<CandidateResults>();
            firstConstituencyResults.Add(new CandidateResults()
            {
                CandidateId = 1,
                NumberOfVotes = firstConstituencyVotes
            });
            var secondConstituencyResults = new List<CandidateResults>();
            secondConstituencyResults.Add(new CandidateResults()
            {
                CandidateId = 1,
                NumberOfVotes = secondConstituencyVotes
            });

            VotesReport firstConstituencyVotingReport = new VotesReport()
            {
                ConstituencyId = 1,
                Votes =
                    firstConstituencyResults.Select(
                        c => new CandidateVotes() {CandidateId = c.CandidateId, Amount = c.NumberOfVotes})
            };

            VotesReport secondConstituencyVotingReport = new VotesReport()
            {
                ConstituencyId = 2,
                Votes =
                    secondConstituencyResults.Select(
                        c => new CandidateVotes() {CandidateId = c.CandidateId, Amount = c.NumberOfVotes})
            };

            //when
            _votingService.SendVotes(firstConstituencyVotingReport);
            _votingService.SendVotes(secondConstituencyVotingReport);
            var votingSummary =
                _votingService.GetVotingSummary(null).AggregatedVoteses.ToArray().First(c => c.CandidateId == 1).Amount;

            //Then
            Assert.AreEqual(excpectedVotes, votingSummary);
        }
    }
}
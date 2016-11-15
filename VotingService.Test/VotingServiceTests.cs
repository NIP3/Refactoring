using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PKW.Contracts;
using PKW.ControlCenter.Data;

namespace PKW.ControlCenter.UnitTests
{
    [TestClass]
    public class VotingServiceTests
    {
        private Mock<IDataRepository> _repositoryMock;
        private PKW.ControlCenter.VotingService _service;

        [TestInitialize]
        public void InitializeData()
        {
            _repositoryMock = new Mock<IDataRepository>();
            _service = new PKW.ControlCenter.VotingService(_repositoryMock.Object);

            InitializaData();
        }


        private CandidatesModel _candidateA;
        private CandidatesModel _candidateB;
        private ConstituencyModel _constituencyA;
        private ConstituencyModel _constituencyB;


        private void InitializaData()
        {
            _candidateA = new CandidatesModel()
            {
                Id = 100,
                Name = "candidateA",
                ConstituencyId = 201
            };

            _candidateB = new CandidatesModel()
            {
                Id = 101,
                Name = "candidateB",
                ConstituencyId = 202
            };

            _constituencyA = new ConstituencyModel()
            {
                Id = 201,
                InvalidVotes = 2,
                IssuedBallots = 3,
                Name = "constituencyA",
                Votes = new Dictionary<CandidatesModel, int>()
            };

            _constituencyB =
                new ConstituencyModel()
                {
                    Id = 202,
                    InvalidVotes = 4,
                    IssuedBallots = 5,
                    Name = "constituencyB",
                    Votes = new Dictionary<CandidatesModel, int>()
                };
        }


        [TestMethod]
        public void Constituencies_ShouldReturnAllExisting()
        {
            // Given
            _repositoryMock.Setup(t => t.GetConstituencies())
                .Returns(() => new[] {_constituencyA, _constituencyB}.AsQueryable());

            // When
            var constituenciesResult = _service.GetConstituencies().ToArray();

            // Then
            var constituenciesExpected = new[]
            {
                new Constituency {Id = 201, Name = "constituencyA"},
                new Constituency {Id = 202, Name = "constituencyB"},
            };

            Assert.IsNotNull(constituenciesResult);
            CollectionAssert.AreEquivalent(constituenciesExpected, constituenciesResult);
        }

        [TestMethod]
        public void Candidates_ShouldReturnAllExisting()
        {
            // Given
            _repositoryMock.Setup(t => t.GetCandidates()).Returns(() => new[] {_candidateA, _candidateB}.AsQueryable());

            // When
            var candidatesResult = _service.GetCandidates().ToArray();

            // Then
            var candidatesExpected = new[]
            {
                new Candidate() {Id = 100, DisplayName = "candidateA"},
                new Candidate() {Id = 101, DisplayName = "candidateB"}
            };

            Assert.IsNotNull(candidatesResult);
            CollectionAssert.AreEquivalent(candidatesExpected, candidatesResult);
        }

        [TestMethod]
        public void Candidates_ShouldReturnFromGivenConstituency()
        {
            // Given
            _repositoryMock.Setup(t => t.GetCandidates()).Returns(() => new[] {_candidateA, _candidateB}.AsQueryable());
            int constituencyAId = 201;
            // When
            var candidatesResult = _service.GetConstituencyCandidates(constituencyAId).ToArray();

            // Then
            var candidatesExpected = new[]
            {
                new Candidate() {Id = 100, DisplayName = "candidateA", ConstituencyId = constituencyAId}
            };

            Assert.IsNotNull(candidatesResult);
            CollectionAssert.AreEquivalent(candidatesExpected, candidatesResult);
        }

        [TestMethod]
        public void SendVotes_SholdUpdateVotes()
        {
            // Given
            _repositoryMock.Setup(r => r.GetCandidate(_candidateA.Id)).Returns(_candidateA);
            _repositoryMock.Setup(r => r.GetCandidate(_candidateB.Id)).Returns(_candidateB);
            _repositoryMock.Setup(r => r.GetConstituence(_constituencyA.Id)).Returns(_constituencyA);

            var votesReport = new VotesReport()
            {
                ConstituencyId = _constituencyA.Id,
                IssuedBallots = 123,
                InvalidVotes = 456,
                Votes = new[]
                {
                    new CandidateVotes() {CandidateId = _candidateA.Id, Amount = 555},
                    new CandidateVotes() {CandidateId = _candidateB.Id, Amount = 777},
                }
            };


            // When
            _service.SendVotes(votesReport);

            // Then            
            Assert.AreEqual(123, _constituencyA.IssuedBallots);
            Assert.AreEqual(456, _constituencyA.InvalidVotes);
            Assert.AreEqual(555, _constituencyA.Votes[_candidateA]);
            Assert.AreEqual(777, _constituencyA.Votes[_candidateB]);
        }


        [TestMethod]
        public void VotingSummary_SholdCountAllVotes()
        {
            // Given
            _constituencyA.InvalidVotes = 1;
            _constituencyA.IssuedBallots = 2;
            _constituencyA.Votes = new Dictionary<CandidatesModel, int>();
            _constituencyA.Votes.Add(_candidateA, 1000);
            _constituencyA.Votes.Add(_candidateB, 2000);

            _constituencyB.InvalidVotes = 3;
            _constituencyB.IssuedBallots = 4;
            _constituencyB.Votes = new Dictionary<CandidatesModel, int>();
            _constituencyB.Votes.Add(_candidateA, 3000);
            _constituencyB.Votes.Add(_candidateB, 4000);

            _repositoryMock.Setup(t => t.GetConstituencies())
                .Returns(() => new[] {_constituencyA, _constituencyB}.AsQueryable());

            // When
            var votingSummaryResult = _service.GetVotingSummary(null);

            // Then
            var votingSummaryExpected = new VotingSummary()
            {
                InvalidVotes = 4,
                IssuedBallots = 6,
                AggregatedVoteses = new[]
                {
                    new CandidateVotes {CandidateId = _candidateA.Id, CandidateName = _candidateA.Name, Amount = 4000},
                    new CandidateVotes {CandidateId = _candidateB.Id, CandidateName = _candidateB.Name, Amount = 6000},
                }
            };

            Assert.IsNotNull(votingSummaryResult);
            Assert.AreEqual(votingSummaryExpected, votingSummaryResult);
        }
    }
}
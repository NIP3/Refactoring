using System.Collections.Generic;
using System.Linq;
using PKW.Contracts;

namespace PKW.App.Models
{
    public class ConstituencyModel : IConstituencyModel
    {
        private readonly IEnumerable<CandidateResults> _candidateResults;
        private readonly IVotingService _votingService;
        private readonly ISession _session;

        public IEnumerable<CandidateResults> CandidateResults
        {
            get { return _candidateResults; }
        }

        public int InvalidVotes { get; set; }
        public int IssuedBollots { get; set; }

        public ConstituencyModel(IVotingService votingservice, ISession session)
        {
            _candidateResults = new List<CandidateResults>();
            _votingService = votingservice;
            _session = session;

            var candidates = votingservice.GetConstituencyCandidates(_session.ConstituencyId);

            foreach (var candidate in candidates)
            {
                ((List<CandidateResults>)_candidateResults).Add(new CandidateResults()
                {
                    CandidateId = candidate.Id,
                    Name = candidate.DisplayName,
                    NumberOfVotes = 0
                });
            }
        }

        public void SendVotes()
        {
            VotesReport report = new VotesReport()
            {
                ConstituencyId = _session.ConstituencyId,
                InvalidVotes = InvalidVotes,
                IssuedBallots = IssuedBollots,
                Votes = CandidateResults.Select(
                        c => new CandidateVotes() { CandidateId = c.CandidateId, Amount = c.NumberOfVotes })
            };

            _votingService.SendVotes(report);
        }

        public IEnumerable<Constituency> GetConstituencies()
        {
            return _votingService.GetConstituencies();
        }

        public VotingSummary GetVotingSummary(int? constituencyId)
        {
            return _votingService.GetVotingSummary(constituencyId);
        }
    }
}
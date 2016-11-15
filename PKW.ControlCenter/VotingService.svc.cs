using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using PKW.Contracts;
using PKW.ControlCenter.Data;

namespace PKW.ControlCenter
{
    public class VotingService : IVotingService
    {
        private readonly IDataRepository _repository;


        public VotingService(IDataRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Constituency> GetConstituencies()
        {
            var constituencies = _repository.GetConstituencies()
                .Select(constituency => new Constituency() { Id = constituency.Id, Name = constituency.Name })
                .ToList();

            return constituencies;
        }

        public IEnumerable<Candidate> GetConstituencyCandidates(int constituencyId)
        {
            return _repository.GetCandidates()
                    .Where(x => x.ConstituencyId == constituencyId)
                    .Select(x => new Candidate() { ConstituencyId = x.ConstituencyId, DisplayName = x.Name, Id = x.Id });
        }

        public IEnumerable<Candidate> GetCandidates()
        {
            var candidates = _repository.GetCandidates()
                .Select(candidate => new Candidate() { Id = candidate.Id, DisplayName = candidate.Name })
                .ToList();

            return candidates;
        }

        public void SendVotes(VotesReport votesReport)
        {
            var constituency = _repository.GetConstituence(votesReport.ConstituencyId);

            Dictionary<CandidatesModel, int> votesSummary = new Dictionary<CandidatesModel, int>();

            foreach (var candidate in votesReport.Votes)
            {
                CandidatesModel condidate = _repository.GetCandidate(candidate.CandidateId);
                votesSummary[condidate] = candidate.Amount;
            }

            constituency.InvalidVotes = votesReport.InvalidVotes;
            constituency.IssuedBallots = votesReport.IssuedBallots;
            constituency.Votes = votesSummary;
        }

        public VotingSummary GetVotingSummary(int? constituencyId)
        {
            IQueryable<ConstituencyModel> constituencies = null;

            if (constituencyId.HasValue)
            {
                List<ConstituencyModel> cm = new List<ConstituencyModel>();
                cm.Add(_repository.GetConstituence(constituencyId.Value));
                constituencies = cm.AsQueryable();
            }
            else
            {
                constituencies = _repository.GetConstituencies();
            }

            var allVotes = constituencies.Where(c => c.Votes != null)
                .SelectMany(c => c.Votes);

            int totalValidVoteCount = allVotes.Sum(v => v.Value);

            var agreagatedVotes = allVotes.GroupBy(v => v.Key)
                .Select(g => new CandidateVotes()
                {
                    CandidateId = g.Key.Id,
                    CandidateName = g.Key.Name,
                    Amount = g.Sum(c => c.Value),
                    Percentage = (double)g.Sum(c => c.Value) / totalValidVoteCount
                });

            return new VotingSummary()
            {
                InvalidVotes = constituencies.Sum(c => c.InvalidVotes),
                IssuedBallots = constituencies.Sum(c => c.IssuedBallots),
                AggregatedVoteses = agreagatedVotes.ToArray()
            };
        }
    }
}
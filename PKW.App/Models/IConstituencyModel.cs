using System.Collections.Generic;
using PKW.Contracts;

namespace PKW.App.Models
{
    public interface IConstituencyModel
    {
        IEnumerable<CandidateResults> CandidateResults { get; }
        int InvalidVotes { get; set; }
        int IssuedBollots { get; set; }
        void SendVotes();
        IEnumerable<Constituency> GetConstituencies();
        VotingSummary GetVotingSummary(int? constituencyId);
    }
}
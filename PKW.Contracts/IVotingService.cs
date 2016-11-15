using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PKW.Contracts
{
    [ServiceContract]
    public interface IVotingService
    {
        [OperationContract]
        IEnumerable<Constituency> GetConstituencies();

        [OperationContract]
        IEnumerable<Candidate> GetCandidates();

        [OperationContract]
        IEnumerable<Candidate> GetConstituencyCandidates(int constituencyId);

        [OperationContract]
        void SendVotes(VotesReport votesReport);

        [OperationContract]
        VotingSummary GetVotingSummary(int? constituencyId);
    }
}
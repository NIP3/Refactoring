using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PKW.Contracts
{
    [DataContract]
    public class VotesReport
    {
        [DataMember]
        public int ConstituencyId { get; set; }

        [DataMember]
        public int InvalidVotes { get; set; }

        [DataMember]
        public int IssuedBallots { get; set; }

        [DataMember]
        public IEnumerable<CandidateVotes> Votes { get; set; }
    }
}
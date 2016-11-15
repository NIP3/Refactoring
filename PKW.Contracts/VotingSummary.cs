using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PKW.Contracts
{
    [DataContract]
    public class VotingSummary : IEquatable<VotingSummary>
    {
        [DataMember]
        public int InvalidVotes { get; set; }

        [DataMember]
        public int IssuedBallots { get; set; }

        [DataMember]
        public IEnumerable<CandidateVotes> AggregatedVoteses { get; set; }


        public override int GetHashCode()
        {
            return string.Join("|", InvalidVotes, IssuedBallots, AggregatedVoteses.GetHashCode()).GetHashCode();
        }

        public override bool Equals(object obj)
        {
            VotingSummary other = obj as VotingSummary;
            return other != null && Equals(other);
        }

        public bool Equals(VotingSummary other)
        {
            return this.InvalidVotes == other.InvalidVotes
                   && this.IssuedBallots == other.IssuedBallots
                   && this.AggregatedVoteses.SequenceEqual(other.AggregatedVoteses);
        }
    }
}
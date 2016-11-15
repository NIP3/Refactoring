using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace PKW.Contracts
{
    [DataContract]
    public class CandidateVotes : IEquatable<CandidateVotes>
    {
        [DataMember]
        public int CandidateId { get; set; }

        [DataMember]
        public string CandidateName { get; set; }

        [DataMember]
        public int Amount { get; set; }

        [DataMember]
        public double Percentage { get; set; }


        public override int GetHashCode()
        {
            return CandidateId.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var otherCandidateVotes = obj as CandidateVotes;
            return otherCandidateVotes != null && Equals(otherCandidateVotes);
        }

        public bool Equals(CandidateVotes other)
        {
            return this.CandidateName == other.CandidateName
                   && this.CandidateId == other.CandidateId
                   && this.Amount == other.Amount;
        }
    }
}
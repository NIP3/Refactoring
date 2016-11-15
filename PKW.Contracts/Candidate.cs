using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Text;

namespace PKW.Contracts
{
    [DataContract]
    public class Candidate : IEquatable<Candidate>
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string DisplayName { get; set; }

        [DataMember]
        public int ConstituencyId { get; set; }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Candidate other = obj as Candidate;
            return other != null && Equals(other);
        }

        public bool Equals(Candidate other)
        {
            return this.Id == other.Id
                   && this.DisplayName == other.DisplayName;
        }
    }
}
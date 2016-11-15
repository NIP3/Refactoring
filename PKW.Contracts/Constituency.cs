using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PKW.Contracts
{
    [DataContract]
    public class Constituency : IEquatable<Constituency>
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        public Constituency()
        {
        }

        public Constituency(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Constituency other = obj as Constituency;
            return other != null && Equals(other);
        }

        public bool Equals(Constituency other)
        {
            return this.Id == other.Id
                   && this.Name == other.Name;
        }
    }
}
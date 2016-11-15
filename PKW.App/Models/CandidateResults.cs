using System.ComponentModel;

namespace PKW.App.Models
{
    public class CandidateResults
    {
        [Browsable(false)]
        public int CandidateId { get; set; }

        [DisplayName("Kandydat")]
        public string Name { get; set; }

        [DisplayName("Liczba głosów")]
        public int NumberOfVotes { get; set; }
    }
}
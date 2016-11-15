using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PKW.App.Providers;
using PKW.Contracts;

namespace PKW.App.Models
{
    public class LoginModel : ILoginModel
    {
        private readonly IVotingService _votingService;

        public LoginModel(IVotingService votingService)
        {
            _votingService = votingService;
        }

        public IEnumerable<Constituency> GetConstituencies()
        {
            return _votingService.GetConstituencies();
        }
    }
}
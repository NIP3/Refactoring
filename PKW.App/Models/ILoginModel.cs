using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PKW.Contracts;

namespace PKW.App.Models
{
    public interface ILoginModel
    {
        IEnumerable<Constituency> GetConstituencies();
    }
}
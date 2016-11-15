using System.Linq;
using PKW.ControlCenter.Data;

namespace PKW.ControlCenter
{
    public interface IDataRepository
    {
        void Add(CandidatesModel candidate);
        CandidatesModel GetCandidate(int candidateId);
        IQueryable<CandidatesModel> GetCandidates();
        void Add(ConstituencyModel constituency);
        ConstituencyModel GetConstituence(int constituenceId);
        IQueryable<ConstituencyModel> GetConstituencies();
    }
}
using PKW.Contracts;

namespace PKW.App.Providers
{
    public interface IControlCenterFactory
    {
        IVotingService GetClient();
    }
}
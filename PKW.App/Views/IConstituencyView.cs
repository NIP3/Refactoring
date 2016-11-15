namespace PKW.App.Views
{
    public interface IConstituencyView
    {
        IVotingView VotingView { get; }
        IReportView ReportView { get; }
        void ShowView();
    }
}
using System.Windows.Forms;

namespace PKW.App.Views
{
    public partial class ConstituencyView : Form, IConstituencyView
    {
        public IVotingView VotingView
        {
            get { return votingViewUC; }
        }

        public IReportView ReportView
        {
            get { return reportViewUC; }
        }

        public ConstituencyView()
        {
            InitializeComponent();
        }

        public void ShowView()
        {
            ShowDialog();
        }
    }
}
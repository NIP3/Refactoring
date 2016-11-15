using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Charting = System.Windows.Forms.DataVisualization.Charting;
using PKW.Contracts;

namespace PKW.App.Views
{
    public partial class ReportView : UserControl, IReportView
    {
        private const int NoFilterSelectedIndex = -1;
        private const string NoFilterSelectedText = "Wyniki ogólnopolskie - wszystkie okręgi wyborcze";

        public event EventHandler<int?> ConstituencyFilterChanged;

        public ReportView()
        {
            InitializeComponent();
            this.Invalidated += ReportView_Invalidated;
        }

        private void ReportView_Invalidated(object sender, System.Windows.Forms.InvalidateEventArgs e)
        {
            RefreshResults();
        }

        private void cbConstituencyFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshResults();
        }

        private void RefreshResults()
        {
            int? constituencyId =
                (int?)
                    (((int) cbConstituencyFilter.SelectedValue).Equals(NoFilterSelectedIndex)
                        ? null
                        : cbConstituencyFilter.SelectedValue);

            if (ConstituencyFilterChanged != null)
                ConstituencyFilterChanged(this, constituencyId);
        }

        public void DisplayResults(VotingSummary results)
        {
            IEnumerable<CandidateVotes> candidateResults = results.AggregatedVoteses;
            if (candidateResults.Count() > 0)
            {
                lblNoResults.Visible = false;
                dgvResults.AutoGenerateColumns = false;
                dgvResults.DataSource = candidateResults;
                dgvResults.Visible = true;
            }
            else
            {
                dgvResults.Visible = false;
                lblNoResults.Visible = true;
            }

            lblInvalidVotes.Text = results.InvalidVotes.ToString();
            lblIssuedBallouts.Text = results.IssuedBallots.ToString();
        }

        public void InitializeConstituencyFilter(IEnumerable<Constituency> constituencies)
        {
            List<Constituency> constituencyFilter = constituencies.ToList();
            constituencyFilter.Insert(0, new Contracts.Constituency(NoFilterSelectedIndex, NoFilterSelectedText));
            cbConstituencyFilter.DataSource = constituencyFilter;
        }
    }
}
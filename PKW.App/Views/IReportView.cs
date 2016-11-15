using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Charting = System.Windows.Forms.DataVisualization.Charting;
using PKW.Contracts;

namespace PKW.App.Views
{
    public interface IReportView
    {
        event EventHandler<int?> ConstituencyFilterChanged;

        void DisplayResults(VotingSummary results);
        void InitializeConstituencyFilter(IEnumerable<Constituency> constituencies);
    }
}
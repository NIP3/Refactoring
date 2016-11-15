using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PKW.App.Models;
using PKW.App.Views;

namespace PKW.App.Presenters
{
    public class ReportPresenter : IReportPresenter, ITabPresenter
    {
        private IConstituencyModel _model;
        private IReportView _view;

        public bool HasViewOfType(Type type)
        {
            Type viewType = typeof (IReportView);
            return viewType.IsAssignableFrom(type);
        }

        public void Initialize<T>(IConstituencyModel model, T view)
        {
            _view = (IReportView) view;
            _model = model;

            _view.ConstituencyFilterChanged += ConstituencyFilterChanged;

            IEnumerable<Contracts.Constituency> constituencies = _model.GetConstituencies();
            _view.InitializeConstituencyFilter(constituencies);

            ConstituencyFilterChanged(null, null);
        }

        private void ConstituencyFilterChanged(object sender, int? constituencyId)
        {
            Contracts.VotingSummary results = _model.GetVotingSummary(constituencyId);

            _view.DisplayResults(results);
        }
    }
}
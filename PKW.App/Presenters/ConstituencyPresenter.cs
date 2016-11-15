using System.Collections.Generic;
using PKW.App.Models;
using PKW.App.Views;

namespace PKW.App.Presenters
{
    public class ConstituencyPresenter : IConstituencyPresenter
    {
        private readonly IConstituencyModel _model;
        private readonly IConstituencyView _view;

        public ConstituencyPresenter(
            IConstituencyModel model
            , IConstituencyView view
            , IEnumerable<ITabPresenter> tabPresenters
            )
        {
            _model = model;
            _view = view;

            foreach (var tabPresenter in tabPresenters)
            {
                if (tabPresenter.HasViewOfType(_view.VotingView.GetType()))
                {
                    tabPresenter.Initialize(_model, _view.VotingView);
                }

                if (tabPresenter.HasViewOfType(_view.ReportView.GetType()))
                {
                    tabPresenter.Initialize(_model, _view.ReportView);
                }
            }
        }

        public void Show()
        {
            _view.ShowView();
        }
    }
}
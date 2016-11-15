using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PKW.App.Models;
using PKW.App.Views;

namespace PKW.App.Presenters
{
    public class VotingPresenter : IVotingPresenter, ITabPresenter
    {
        private IConstituencyModel _model;
        private IVotingView _view;

        public bool HasViewOfType(Type type)
        {
            Type viewType = typeof (IVotingView);
            return viewType.IsAssignableFrom(type);
        }

        public void Initialize<T>(IConstituencyModel model, T view)
        {
            _view = (IVotingView) view;
            _model = model;

            _view.InvalidVotesValidate += view_InvalidVotesValidate;
            _view.InvalidVotesTextChange += view_InvalidVotesTextChanged;
            _view.IssuedBollotsValidate += view_IssuedBollotsValidate;
            _view.IssuedBollotsTextChange += view_IssuedBollotsTextChanged;
            _view.SendClicked += view_SendClicked;

            _view.CandidatesDataGridView.DataSource = model.CandidateResults;
        }

        private void view_SendClicked(object sender, EventArgs e)
        {
            _model.SendVotes();
        }

        private bool view_IssuedBollotsValidate(object sender, string e)
        {
            int issuedBollots;

            if (int.TryParse(e, out issuedBollots))
            {
                _model.IssuedBollots = issuedBollots;
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool view_InvalidVotesValidate(object sender, string e)
        {
            int invalidVotes;

            if (int.TryParse(e, out invalidVotes))
            {
                _model.InvalidVotes = invalidVotes;
                return true;
            }
            else
            {
                return false;
            }
        }

        private void view_IssuedBollotsTextChanged(object sender, string e)
        {
            int issuedBollots;

            if (int.TryParse(e, out issuedBollots))
            {
                _view.IssuedBollotsSetValidColor(true);
            }
            else
            {
                _view.IssuedBollotsSetValidColor(false);
            }
        }

        private void view_InvalidVotesTextChanged(object sender, string e)
        {
            int invalidVotes;

            if (int.TryParse(e, out invalidVotes))
            {
                _view.InvalidVotesSetValidColor(true);
            }
            else
            {
                _view.InvalidVotesSetValidColor(false);
            }
        }
    }
}
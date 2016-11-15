using System;
using System.Windows.Forms;

namespace PKW.App.Views
{
    public interface IVotingView
    {
        DataGridView CandidatesDataGridView { get; }
        event EventHandler<string> InvalidVotesTextChange;
        event Func<object, string, bool> InvalidVotesValidate;
        event EventHandler<string> IssuedBollotsTextChange;
        event Func<object, string, bool> IssuedBollotsValidate;
        event EventHandler SendClicked;

        void InvalidVotesSetValidColor(bool isValid);
        void IssuedBollotsSetValidColor(bool isValid);
    }
}
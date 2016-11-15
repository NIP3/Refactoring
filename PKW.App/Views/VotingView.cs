using System;
using System.Windows.Forms;

namespace PKW.App.Views
{
    public partial class VotingView : UserControl, IVotingView
    {
        public event Func<object, string, bool> InvalidVotesValidate;

        public event Func<object, string, bool> IssuedBollotsValidate;

        public event EventHandler<string> InvalidVotesTextChange;

        public event EventHandler<string> IssuedBollotsTextChange;

        public event EventHandler SendClicked;

        private readonly System.Drawing.Color _validBackColor;
        private readonly System.Drawing.Color _invalidBackColor;

        public DataGridView CandidatesDataGridView
        {
            get { return dgvCandidates; }
        }

        public VotingView()
        {
            InitializeComponent();

            _validBackColor = tbInvalidVotes.BackColor;
            _invalidBackColor = System.Drawing.Color.Red;
        }

        private void btnSendVotes_Click(object sender, EventArgs e)
        {
            if (SendClicked != null)
                SendClicked(this, e);
        }

        private void tbInvalidVotes_TextChanged(object sender, EventArgs e)
        {
            if (InvalidVotesTextChange != null)
            {
                InvalidVotesTextChange(this, tbInvalidVotes.Text);
            }
        }

        private void tbIssuedBallots_TextChanged(object sender, EventArgs e)
        {
            if (IssuedBollotsTextChange != null)
            {
                IssuedBollotsTextChange(this, tbIssuedBallots.Text);
            }
        }

        public void InvalidVotesSetValidColor(bool valid)
        {
            if (!valid)
            {
                tbInvalidVotes.BackColor = _invalidBackColor;
            }
            else
            {
                tbInvalidVotes.BackColor = _validBackColor;
            }
        }

        public void IssuedBollotsSetValidColor(bool valid)
        {
            if (!valid)
            {
                tbIssuedBallots.BackColor = _invalidBackColor;
            }
            else
            {
                tbIssuedBallots.BackColor = _validBackColor;
            }
        }

        private void tbInvalidVotes_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (InvalidVotesValidate != null)
            {
                bool isValid = InvalidVotesValidate(this, tbInvalidVotes.Text);

                if (!isValid)
                {
                    e.Cancel = true;
                }
            }
        }

        private void tbIssuedBallots_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (IssuedBollotsValidate != null)
            {
                bool isValid = IssuedBollotsValidate(this, tbIssuedBallots.Text);

                if (!isValid)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
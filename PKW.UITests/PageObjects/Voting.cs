using System;
using System.Collections.Generic;
using System.Linq;
using TestStack.White.InputDevices;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.TableItems;

namespace PKW.UITests.PageObjects
{
    internal class Voting : VotingApplication
    {
        private readonly Lazy<TextBox> _invalidVotes;
        private readonly Lazy<TextBox> _issuedBallots;
        private readonly Lazy<Button> _sendButton;
        private readonly Table _candidates;

        public Voting()
            : base(ObjectRepository.Voting.WindowTitle)
        {
            _candidates = MainWindow.Get<Table>(ObjectRepository.Voting.CandidatesList);
            _invalidVotes = new Lazy<TextBox>(() => MainWindow.Get<TextBox>(ObjectRepository.Voting.InvalidVotes));
            _issuedBallots = new Lazy<TextBox>(() => MainWindow.Get<TextBox>(ObjectRepository.Voting.IssuedBallots));
            _sendButton = new Lazy<Button>(() => MainWindow.Get<Button>(ObjectRepository.Voting.SendButton));
        }

        public void SetInvalidVotes(string invalidVotes)
        {
            _invalidVotes.Value.Text = invalidVotes;
        }

        public void SetIssuedBallots(string issuedBallots)
        {
            _issuedBallots.Value.Text = issuedBallots;
        }

        public void SendReport()
        {
            _sendButton.Value.Click();
        }

        public bool IsErrorMessagePresent()
        {
            return false;
        }

        public List<string> GetListOfCandidates()
        {
            List<string> candidateNamesList = new List<string>();
            foreach (var row in _candidates.Rows)
            {
                candidateNamesList.Add(row.Cells[0].Value.ToString());
            }
            return candidateNamesList;
        }

        public bool SetVotesForCandidate(string candidate, string numberOfVotes)
        {
            foreach (var row in _candidates.Rows)
            {
                if (row.Cells[0].Value.ToString() == candidate)
				{
					row.Cells[1].Click();
					Keyboard.Instance.Enter(numberOfVotes);
                }
            }
            return true;
        }

        public bool SetVotesForCandidate(string candidate, int numberOfVotes)
        {
            foreach (var row in _candidates.Rows)
            {
                if (row.Cells[0].Value.ToString() == candidate)
                {
                    row.Cells[1].Value = numberOfVotes;
                }
            }
            return true;
        }

        public string GetFirstCandidate()
        {
            return _candidates.Rows[0].Cells[0].Value.ToString();
        }
    }
}
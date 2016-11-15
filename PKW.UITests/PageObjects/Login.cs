using System;
using TestStack.White.UIItems;
using TestStack.White.UIItems.ListBoxItems;

namespace PKW.UITests.PageObjects
{
    internal class Login : VotingApplication
    {
        private readonly Lazy<Button> _cancelButton;
        private readonly Lazy<ComboBox> _listOfConstituancies;
        private readonly Lazy<Button> _loginButton;

        public Login()
        {
            _listOfConstituancies =
                new Lazy<ComboBox>(() => MainWindow.Get<ComboBox>(ObjectRepository.Login.ConstituenciesList));
            _loginButton = new Lazy<Button>(() => MainWindow.Get<Button>(ObjectRepository.Login.LoginButton));
            _cancelButton = new Lazy<Button>(() => MainWindow.Get<Button>(ObjectRepository.Login.CancelButton));
        }

        public void SelectConstituency(string constituency)
        {
            _listOfConstituancies.Value.Select(constituency);
        }

        public void TypeConstituency(string constituency)
        {
            _listOfConstituancies.Value.EditableText = constituency;
        }

        public void ClickLogin()
        {
            _loginButton.Value.Click();
        }

        public void ClickCancel()
        {
            _cancelButton.Value.Click();
        }
    }
}
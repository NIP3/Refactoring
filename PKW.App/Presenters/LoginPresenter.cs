using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PKW.App.Models;
using PKW.App.Views;

namespace PKW.App.Presenters
{
    public class LoginPresenter : ILoginPresenter
    {
        private readonly ILoginView _loginView;

        private readonly ILoginModel _loginModel;
        private readonly ISession _session;
        private bool _isLoginSuccessful;

        public LoginPresenter(ILoginView loginView, ILoginModel loginModel, ISession session)
        {
            _session = session;
            _loginView = loginView;
            _loginModel = loginModel;

            _loginView.LoginClicked += LoginView_LoginClicked;
            _loginView.CancelClicked += LoginView_CancelClicked;
        }

        private void LoginView_LoginClicked(object sender, int constituencyId)
        {
            _session.ConstituencyId = constituencyId;
            _loginView.Exit();
            _isLoginSuccessful = true;
        }

        private void LoginView_CancelClicked(object sender, EventArgs e)
        {
            _loginView.Exit();
            _isLoginSuccessful = false;
        }

        public bool ShowLogin()
        {
            _loginView.LoadConstituencies(_loginModel.GetConstituencies());
            _loginView.ShowForm();
            return _isLoginSuccessful;
        }
    }
}
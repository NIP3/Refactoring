using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PKW.App.Models;
using PKW.App.Presenters;
using PKW.App.Views;

namespace PKW.App.UnitTests
{
    [TestClass]
    public class LoginPresenterTest
    {
        [TestMethod]
        public void ShouldProperlyLogin()
        {
            //Given
            var loginView = new Mock<ILoginView>();
            var loginModel = new Mock<ILoginModel>();
            var session = new Mock<ISession>();
            var loginPresenter = new LoginPresenter(loginView.Object, loginModel.Object, session.Object);
            const int chosenConstituencyId = 2;
            //When

            loginView.Raise(login => login.LoginClicked += null, this, chosenConstituencyId);

            //Then
            session.VerifySet(sess => sess.ConstituencyId, Times.Once());
            loginView.Verify(logView => logView.Exit(), Times.Once);
            Assert.IsTrue(loginPresenter.ShowLogin());
        }

        [TestMethod]
        public void ShouldCancelLogin()
        {
            //Given
            var loginView = new Mock<ILoginView>();
            var loginModel = new Mock<ILoginModel>();
            var session = new Mock<ISession>();
            var loginPresenter = new LoginPresenter(loginView.Object, loginModel.Object, session.Object);
            //When
            loginView.Raise(login => login.CancelClicked += null, this, EventArgs.Empty);
            //Then
            loginView.Verify(logView => logView.Exit(), Times.Once);
            Assert.IsFalse(loginPresenter.ShowLogin());
        }

        [TestMethod]
        public void ShouldShowLoginForm()
        {
            //Given
            var loginView = new Mock<ILoginView>();
            var loginModel = new Mock<ILoginModel>();
            var session = new Mock<ISession>();
            var loginPresenter = new LoginPresenter(loginView.Object, loginModel.Object, session.Object);
            loginView.Setup(login => login.LoadConstituencies(It.IsAny<IEnumerable<Contracts.Constituency>>()));

            //When
            loginPresenter.ShowLogin();

            //Then
            loginView.Verify(login => login.LoadConstituencies(It.IsAny<IEnumerable<Contracts.Constituency>>()),
                Times.Once);
        }
    }
}
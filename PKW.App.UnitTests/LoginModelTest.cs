using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PKW.App.Models;
using PKW.Contracts;

namespace PKW.App.UnitTests
{
    [TestClass]
    public class LoginModelTest
    {
        [TestMethod]
        [TestCategory("Unit Test")]
        public void ShouldGetConstituencies()
        {
            //Given
            Mock<IVotingService> votingServiceMock = new Mock<IVotingService>();
            LoginModel loginModel = new LoginModel(votingServiceMock.Object);

            //When
            loginModel.GetConstituencies();

            //Then
            votingServiceMock.Verify(votingService => votingService.GetConstituencies(), Times.Once);
        }
    }
}
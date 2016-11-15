using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PKW.UITests.PageObjects;

namespace PKW.UITests
{
	[TestClass]
	public class VotingTest : TestSetup
	{
		[TestInitialize]
		public void VotingTestSetup()
		{
			var login = new Login();
			login.SelectConstituency(ObjectRepository.Login.Constituencies.Silesia);
			login.ClickLogin();
		}

		[TestMethod]
		[TestCategory("Voting")]
		[TestCategory("UI")]
		public void ShouldBeAbleToEnterVotesForAllCandidates()
		{
			var voting = new Voting();
			bool areVotesEntered = false;
			var listOfCandidates = voting.GetListOfCandidates();
			foreach (var candidate in listOfCandidates)
			{
				areVotesEntered = voting.SetVotesForCandidate(candidate, 2);
			}
			Assert.IsTrue(areVotesEntered);
		}

		[TestMethod]
		[TestCategory("Voting")]
		[TestCategory("Negative")]
		[TestCategory("UI")]
		public void ShouldNotBeAbleToEnterStringForVotes()
		{
			var voting = new Voting();
			bool areVotesEntered = false;
			var candidate = voting.GetFirstCandidate();
			areVotesEntered = voting.SetVotesForCandidate(candidate, "abba");
			Assert.IsTrue(!areVotesEntered);
		}


		[TestMethod]
		[TestCategory("Negative"), TestCategory("Voting"), TestCategory("UI")]
		public void ShouldNotBeAbleToSendNegativeValuesInInvalidVotes()
		{
			var voting = new Voting();
			voting.SetInvalidVotes("-10");
			voting.SendReport();
			Assert.IsTrue(voting.IsErrorMessagePresent());
		}

		[TestMethod]
		[TestCategory("Voting")]
		[TestCategory("Negative")]
		[TestCategory("UI")]
		public void ShouldNotBeAbleToSendNegativeValuesInIssuedBallots()
		{
			var voting = new Voting();
			voting.SetIssuedBallots("-10");
			voting.SendReport();
			Assert.IsTrue(voting.IsErrorMessagePresent());
		}

		[TestMethod]
		[TestCategory("Voting")]
		[TestCategory("Negative")]
		[TestCategory("UI")]
		public void ShouldNotBeAbleToSendStringValuesInIssuedBallots()
		{
			var voting = new Voting();
			voting.SetIssuedBallots("abba");
			voting.SendReport();
			Assert.IsTrue(voting.IsErrorMessagePresent());
		}
	}
}
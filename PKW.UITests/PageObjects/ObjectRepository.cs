using System.Diagnostics;
using TestStack.White.UIItems.Finders;

namespace PKW.UITests.PageObjects
{
    internal class ObjectRepository
    {
        public static ProcessStartInfo ApllicationPath = new ProcessStartInfo(@"..\..\..\PKW.App\bin\Debug\PKW.App.exe");
        public static string ApplicationProcessName = "PKW.App";

        public class Login
        {
            public const string WindowTitle = "Wybierz okręg wyborczy";
            public static SearchCriteria ConstituenciesList = SearchCriteria.ByAutomationId("cbConstituencies");
            public static SearchCriteria LoginButton = SearchCriteria.ByAutomationId("btnLogin");
            public static SearchCriteria CancelButton = SearchCriteria.ByAutomationId("btnCancel");

            public class Constituencies
            {
                public const string Silesia = "Okręg wyborczy numer 6";
            }
        }

        public class TestSetup
        {
            public class Service
            {
                public const string ServiceName = "/site:PKW.ControlCenter";
                public const string IssExpressPath = @"C:\Program Files (x86)\IIS Express\iisexpress.exe";
            }
        }

        public class Voting
        {
            public const string WindowTitle = "Manager OKW";
            public static SearchCriteria CandidatesList = SearchCriteria.ByAutomationId("dgvCandidates");
            public static SearchCriteria InvalidVotes = SearchCriteria.ByAutomationId("tbInvalidVotes");
            public static SearchCriteria IssuedBallots = SearchCriteria.ByAutomationId("tbIssuedBallots");
            public static SearchCriteria SendButton = SearchCriteria.ByAutomationId("btnSendVotes");
        }

        public class Report
        {
            public const string WindowTitle = "Manager OKW";
            public static SearchCriteria ReportTab = SearchCriteria.ByText("Raport");
            public static SearchCriteria ConstituenciesList = SearchCriteria.ByAutomationId("cbConstituencyFilter");
            public static SearchCriteria CandidatesList = SearchCriteria.ByAutomationId("dgvCandidates");
        }
    }
}
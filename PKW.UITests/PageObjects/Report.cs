using System;
using System.Collections.Generic;
using System.Linq;
using TestStack.White.InputDevices;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.TabItems;
using TestStack.White.UIItems.TableItems;

namespace PKW.UITests.PageObjects
{
    internal class Report : VotingApplication
    {
        private readonly TabPage _reportTab;
        private ComboBox _listOfConstituancies;
        private readonly Table _candidates;

        public Report()
            : base(ObjectRepository.Voting.WindowTitle)
        {
            _reportTab = MainWindow.Get<TabPage>(ObjectRepository.Report.ReportTab);
            
            //_candidates = MainWindow.Get<Table>(ObjectRepository.Report.CandidatesList);
        }

        private void LoadListOfConstituencies()
        {
            _listOfConstituancies = MainWindow.Get<ComboBox>(ObjectRepository.Report.ConstituenciesList);
        }


        public void SelectReportTab()
        {
            _reportTab.Click();
        }

        public bool CheckIsReportTabIsSelected()
        {
            return _reportTab.IsSelected;
        }

        public bool CheckIsConstituenciesListIsVisible()
        {
            LoadListOfConstituencies();
            return _listOfConstituancies.Visible;
        }

        //public void DisplayReportForSelectedCandidate(string candidate)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool CheckIfReportVisibleForSelectedCandidate()
        //{
        //    throw new NotImplementedException();
        //}

        //public void DisplayReportForSelectedConstituency(string constituency)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool CheckIfReportVisibleForSelectedConstituency()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
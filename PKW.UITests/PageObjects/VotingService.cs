using System;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using System.Text;
using System.Diagnostics;
using System.IO;


namespace PKW.UITests.PageObjects
{
    internal class VotingService : UiWrapper
    {
        public Process Service;

        public VotingService()
        {
            string arguments = ObjectRepository.TestSetup.Service.ServiceName;

            ProcessStartInfo info = new ProcessStartInfo(ObjectRepository.TestSetup.Service.IssExpressPath, arguments)
            {
                WindowStyle = ProcessWindowStyle.Hidden
            };

            Service = Process.Start(info);
        }

        public void Close()
        {
            Service.Close();
        }
    }
}
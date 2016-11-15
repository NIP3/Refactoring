using TestStack.White;
using TestStack.White.UIItems.WindowItems;

namespace PKW.UITests.PageObjects
{
    internal class VotingApplication : UiWrapper
    {
        public Application Application;

        public VotingApplication(string windowTitle = ObjectRepository.Login.WindowTitle)
        {
            Application = Application.AttachOrLaunch(ObjectRepository.ApllicationPath);
            MainWindow = Application.GetWindow(windowTitle);
        }

        public Window MainWindow { get; set; }

        public void Close()
        {
            Application.Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using PKW.App.Models;
using PKW.App.Presenters;

namespace PKW.App
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            IUnityContainer container = new UnityContainer();
            UnityBootstrapper.Register(container);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var loginPresenter = container.Resolve<ILoginPresenter>();
            if (loginPresenter.ShowLogin())
            {
                var con = container.Resolve<IConstituencyPresenter>();
                con.Show();
            }
            else
            {
                return;
            }
        }
    }
}
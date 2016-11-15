using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using PKW.App.Models;
using PKW.App.Presenters;
using PKW.App.Providers;
using PKW.App.Views;
using PKW.Contracts;

namespace PKW.App
{
    public class UnityBootstrapper
    {
        public static void Register(IUnityContainer container)
        {
            container.RegisterType<IConstituencyModel, ConstituencyModel>();
            container.RegisterType<IConstituencyView, ConstituencyView>();
            container.RegisterType<IConstituencyPresenter, ConstituencyPresenter>();

            container.RegisterType<IVotingPresenter, VotingPresenter>();
            container.RegisterType<IVotingView, VotingView>();

            container.RegisterType<ITabPresenter, VotingPresenter>("Voting");
            container.RegisterType<ITabPresenter, ReportPresenter>("Report");

            container.RegisterType<ILoginPresenter, LoginPresenter>();
            container.RegisterType<ILoginModel, LoginModel>();
            container.RegisterType<ILoginView, LoginForm>();

            container.RegisterType<IControlCenterFactory, ControlCenterFactory>(new ContainerControlledLifetimeManager());
            container.RegisterType<IVotingService>(
                new InjectionFactory(c => c.Resolve<IControlCenterFactory>().GetClient()));

            container.RegisterType<ISession, Session>(new ContainerControlledLifetimeManager());

            container.RegisterType<IEnumerable<ITabPresenter>>(new InjectionFactory(c => c.ResolveAll<ITabPresenter>()));
        }
    }
}
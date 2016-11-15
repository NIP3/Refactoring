using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using PKW.Contracts;

namespace PKW.App.Providers
{
    public class ControlCenterFactory : IControlCenterFactory

    {
        private const string EndpointConfigurationName = "PKWControlCenterEndPoint";

        public IVotingService GetClient()
        {
            var channelFactory = new ChannelFactory<IVotingService>(EndpointConfigurationName);
            var channel = channelFactory.CreateChannel();
            return channel;
        }
    }
}
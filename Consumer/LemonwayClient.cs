using Consumer.Models;
using System;
using System.ServiceModel;

namespace Consumer
{
    public class LemonwayClient
    {
        private static IContract _webserviceChallengeClient = null;
        private static readonly object lockInstance = new Object();
        private const string URI = "http://localhost:61445/Service.asmx";

        public LemonwayClient()
        { }

        private static IContract WebserviceChallengeClient
        {
            get
            {
                lock (lockInstance)
                {
                    if (_webserviceChallengeClient == null)
                    {
                        _webserviceChallengeClient = GetClientService();
                    }
                    return _webserviceChallengeClient;
                }
            }
        }

        private static IContract GetClientService()
        {
            var binding = new BasicHttpBinding();
            var endpoint = new EndpointAddress(new Uri(string.Format(URI, Environment.MachineName)));
            var channelFactory = new ChannelFactory<IContract>(binding, endpoint);
            return channelFactory.CreateChannel();
        }

        public int Fibonacci (int n)
        {
            try
            {
                return WebserviceChallengeClient.Fibonacci(n);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string XmlToJson(string xml)
        {
            try
            {
                return WebserviceChallengeClient.XmlToJson(xml);
            }
            catch (Exception)
            {
                throw;
            }
        }



    }
}
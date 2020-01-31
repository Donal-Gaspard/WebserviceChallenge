using System;
using System.ServiceModel;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hello World!");
                var binding = new BasicHttpBinding();
                var endpoint = new EndpointAddress(new Uri(string.Format("http://localhost:61445/Service.asmx", Environment.MachineName)));
                var channelFactory = new ChannelFactory<IContract>(binding, endpoint);
                var serviceClient = channelFactory.CreateChannel();
                var result = serviceClient.Fibonacci(10);
                Console.WriteLine("method result: {0}", result);
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}

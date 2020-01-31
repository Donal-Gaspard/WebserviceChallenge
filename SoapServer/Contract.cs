using Newtonsoft.Json;
using SoapServer.Exeptions;
using System;
using System.Xml;

namespace SoapServer
{
    public class Contract : IContract
    {
        private static readonly log4net.ILog _log =
        log4net.LogManager.GetLogger(typeof(Contract));

        private const int MIN_FIBONACCI_NUMBER = 1;
        private const int MAX_FIBONACCI_NUMBER = 999;
        private const string BAD_FORMAT_XML = "Bad Xml format";

        public int Fibonacci(int n)
        {
            _log.Info($"Call Fibonacci operation with arg {n}");
            if (  n < MIN_FIBONACCI_NUMBER  || n > MAX_FIBONACCI_NUMBER)
            {
                var error = new InvalidFibonacciNumberException("Invalid fibonacci number");
                _log.Error($"XmlToJson error : {BAD_FORMAT_XML}", error);
                throw error;
            }

            int[] Fib = new int[n + 1];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            _log.Info($"Fibonacci Result {Fib[n]}");

            return Fib[n];
        }

        public string XmlToJson(string xml)
        {
            _log.Info($"Call XmlToJson operation with arg {xml}");
            string jsonFormat = null;
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
               jsonFormat = JsonConvert.SerializeXmlNode(doc);
            }
            catch (Exception e)
            {
                _log.Error($"XmlToJson error : {BAD_FORMAT_XML}",e);
                return BAD_FORMAT_XML;

            }
            _log.Info($"XmlToJson Result {jsonFormat}");
            return jsonFormat;
        }
    }
}

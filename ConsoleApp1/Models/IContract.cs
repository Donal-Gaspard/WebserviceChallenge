using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    [ServiceContract]
    public interface IContract
    {
        [OperationContract]
        int Fibonacci(int n);

        [OperationContract]
        string XmlToJson(string xml);
    }
}

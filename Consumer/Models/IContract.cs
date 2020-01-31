using System.ServiceModel;

namespace Consumer.Models
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
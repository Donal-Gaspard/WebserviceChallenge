using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SoapServer.Exeptions
{
    [Serializable()]
    public class InvalidFibonacciNumberException : Exception, ISerializable
    {
        public InvalidFibonacciNumberException()
        {}

        public InvalidFibonacciNumberException(string message):base(message)
        {}

        public InvalidFibonacciNumberException(string message , Exception inner) : base(message, inner)
        {}

        protected InvalidFibonacciNumberException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
        {
            base.GetObjectData(serializationInfo, streamingContext);
        }
    }
}

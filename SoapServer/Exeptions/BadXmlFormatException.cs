using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SoapServer.Exeptions
{
    [Serializable]
    public class BadXmlFormatException : Exception, ISerializable
    {
        public BadXmlFormatException()
        {}

        public BadXmlFormatException(string message ) : base(message)
        {}

        public BadXmlFormatException(string message, Exception inner): base(message, inner)
        {}

        protected BadXmlFormatException(System.Runtime.Serialization.SerializationInfo serializationInfo, System.Runtime.Serialization.StreamingContext streamingContext)
        {
            base.GetObjectData(serializationInfo, streamingContext);
        }
    }
}

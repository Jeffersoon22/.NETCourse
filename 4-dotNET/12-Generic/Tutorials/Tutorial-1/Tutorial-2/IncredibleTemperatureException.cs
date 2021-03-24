using System;
using System.Runtime.Serialization;

namespace Tutorial_2
{
    [Serializable]
    internal class IncredibleTemperatureException : ApplicationException
    {
        public IncredibleTemperatureException()
        {
        }

        public IncredibleTemperatureException(string message) : base(message)
        {
        }

        public IncredibleTemperatureException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IncredibleTemperatureException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
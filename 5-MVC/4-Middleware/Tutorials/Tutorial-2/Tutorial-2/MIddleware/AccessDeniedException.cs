using System;
using System.Runtime.Serialization;

namespace Tutorial_2
{
    [Serializable]
    internal class AccessDeniedException : ApplicationException
    {
        public override string Message => "Your token is not valid";
        public AccessDeniedException()
        {
        }

        public AccessDeniedException(string message) : base(message)
        {
        }

        public AccessDeniedException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AccessDeniedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
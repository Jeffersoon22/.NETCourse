using System;
using System.Runtime.Serialization;

namespace Tutorial_2
{
    [Serializable]
    internal class PageNotFoundException : ApplicationException
    {
        public override string Message => "Page not found";
        public PageNotFoundException()
        {
        }

        public PageNotFoundException(string message) : base(message)
        {
        }

        public PageNotFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PageNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
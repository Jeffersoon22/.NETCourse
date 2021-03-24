using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Practice_2.Exceptions
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

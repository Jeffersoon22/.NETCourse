using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorials
{
    public class HttpService : IHttpService
    {

        public string SendResult(double result)
        {
            //imitate some HTTP interactions
            return "Result Ok";
        }
    }
}

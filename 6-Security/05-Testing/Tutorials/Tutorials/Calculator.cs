using System;
using System.Collections.Generic;
using System.Text;

namespace Tutorials
{
    public class Calculator : ICalculator
    {
        private readonly IHttpService _httpService;

        public Calculator(IHttpService httpService)
        {
            _httpService = httpService; 
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Substract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            var result =  a * b;

            var isSent = _httpService.SendResult(result);
            return result;
        }
        public double Divide(double a, double b)
        {
            return a / b;
        }

       
    }
}

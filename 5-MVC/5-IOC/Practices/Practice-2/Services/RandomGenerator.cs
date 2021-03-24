using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2.Services
{
    public class RandomGenerator : IGenerator
    {
        public int GenerateNegativeIntegerNumber()
        {
            Random rand = new Random();
            var result = rand.Next(int.MinValue,0);
            return result;
        }

        public int GeneratePositiveIntegerNumber()
        {
            Random rand = new Random();
            var result = rand.Next(1,int.MaxValue);
            return result;
        }

        public string GenerateString(int length)
        {
            byte[] stringBytes = new byte[length];
            Random rand = new Random();

            for (int i = 0; i < length; i++)
            {
                stringBytes[i] = (byte)rand.Next('a','z');
            }

            string result = Encoding.UTF8.GetString(stringBytes);
            return result;

        }
    }
}

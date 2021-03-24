using System;

namespace NumberHelper
{
    public class Numberhelper
    {
        public int IncreaseCoutner(int value)
        {
            return ++value;
        }

        public int RootOfNumver(int value)
        {
            return (int)Math.Sqrt(value);
        }

        public int SquareNumber(int value)
        {
            return value * value;
        }
    }
}
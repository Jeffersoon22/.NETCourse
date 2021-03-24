using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Tutorial_1
{
    public class Point <T>
    {

        public Point(T x, T y)
        {
            X = x;
            Y = y;
        }
        public T X { get; set; }
        public  T Y { get; set; }

        public Point<T> ResetPoint()
        {
            return new Point<T> (default,default);

        }

        public override string ToString()
        {
            return $"[{X}, {Y}]";
        }

    }
}

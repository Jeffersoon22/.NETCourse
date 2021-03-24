using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_1
{
    class Point
    {
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"[{X}, {Y}]";
        }

        
        public static Point operator ++(Point p1)
        {
            var xResult = ++p1.X;
            var yResult = ++p1.Y;

            return new Point(xResult, yResult);
        }

        public static Point operator --(Point p1)
        {
            return new Point(p1.X - 1, p1.Y - 1);
        }

        public static Point operator *(Point p1, int value)
        {
            var xResult = p1.X * value;
            var yResult = p1.Y * value;

            return new Point(xResult, yResult);
        }
        
    }
}

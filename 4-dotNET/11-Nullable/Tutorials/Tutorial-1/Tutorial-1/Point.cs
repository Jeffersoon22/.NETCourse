using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Tutorial_1
{
    public class Point 
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

        public static Point operator -(Point p1, Point p2)
        {
            var xResult = p1.X - p2.X;
            var yResult = p1.Y - p2.Y;

            return new Point(xResult, yResult);
        }

        public static Point operator + (Point p1, Point p2)
        {
            var xResult = p1.X + p2.X;
            var yResult = p1.Y + p2.Y;

            return new Point(xResult, yResult);
        }
    }
}

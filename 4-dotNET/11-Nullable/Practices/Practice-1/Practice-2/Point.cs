using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_2
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
        public static bool operator ==(Point p1, Point p2)
        {
            if (p1.X == p2.X & p1.Y == p2.Y)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Point p1, Point p2)
        {
            if (p1.X != p2.X & p1.Y != p2.Y)
            {
                return true;
            }
            return false;
        }

        public static bool operator <(Point p1, Point p2)
        {
            if (p1.X < p2.X || p1.Y < p2.Y)
            {
                return true;
            }
            return false;
        }

        public static bool operator >(Point p1, Point p2)
        {
            if (p1.X > p2.X || p1.Y > p2.Y)
            {
                return true;
            }
            return false;
        }

        public static bool operator <=(Point p1, Point p2)
        {
            if (p1.X <= p2.X || p1.Y <= p2.Y)
            {
                return true;
            }
            return false;
        }

        public static bool operator >=(Point p1, Point p2)
        {
            if (p1.X >= p2.X || p1.Y >= p2.Y)
            {
                return true;
            }
            return false;
        }
    }
}

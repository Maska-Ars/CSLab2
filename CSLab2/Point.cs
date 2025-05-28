using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace CSLab2
{
    public class Point(double x, double y)
    {
        private double _x = x;

        public double X
        {
            get => _x;
            set => _x = value;
        }

        private double _y = y;

        public double Y
        {
            get => _y;
            set => _y = value;
        }

        // 2
        public double Distance(double x, double y)
        {
            return Math.Sqrt(Math.Pow(_x - x, 2) + Math.Pow(_y - y, 2));
        }

        // 2
        public double Distance(Point otherPoint)
        {
            return Math.Sqrt(Math.Pow(_x - otherPoint.X, 2) + Math.Pow(_y - otherPoint.Y, 2));
        }

        // 2
        public override string ToString()
        {
            return $"x: {_x}, y: {_y}";
        }

        // 3
        public static Point operator ++(Point point)
        {
            return new Point(point.X + 1, point.Y);
        }

        // 3
        public static Point operator --(Point point)
        {
            return new Point(point.X - 1, point.Y);
        }

        // 3 явная
        public static explicit operator int(Point point)
        {
            return (int)point.Y;
        }

        // 3 неявная
        public static implicit operator double(Point point)
        {
            return point.Y;
        }

        // 3
        public static double operator +(Point point1, Point point2)
        {
            return point1.Distance(point2);
        }

        // 3
        public static Point operator +(Point point, int x)
        {
            return new Point(point.X + x, point.Y);
        }

        // 3
        public static Point operator +(int x, Point point)
        {
            return new Point(point.X + x, point.Y);
        }
    }
}
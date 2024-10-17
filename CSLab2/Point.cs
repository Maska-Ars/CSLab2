using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

class Point
{
    private double x { get; set; }

    private double y { get; set; }

    public Point(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    // 2
    public double Distance(double x, double y)
    {
        return Math.Sqrt(Math.Pow(this.x-x, 2)+ Math.Pow(this.y - y, 2));
    }

    // 2
    public double Distance(Point p)
    {
        return Math.Sqrt(Math.Pow(this.x - p.x, 2) + Math.Pow(this.y - p.y, 2));
    }

    // 2
    public override string ToString()
    {
        return $"x: {x}, y: {y}";
    }

    // 3
    public static Point operator ++(Point p)
    {
        return new Point(p.x + 1, p.y);
    }

    // 3
    public static Point operator --(Point p)
    {
        return new Point(p.x - 1, p.y);
    }

    // 3 явная
    public static implicit operator int(Point p)
    {
        return (int)p.y;
    }

    // 3 неявная
    public static explicit operator double(Point p)
    {
        return p.y;
    }

    // 3
    public static double operator +(Point p1, Point p2)
    {
        return p1.Distance(p2);
    }

    // 3
    public static Point operator +(Point p, int x)
    {
        return new Point(p.x + x, p.y);
    }

    // 3
    public static Point operator +(int x, Point p)
    {
        return new Point(p.x + x, p.y);
    }
}


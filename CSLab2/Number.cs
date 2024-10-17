using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Number
{
    private protected int x;
    private protected int y;
    private protected int z;

    public Number(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public Number(Number n)
    {
        this.x = n.x;
        this.y = n.y;
        this.z = n.z;
    }

    public int Max()
    {
        if (x > y && x > z)
        {
            return x;
        }
        else if (y > z)
        {
            return y;
        }
        else
        {
            return z;
        }
    }

    public override string ToString()
    {
        return $"x: {x}, y: {y}, z: {z}";
    }
}

class Triangle : Number
{

    public Triangle(int x, int y, int z) : base(x, y, z) { }

    public int Perimeter()
    {
        return x + y + z;
    }

    public double Square()
    {
        double p = this.Perimeter() / 2;
        return Math.Sqrt(p * (p - this.x) * (p - this.y) * (p - this.z));
    }
}
namespace CSLab2
{
    public class Triangle(int x, int y, int z) : Number(x, y, z)
    {
        public int Perimeter()
        {
            return _x + _y + _z;
        }

        public double Square()
        {
            double halfPerimeter = Perimeter() / 2.0;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - _x) * (halfPerimeter - _y) * (halfPerimeter - _z));
        }
    }
}

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

        public double Distance(double x, double y)
        {
            return Math.Sqrt(Math.Pow(_x - x, 2) + Math.Pow(_y - y, 2));
        }

        public double Distance(Point otherPoint)
        {
            return Math.Sqrt(Math.Pow(_x - otherPoint.X, 2) + Math.Pow(_y - otherPoint.Y, 2));
        }

        public override string ToString()
        {
            return $"x: {_x}, y: {_y}";
        }

        public static Point operator ++(Point point)
        {
            return new Point(point.X + 1, point.Y);
        }

        public static Point operator --(Point point)
        {
            return new Point(point.X - 1, point.Y);
        }

        public static explicit operator int(Point point)
        {
            return (int)point.Y;
        }

        public static implicit operator double(Point point)
        {
            return point.Y;
        }

        public static double operator +(Point point1, Point point2)
        {
            return point1.Distance(point2);
        }

        public static Point operator +(Point point, int x)
        {
            return new Point(point.X + x, point.Y);
        }

        public static Point operator +(int x, Point point)
        {
            return new Point(point.X + x, point.Y);
        }
    }
}
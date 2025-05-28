namespace CSLab2
{
    public class Number
    {
        protected int _x;

        public int X
        {
            get => _x;
            set => _x = value;
        }

        protected int _y;

        public int Y
        {
            get => _y;
            set => _y = value;
        }

        protected int _z;

        public int Z
        {
            get => _z;
            set => _z = value;
        }

        public Number(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public Number(Number otherNumber)
        {
            _x = otherNumber.X;
            _y = otherNumber.Y;
            _z = otherNumber.Z;
        }

        public int Max()
        {
            if (_x > _y && _x > _z)
            {
                return _x;
            }
            else if (_y > _z)
            {
                return _y;
            }
            else
            {
                return _z;
            }
        }

        public override string ToString()
        {
            return $"x: {_x}, y: {_y}, z: {_z}";
        }
    }
}
using System;
namespace Raso.src
{
    [Serializable]
    public class DirVector
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public DirVector(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static DirVector operator *(DirVector d1, double number)
        {
            return new DirVector(d1.X * number, d1.Y * number);
        }

        public override bool Equals(object obj)
        {
            return obj is DirVector vector &&
                   X == vector.X &&
                   Y == vector.Y;
        }

    }
}
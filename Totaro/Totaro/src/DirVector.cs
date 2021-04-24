using System;
namespace Totaro.src
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

        public static DirVector operator +(DirVector d1, DirVector d2)
        {
            return new DirVector(d1.X + d2.X, d1.Y + d2.Y);
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

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        public override string ToString()
        {
            return $"DirVector( {X} , {Y} )";
        }
    }
}

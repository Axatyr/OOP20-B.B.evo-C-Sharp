using System;
namespace Totaro.src
{
    [Serializable]
    public class Position
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Position(double x, double y)
        {
            X = x;
            Y = y;
        }

        public static Position operator +(Position p1, DirVector p2)
        {
            return new Position(p1.X + p2.X, p1.Y + p2.Y);
        }

        public static Position operator -(Position p1, Position p2)
        {
            return new Position(p1.X - p2.X, p1.Y - p2.Y);
        }

        public override bool Equals(object obj)
        {
            return obj is Position position &&
                   X == position.X &&
                   Y == position.Y;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(X, Y);
        }

        public override string ToString()
        {
            return $"Position( {X} , {Y} )";
        }
    }
}

using System;

namespace Raso.src
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

        public static Position operator +(Position pos, DirVector dir)
        {
            return new Position(pos.X + dir.X, pos.Y + dir.Y);
        }

        public override bool Equals(object obj)
        {
            return obj is Position position &&
                   X == position.X &&
                   Y == position.Y;
        }
    }
}
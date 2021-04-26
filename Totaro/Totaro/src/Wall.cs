using System;
namespace Totaro.src
{
    public class Wall
    {
        public double width { get; private set; }
        public double height { get; private set; }

        public Wall(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
    }
}

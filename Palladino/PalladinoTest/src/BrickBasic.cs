using System;
using System.Collections.Generic;
using System.Text;

namespace Palladino.src
{
    class BrickBasic
    {
        private readonly Position pos;
        private readonly int height;
        private readonly int width;
        private readonly int durablitiy;
        private readonly string texturePath;

        public BrickBasic(Position pos, int height, int width, int durablitiy, string texturePath)
        {
            this.pos = pos;
            this.height = height;
            this.width = width;
            this.durablitiy = durablitiy;
            this.texturePath = texturePath;
        }

        public Position BrickPos()
        {
            return pos;
        }

    }
}

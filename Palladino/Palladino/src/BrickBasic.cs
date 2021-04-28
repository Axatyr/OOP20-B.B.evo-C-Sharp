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
        private readonly BrickStatus status;
        private readonly int durability;
        private string texturePath;
        private readonly static string notDestructibleTexture = "notDestructibleBrickPath";
        private readonly static string destructiblePath = "defaultBrickTexturePath";
        private readonly static string powerupPath = "defaultPowerupTexturePath";

        public BrickBasic(Position pos, int height, int width, BrickStatus status, int durability, string texturePath)
        {
            this.pos = pos;
            this.height = height;
            this.width = width;
            this.status = status;
            this.durability = durability;
            this.texturePath = texturePath;
        }

        /// <returns>position of brick</returns>
        public Position BrickPos()
        {
            return pos;
        }

        /// <returns>return path of brick resource</returns>
        public static string GetTextureNotDestructible()
        {
            return notDestructibleTexture;
        }

        /// <returns>return path of brick resource</returns>
        public static string GetDefaultBrickTexturePath()
        {
            return destructiblePath;
        }

        /// <returns>return path of brick resource</returns>
        public static string GetDefaultPowerupTexturePath()
        {
            return powerupPath;
        }
    }
}

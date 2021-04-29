using System;
using System.Collections.Generic;
using System.Text;

namespace Raso.src
{
    public enum BrickStatus
    {
        NOT_DESTRUCTIBLE,
        DESTRUCTIBLE,
        DROP_POWERUP,
        EMPTY
    }
    [Serializable]
    public class Brick : GameObject
    {
        public int Durability { get; set; }
        private String texturePath { get; set; }
        public BrickStatus Status { get; set; }

        private Brick(Position pos, int height, int width, int durability, BrickStatus status, String textPath) :
        base(pos, new DirVector(0,0), 0, height, width, new ComponentPhysicsEmpty(), new ComponentInputEmpty())
        {
            texturePath = textPath;
            Durability = durability;
            Status = status;
        }
        public override void UpdateInput(IControllerInput controller)
        {
            base.Input.Update(this, controller);
        }

        public override void UpdatePhysics(int timeElapsed)
        {
            base.Physics.Update(timeElapsed, this);
        }

        public PowerUp dropPowerUp()
        {
            return new PowerUp(this.Position, this.Height, this.Width, texturePath);
        }

        public void DecreaseDurability(int ballDamage)
        {
            this.Durability -= ballDamage;
        }

        public class Builder
        {
            private Position position;
            private int height;
            private int width;
            private int durability;
            private BrickStatus status;
            private String texturePath;
            public Builder Texture(String texturePath)
            {
                this.texturePath = texturePath;
                return this;
            }

            public Builder Position(Position pos)
            {
                this.position = pos;
                return this;
            }

            public Builder Height(int height)
            {
                this.height = height;
                return this;
            }

            public Builder Width(int width)
            {
                this.width = width;
                return this;
            }

            public Builder Durability(int durability)
            {
                this.durability = durability;
                return this;
            }

            public Builder Status(BrickStatus status)
            {
                this.status = status;
                return this;
            }

            public Brick Build()
            {
                if (this.durability <= 0 || this.height <= 0 || this.width <= 0 || this.position == null || this.texturePath == null)
                {
                    throw new InvalidOperationException();
                }
                return new Brick(this.position, this.height, this.width, this.durability, this.status, this.texturePath);
            }
        }
    }
}

using System;
namespace Totaro.src
{
    public class Ball : GameObject
    {
        private String TexturePath { get; set; }

        private Ball(Position pos, DirVector dir, double speed, int height, int width, String tPath) :
            base(pos, dir, speed, height, width, new BallComponentPhysics(), new ComponentInputEmpty())
        {
            TexturePath = tPath;
        }

        public override void UpdateInput(IControllerInput controller)
        {
            base.Input.Update(this, controller);
        }

        public override void UpdatePhysics(int timeElapsed)
        {
            base.Phy.Update(timeElapsed, this);
        }

        public void SetDirOnY()
        {
            this.Dir = new DirVector(this.Dir.X, -this.Dir.Y);
        }

        public void SetDirOnX()
        {
            this.Dir = new DirVector(-this.Dir.X, this.Dir.Y);
        }

        public class Builder
        {
            private Position pos;
            private DirVector dir;
            private int height;
            private int width;
            private double speed;
            private String tPath;

            public Builder Position(Position pos)
            {
                this.pos = pos;
                return this;
            }

            public Builder Direction(DirVector dir)
            {
                this.dir = dir;
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

            public Builder Speed(double speed)
            {
                this.speed = speed;
                return this;
            }

            public Builder Path(String path)
            {
                this.tPath = path;
                return this;
            }

            public Ball Build()
            {
                if (this.height <= 0 || this.pos == null || this.speed < 0 || this.width <= 0 || this.tPath == null)
                {
                    throw new InvalidOperationException();
                }
                return new Ball(this.pos, this.dir, this.speed, this.height, this.width, this.tPath);
            }
        }
    }
}

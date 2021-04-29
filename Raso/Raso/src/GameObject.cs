using System;

namespace Raso.src
{
    [Serializable]
    public abstract class GameObject
    {
        public GameObject(Position pos, DirVector dir, double speed, int height, int width, IComponentPhysics phy, IComponentInput input)
        {
            Speed = speed;
            Direction = dir;
            Position = pos;
            Height = height;
            Width = width;
            Physics = phy;
            Input = input;
        }

        public double Speed { get; set; }

        public DirVector Direction { get; set; }

        public Position Position { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public IComponentInput Input { get; private set; }

        public IComponentPhysics Physics { get; private set; }

        public abstract void UpdateInput(IControllerInput controller);

        public abstract void UpdatePhysics(int timeElapsed);
    }
}
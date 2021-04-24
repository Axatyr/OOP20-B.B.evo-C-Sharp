using System;
namespace Totaro.src
{
    [Serializable]
    public abstract class GameObject : IGameObject
    {
        public GameObject(Position pos, DirVector dir, double speed, int height, int width, IComponentPhysics phy, IComponentInput input)
        {
            Speed = speed;
            Dir = dir;
            Position = pos;
            Height = height;
            Width = width;
            Phy = phy;
            Input = input;
        }

        public double Speed { get; set; }

        public DirVector Dir { get; set; }

        public Position Position { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public IComponentInput Input { get; private set; }

        public IComponentPhysics Phy { get; private set; }

        public abstract void UpdateInput(IControllerInput controller);

        public abstract void UpdatePhysics(int timeElapsed);
    }
}

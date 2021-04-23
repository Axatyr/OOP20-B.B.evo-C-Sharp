using System;
namespace OOP20.src
{
    public abstract class GameObject : IGameObject
    {
        public GameObject(Position pos, DirVector dir, double speed, int height, int width, String tPath)
        {
            Speed = speed;
            Dir = dir;
            Position = pos;
            Height = height;
            Width = width;
        }

        public double Speed { get; set; }
        public DirVector Dir { get; set; }
        public Position Position { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public abstract void UpdateInput(IControllerInput controller);

        public abstract void UpdatePhysics(int timeElapsed);
    }
}

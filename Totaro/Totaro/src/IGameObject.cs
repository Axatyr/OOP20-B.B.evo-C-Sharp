using System;
namespace Totaro.src
{
    public interface IGameObject
    {
        double Speed { get; set; }

        DirVector Dir { get; set; }

        Position Position { get; set; }

        int Height { get; set; }

        int Width { get; set; }

        void UpdateInput(IControllerInput controller);

        void UpdatePhysics(int timeElapsed);
    }
}

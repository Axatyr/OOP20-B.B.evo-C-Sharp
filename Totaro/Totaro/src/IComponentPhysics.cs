using System;
namespace Totaro.src
{
    public interface IComponentPhysics
    {
        void Update(int timeElapsed, IGameObject obj);
    }
}

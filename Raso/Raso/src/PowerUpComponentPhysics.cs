using System;
namespace Raso.src
{
    [Serializable]
    public class PowerUpComponentPhysics : IComponentPhysics
    {
        public void Update(int timeElapsed, GameObject gameObj)
        {
            PowerUp powerUp = (PowerUp)gameObj;
            Position pos = powerUp.Position;
            DirVector dir = powerUp.Direction;
            powerUp.Position = pos + (dir * (timeElapsed * powerUp.Speed));
        }
    }
}

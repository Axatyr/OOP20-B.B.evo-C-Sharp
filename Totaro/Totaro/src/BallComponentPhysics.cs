using System;
namespace Totaro.src
{
    [Serializable]
    public class BallComponentPhysics : IComponentPhysics
    {
        public void Update(int timeElapsed, IGameObject obj)
        {
            Ball ball = (Ball)obj;
            Position pos = ball.Position;
            DirVector dir = ball.Dir;
            ball.Position = pos + (dir * (timeElapsed * ball.Speed));
        }
    }
}

using System;
using System.Collections.Generic;

namespace Totaro.src
{
    public class GameBoard
    {
        private HashSet<Ball> balls;
        private Wall wall;
        public GameBoard(Wall wall)
        {
            this.wall = wall;
            this.balls = new HashSet<Ball>();
        }

        public void SetBalls(HashSet<Ball> balls)
        {
            this.balls.Clear();

            foreach (Ball ball in balls)
            {
                this.balls.Add(ball);
            }
        }

        public HashSet<IGameObject> GetSceneEntity()
        {
            HashSet<IGameObject> ent = new HashSet<IGameObject>();

            foreach (Ball ball in balls)
            {
                ent.Add(ball);
            }
            return ent;
        }

        public void UpdateState(int timeElapsed)
        {
            foreach (GameObject obj in this.GetSceneEntity())
            {
                obj.UpdatePhysics(timeElapsed);
            }
        }
    }
}

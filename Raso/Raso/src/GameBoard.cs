using System.Collections.Generic;

namespace Raso.src
{
    public class GameBoard
    {
        private HashSet<PowerUp> pwUps;
        private HashSet<Brick> bricks;
        public GameBoard()
        {
            this.pwUps = new HashSet<PowerUp>();
            this.bricks = new HashSet<Brick>();
        }

        public void SetPwUps(HashSet<PowerUp> pwUps)
        {
            this.pwUps.Clear();

            foreach (PowerUp pwUp in pwUps)
            {
                this.pwUps.Add(pwUp);
            }
        }

        public void SetBricks(HashSet<Brick> bricks)
        {
            this.bricks.Clear();

            foreach (Brick brick in bricks)
            {
                this.bricks.Add(brick);
            }
        }

        public void UpdateState(int timeElapsed)
        {
            foreach (GameObject obj in this.GetSceneEntities())
            {
                obj.UpdatePhysics(timeElapsed);
            }
        }

        public HashSet<GameObject> GetSceneEntities()
        {
            HashSet<GameObject> gameObjects = new HashSet<GameObject>();

            foreach (PowerUp pwUp in pwUps)
            {
                gameObjects.Add(pwUp);
            }
            foreach (Brick brick in bricks)
            {
                gameObjects.Add(brick);
            }
            return gameObjects;
        }

        
    }
}
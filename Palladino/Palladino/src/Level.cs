using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palladino.src
{
    class Level
    {
        private readonly string levelName;
        private readonly ISet<BrickBasic> bricks;
        private readonly PersonalSounds music;
        private readonly BackgroundTexture background;
        private readonly BallTexture ball;
        private readonly PaddleTexture paddle;

        public Level(string levelName, ISet<BrickBasic> bricks, PersonalSounds music, BackgroundTexture background, BallTexture ball, PaddleTexture paddle)
        {
            this.levelName = levelName;
            this.bricks = bricks;
            this.music = music;
            this.background = background;
            this.ball = ball;
            this.paddle = paddle;
        }

        /// <returns> the pos of brick </return>
        public ISet<BrickBasic> GetBrick()
        {
            return bricks;
        }

        /// <returns> name of level </returns>
        public string GetLevelName()
        {
            return this.levelName;
        }

        /// <returns> music path</returns>
        public PersonalSounds GetMusic()
        {
            return music;
        }

        /// <returns> background path</returns>
        public BackgroundTexture GetBackground()
        {
            return background;
        }

        /// <returns> ball path</returns>
        public BallTexture GetBallTexture()
        {
            return ball;
        }

        /// <returns> paddle path</returns>
        public PaddleTexture GetPaddleTexture()
        {
            return paddle;
        }

        /// <summary>
        /// check if levels are the same
        /// </summary>
        /// <param name="obj">level refers</param>
        /// <returns>true if equal, false otherwise</returns>
        public bool EqualLevel(Level obj)
        {
            if (obj is Level level && obj.levelName == level.levelName &&
                obj.bricks == level.bricks && obj.music == level.music &&
                obj.background == level.background && obj.ball == level.ball &&
                obj.paddle == level.paddle)
            {
                return true;
            }
            return false;
                   
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(levelName, bricks, music, background, ball, paddle);
        }
    }
}

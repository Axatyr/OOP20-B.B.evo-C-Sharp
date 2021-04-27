using System;
using System.Collections.Generic;
using Palladino.src;

namespace Palladino.src
{
    [Serializable]
    public class Level
    {
        private readonly string levelName;
        private readonly BrickBasic bricks;
        private readonly PersonalSounds music;
        private readonly BackgroundTexture background;
        private readonly BallTexture ball;
        private readonly PaddleTexture paddle;

        /// <summary>
        /// Set brick variable
        /// </summary>
        private readonly Position pos = new Position(0, 0);
        private readonly int height = 1;
        private readonly int width = 1;
        private readonly int durability = 3;
        private readonly string texturePath = "brickTexture";

        public Level(string levelName)
        {
            this.levelName = levelName;
            this.bricks = new BrickBasic(pos, height, width, durability, texturePath);
            this.music = new PersonalSounds();
            this.background = new BackgroundTexture();
            this.ball = new BallTexture();
            this.paddle = new PaddleTexture();
        }

        /// <returns> the pos of brick </return>
        public Position GetBricks()
        {
            return bricks.BrickPos();
        }

        /// <returns> name of level </returns>
        public string GetLevelName()
        {
            return this.levelName;
        }

        /// <returns> music path</returns>
        public string GetMusic()
        {
            return music.GetMusicPath();
        }

        /// <returns> background path</returns>
        public string GetBackground()
        {
            return background.GetBackgroundPath();
        }

        /// <returns> ball path</returns>
        public string GetBallTexture()
        {
            return ball.GetBallPath();
        }

        /// <returns> paddle path</returns>
        public string GetPaddleTexture()
        {
            return paddle.GetPaddlePath();
        }



        public override bool Equals(object obj)
        {
            return obj is Level level &&
                   levelName == level.levelName &&
                   EqualityComparer<BrickBasic>.Default.Equals(bricks, level.bricks) &&
                   EqualityComparer<PersonalSounds>.Default.Equals(music, level.music) &&
                   EqualityComparer<BackgroundTexture>.Default.Equals(background, level.background) &&
                   EqualityComparer<BallTexture>.Default.Equals(ball, level.ball) &&
                   EqualityComparer<PaddleTexture>.Default.Equals(paddle, level.paddle);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(levelName, bricks, music, background, ball, paddle);
        }
    }
}

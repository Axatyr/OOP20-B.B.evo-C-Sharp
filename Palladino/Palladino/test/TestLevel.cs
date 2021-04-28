using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palladino.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palladino.test
{
    [TestClass]
    public class TestLevel
    {
        /// <summary>
        /// Initiate the variable for create level
        /// </summary>
        private static readonly string levelName = "ProvaLivello";
        private readonly ISet<BrickBasic> brick = new HashSet<BrickBasic>();
        private static readonly BackgroundTexture background = new BackgroundTexture("backgroundPath", "backgroundTheme");
        private static readonly PersonalSounds music = new PersonalSounds("musicPath", "musicTheme");
        private static readonly BallTexture ball = new BallTexture("ballPath", "ballTheme");
        private static readonly PaddleTexture paddle = new PaddleTexture("paddlePath", "paddleTheme");
        private static readonly int numBrick = 10;

        /// <summary>
        /// Create a set of num bricks
        /// </summary>
        /// <param name="num"></param>
        public void AddBrick(int num)
        {
            int i;
            int x = 0, y = 0;
            int height = 1;
            int width = 1;
            BrickStatus status = BrickStatus.destructible;
            int durability = 3;
            string texturePath = "brickPath";

            for (i = 0; i < num; i++)
            {
                brick.Add(new BrickBasic(new Position(x, y), height, width, status, durability, texturePath));
                x++;
                y++;
            }
        }

        /// <summary>
        /// Test brick creation and test right position
        /// </summary>
        [TestMethod]
        public void BrickCreation()
        {
            AddBrick(numBrick);
            Assert.AreEqual(numBrick, brick.Count);
            int x = 0;
            int y = 0;
            BrickBasic brickTest = brick.First();
            Assert.AreEqual(new Position(x, y), brickTest.BrickPos());

            x = numBrick - 1;
            y = numBrick - 1;
            brickTest = brick.Last();

            Assert.AreEqual(new Position(x, y), brickTest.BrickPos());
        }

        /// <summary>
        /// Test the level creation
        /// </summary>
        [TestMethod]
        public void LevelCreation()
        {
            AddBrick(numBrick);
            Level level = new Level(levelName, brick, music, background, ball, paddle);

            Assert.AreEqual(levelName, level.GetLevelName());
            Assert.AreEqual(music, level.GetMusic());
            Assert.AreEqual(background, level.GetBackground());
            Assert.AreEqual(ball, level.GetBallTexture());
            Assert.AreEqual(paddle, level.GetPaddleTexture());
            Assert.AreEqual(brick, level.GetBrick());
        }
    }
}


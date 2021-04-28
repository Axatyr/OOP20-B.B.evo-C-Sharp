using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palladino.src;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Palladino.test
{
    [TestClass]
    public class TestLevelBuilder
    {
        /// <summary>
        /// Create 2 level, one with builder and one with constructor, test if they have same object inside
        /// </summary>
        [TestMethod]
        public void TestBuilder()
        {
            LevelBuilder levelBuilder = new LevelBuilder();
            //Setup brick
            int x = 4;
            int y = 4;
            BrickStatus state = BrickStatus.destructible;
            int durability = 1;
            //Setup variable of level
            string levelName = "level1";
            PersonalSounds music = new PersonalSounds("musicPath", "musicTheme");
            BackgroundTexture background = new BackgroundTexture("backgroundPath", "backgroundTheme");
            BallTexture ball = new BallTexture("ballPath", "ballTheme");
            PaddleTexture paddle = new PaddleTexture("paddlePath", "paddleTheme");

            //Create level with levelBuilder
            levelBuilder.brickSelected(x, y, state, durability);
            levelBuilder.setLevelName(levelName);
            levelBuilder.SetMusic(music.GetMusicPath(), music.GetMusicTheme());
            levelBuilder.SetBackGround(background.GetBackgroundPath(), background.GetBackgroundTheme());
            levelBuilder.SetBall(ball.GetBallPath(), ball.GetBallTheme());
            levelBuilder.setPaddle(paddle.GetPaddlePath(), paddle.GetPaddleTheme());
            Level level = levelBuilder.Build();

            //Create level with classic constructor
            int height = 1, width = 1;
            ISet<BrickBasic> brick = new HashSet<BrickBasic>();
            brick.Add(new BrickBasic(new Position(x-1, y-1), height, width, state, durability, BrickBasic.GetDefaultBrickTexturePath()));
            Level levelTest = new Level(levelName, brick, music, background, ball, paddle);

            //Check if all parameters are the same
            Assert.AreEqual(levelTest.GetLevelName(), level.GetLevelName());

            Assert.AreEqual(levelTest.GetBackground().GetBackgroundPath(), level.GetBackground().GetBackgroundPath());
            Assert.AreEqual(levelTest.GetBackground().GetBackgroundTheme(), level.GetBackground().GetBackgroundTheme());

            Assert.AreEqual(levelTest.GetMusic().GetMusicPath(), level.GetMusic().GetMusicPath());
            Assert.AreEqual(levelTest.GetMusic().GetMusicTheme(), level.GetMusic().GetMusicTheme());

            Assert.AreEqual(levelTest.GetBallTexture().GetBallPath(), level.GetBallTexture().GetBallPath());
            Assert.AreEqual(levelTest.GetBallTexture().GetBallTheme(), level.GetBallTexture().GetBallTheme());

            Assert.AreEqual(levelTest.GetPaddleTexture().GetPaddlePath(), level.GetPaddleTexture().GetPaddlePath());
            Assert.AreEqual(levelTest.GetPaddleTexture().GetPaddleTheme(), level.GetPaddleTexture().GetPaddleTheme());
            //Check if levels are equals
            Assert.IsTrue(levelTest.EqualLevel(level));
        }
    }
}

using NUnit.Framework;
using Totaro.src;
using System;
using System.Collections.Generic;

namespace Totaro
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FailBallCreation()
        {
            Ball.Builder ball = new Ball.Builder().Position(null);
            Assert.Throws<InvalidOperationException>(() => ball.Build());

            ball.Position(new Position(10, 10)).Direction(null);
            Assert.Throws<InvalidOperationException>(() => ball.Build());

            ball.Position(new Position(10, 10)).Direction(new DirVector(1, 0)).Height(-1);
            Assert.Throws<InvalidOperationException>(() => ball.Build());

            ball.Position(new Position(10, 10)).Direction(new DirVector(1, 0)).Height(10).Width(-1);
            Assert.Throws<InvalidOperationException>(() => ball.Build());

            ball.Position(new Position(10, 10)).Direction(new DirVector(1, 0)).Height(10).Width(1).Path(null);
            Assert.Throws<InvalidOperationException>(() => ball.Build());
        }

        [Test]
        public void BallCreation()
        {
            Ball ball = new Ball.Builder().Position(new Position(10, 10))
                                          .Direction(new DirVector(0, 1))
                                          .Height(10)
                                          .Width(10)
                                          .Speed(10)
                                          .Path("prova")
                                          .Build();
            Assert.AreEqual(new Position(10, 10), ball.Position);
            Assert.AreEqual(new DirVector(0, 1), ball.Dir);
            Assert.AreEqual(10, ball.Speed);
            Assert.AreEqual(10, ball.Height);
            Assert.AreEqual(10, ball.Width);
        }

        [Test]
        public void BallMovement()
        {
            GameBoard board = new GameBoard(new Wall(100, 100));
            Ball.Builder ballBuilder = new Ball.Builder();
            ballBuilder.Height(10)
                       .Width(10)
                       .Speed(0.2);

            // north direction
            double py = Math.Sin((Math.PI / 180) * 90);
            double px = Math.Cos((Math.PI / 180) * 90);
            ballBuilder.Position(new Position(50, 50))
                       .Direction(new DirVector(px, py));
            HashSet<Ball> ballContainer = new HashSet<Ball>();
            ballContainer.Add(ballBuilder.Build());
            board.SetBalls(ballContainer);
            foreach (Ball ent in board.GetSceneEntity())
            {
                Assert.AreEqual(new Position(50, 50), ent.Position);
            }
            board.UpdateState(10);
            foreach (Ball ent in board.GetSceneEntity())
            {
                Assert.AreEqual(new Position(50, 52), ent.Position);
            }

            // south direction
            py = Math.Sin((Math.PI / 180) * 270);
            px = Math.Cos((Math.PI / 180) * 270);
            ballBuilder.Position(new Position(50, 50))
                       .Direction(new DirVector(px, py));
            ballContainer = new HashSet<Ball>();
            ballContainer.Add(ballBuilder.Build());
            board.SetBalls(ballContainer);
            foreach (Ball ent in board.GetSceneEntity())
            {
                Assert.AreEqual(new Position(50, 50), ent.Position);
            }
            board.UpdateState(10);
            foreach (Ball ent in board.GetSceneEntity())
            {
                Assert.AreEqual(new Position(50, 48), ent.Position);
            }

            // east direction
            py = Math.Sin((Math.PI / 180) * 0);
            px = Math.Cos((Math.PI / 180) * 0);
            ballBuilder.Position(new Position(50, 50))
                       .Direction(new DirVector(px, py));
            ballContainer = new HashSet<Ball>();
            ballContainer.Add(ballBuilder.Build());
            board.SetBalls(ballContainer);
            foreach (Ball ent in board.GetSceneEntity())
            {
                Assert.AreEqual(new Position(50, 50), ent.Position);
            }
            board.UpdateState(10);
            foreach (Ball ent in board.GetSceneEntity())
            {
                Assert.AreEqual(new Position(52, 50), ent.Position);
            }

            // west direction
            py = Math.Sin((Math.PI / 180) * 180);
            px = Math.Cos((Math.PI / 180) * 180);
            ballBuilder.Position(new Position(50, 50))
                       .Direction(new DirVector(px, py));
            ballContainer = new HashSet<Ball>();
            ballContainer.Add(ballBuilder.Build());
            board.SetBalls(ballContainer);
            foreach (Ball ent in board.GetSceneEntity())
            {
                Assert.AreEqual(new Position(50, 50), ent.Position);
            }
            board.UpdateState(10);
            foreach (Ball ent in board.GetSceneEntity())
            {
                Assert.AreEqual(new Position(48, 50), ent.Position);
            }
        }
    }
}
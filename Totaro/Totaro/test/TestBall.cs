using NUnit.Framework;
using Totaro.src;
using System;

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

            ball.Position(new Position(10, 10)).Direction(new DirVector(1, 0)).Height(10).Width(1).Path("ci<o");
            Assert.Throws<InvalidOperationException>(() => ball.Build());
        }
    }
}
using NUnit.Framework;
using Raso.src;
using System.Collections.Generic;

namespace Raso.test
{
    public class TestBrick
    {
        public Brick CreateBrick()
        {
            return new Brick.Builder()
                    .Durability(1)
                    .Height(10)
                    .Width(10)
                    .Position(new Position(30, 30))
                    .Status(BrickStatus.DESTRUCTIBLE)
                    .Texture("image/defaultBrick.png")
                    .Build();
        }
        /**
         * Checking if the builder sets all the fields correctly.
         */
        [Test]
        public void BrickCreation()
        {
            Brick brick = CreateBrick();
            Assert.AreEqual(new Position(30, 30), brick.Position);
            Assert.AreEqual(1, brick.Durability);
            Assert.AreEqual(10, brick.Height);
            Assert.AreEqual(10, brick.Width);
            Assert.AreEqual(BrickStatus.DESTRUCTIBLE, brick.Status);
        }

        /**
         * Damage the brick and tests its durability.
         */
        [Test]
        public void BrickDamage()
        {
            Brick brick = CreateBrick();

            brick.DecreaseDurability(1);
            Assert.AreEqual(0, brick.Durability);
        }

        [Test]
        public void BrickRemoval()
        {
            Brick brick = CreateBrick();

            GameBoard board = new GameBoard();
            HashSet<Brick> bricks = new HashSet<Brick>();
            //adds brick to the GameBoard and checks if it is not null
            bricks.Add(brick);
            board.SetBricks(bricks);
            Assert.NotNull(bricks);
            //remove brick from the GameBoard and checks if it is empty
            bricks.Remove(brick);
            board.SetBricks(bricks);
            Assert.IsEmpty(bricks);
        }
    }
}

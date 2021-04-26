using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testa;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testa.Tests
{
    [TestClass()]
    public class PlayerImplTestsPlayer
    {
        private PlayerImpl currentPlayer;
        private ScoreOperationStrategy scoreOp;
        private LifeOperationStrategy lifeOp;

        [TestInitialize]
        public void PlayerImplTestPlayer()
        {
            this.currentPlayer = new PlayerImpl("Alex", 2000, 3, 3);
            this.scoreOp = new BasicScoreOperationStrategy();
            this.lifeOp = new BasicLifeOperationStrategy();
        }

        [TestMethod()]
        public void TestIncreaseScore()
        {
            for (int i = 0; i < 10; i++)
            {
                this.currentPlayer.ScoreOperation(this.scoreOp, 100);
            }
            Assert.AreEqual(3000, this.currentPlayer.score);
        }

        [TestMethod()]
        public void TestDecreaseScore()
        {
            for (int i = 0; i < 10; i++)
            {
                this.currentPlayer.ScoreOperation(this.scoreOp, -100);
            }
            Assert.AreEqual(1000, this.currentPlayer.score);
        }

        [TestMethod()]
        public void TestIncreaseDecreaseScore()
        {
            for (int i = 0; i < 10; i++)
            {
                this.currentPlayer.ScoreOperation(this.scoreOp, -100);
            }
            for (int i = 0; i < 10; i++)
            {
                this.currentPlayer.ScoreOperation(this.scoreOp, 100);
            }
            Assert.AreEqual(2000, this.currentPlayer.score);
        }

        [TestMethod()]
        public void TestGetter()
        {
            Assert.AreEqual("Alex", this.currentPlayer.alias);
            Assert.AreEqual(3, this.currentPlayer.life);
            Assert.AreEqual(2000, this.currentPlayer.score);
            Assert.AreEqual(3, this.currentPlayer.maxNumberOfLife);
        }

        [TestMethod()]
        public void TestSamePlayer()
        {
            PlayerImpl samePlayer = new PlayerImpl("Alex", 5000, 4, 4);
            Assert.AreEqual(samePlayer, this.currentPlayer);
        }

        [TestMethod()]
        public void TestIncreaseDecreaseLife()
        {
            for (int i = 0; i < 10; i++)
            {
                this.currentPlayer.LifeOperation(this.lifeOp, 1);
            }

            Assert.AreEqual(3, this.currentPlayer.life);

            for (int i = 0; i < 10; i++)
            {
                this.currentPlayer.LifeOperation(this.lifeOp, -1);
            }

            Assert.AreEqual(0, this.currentPlayer.life);
        }

        [TestMethod()]
        public void TestAlive()
        {
            Assert.IsTrue(this.currentPlayer.IsAlive());
            this.currentPlayer.LifeOperation(this.lifeOp, -1);
            Assert.IsTrue(this.currentPlayer.IsAlive());
            this.currentPlayer.LifeOperation(this.lifeOp, -1);
            Assert.IsTrue(this.currentPlayer.IsAlive());
            this.currentPlayer.LifeOperation(this.lifeOp, -1);
            Assert.IsFalse(this.currentPlayer.IsAlive());
        }

        public void TestToString() 
        {
            Assert.AreEqual("[alias = " + "Alex" + " ,score = " + 2000 + " ,life = " + 3
                 + " ,maxLife = " + 3 + "]", this.currentPlayer.alias);
        }
    }
}
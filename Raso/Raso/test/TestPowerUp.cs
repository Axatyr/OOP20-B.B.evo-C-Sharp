﻿using NUnit.Framework;
using Raso.src;
using System;
using System.Collections.Generic;
using System.Text;

namespace Raso.test
{
    public class TestPowerUp
    {
        [Test]
        public void PowerUpCreation()
        {
            PowerUp powerUp = new PowerUp(new Position(50,50),10,10,"image/defaultPowerUp.png") ;
            Assert.AreEqual(new Position(50, 50), powerUp.Position);
            Assert.AreEqual(new DirVector(0, -1), powerUp.Direction);
            Assert.AreEqual(0.2, powerUp.Speed);
            Assert.AreEqual(10, powerUp.Height);
            Assert.AreEqual(10, powerUp.Width);
        }
 
        [Test]
        public void PowerUpMovement()
        {
            GameBoard board = new GameBoard();
            PowerUp powerUp = new PowerUp(new Position(50, 50), 10, 10, "image/defaultPowerUp.png");
            DirVector newDirVector = new DirVector(0, -1);

            powerUp.Direction = newDirVector;
            HashSet<PowerUp> pwups = new HashSet<PowerUp>();
            pwups.Add(powerUp);
            board.SetPwUps(pwups);
            foreach (PowerUp ent in board.GetSceneEntities())
            {
                Assert.AreEqual(new Position(50, 50), ent.Position);
            }
            board.UpdateState(10);
            foreach (PowerUp ent in board.GetSceneEntities())
            {
                Assert.AreEqual(new Position(50, 48), ent.Position);
            }

        }  
    }
}

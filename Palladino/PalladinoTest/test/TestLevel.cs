using NUnit.Framework;
using Palladino.src;
using System;
using System.Collections.Generic;
using System.Text;

namespace Palladino.test
{
    class TestLevel
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LevelCreation()
        {
            Level level = new Level("ProvaLivello");

            Assert.AreEqual("ProvaLivello", level.GetLevelName());
        }
    }
}

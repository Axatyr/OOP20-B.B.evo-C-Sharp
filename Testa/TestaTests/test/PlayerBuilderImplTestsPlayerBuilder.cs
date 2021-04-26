using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testa;
using System;
using System.Collections.Generic;
using System.Text;

namespace Testa.Tests
{
    [TestClass()]
    public class PlayerBuilderImplTestsPlayerBuilder
    {
        private PlayerBuilderImpl builder;

        [TestInitialize]
        public void InitBuilder()
        {
            this.builder = new PlayerBuilderImpl();
        }

        [TestMethod()]
        public void TestCorrectBuild()
        {
            try
            {
                this.builder.Alias("Alex");
                this.builder.Score(2000);
                this.builder.Life(3);
                this.builder.MaxLife(3);
                this.builder.Build();
            }
            catch (Exception ex) 
            {
                Assert.Fail("Failed Build : " + ex.Message);
            }
        }

        [TestMethod()]
        public void TestUncorrectBuildOverflowLife()
        {
            Assert.ThrowsException<ArgumentException>(() => 
            {
                this.builder.Score(2000);
                this.builder.Life(50);
                this.builder.Build();
            });
        }

        [TestMethod()]
        public void TestUncorrectBuildUnderflowLife()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                this.builder.Score(2000);
                this.builder.Life(-50);
                this.builder.Build();
            });
        }

        [TestMethod()]
        public void TestUncorrectUnderflowScore()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                this.builder.Score(-2000);
                this.builder.Life(3);
                this.builder.Build();
            });
        }

        [TestMethod()]
        public void TestNullAlias()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                this.builder.Alias(null);
                this.builder.Score(2000);
                this.builder.Life(3);
                this.builder.Build();
            });
        }
    }
}
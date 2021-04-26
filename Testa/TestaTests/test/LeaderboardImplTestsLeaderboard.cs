using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testa.Tests
{
    [TestClass()]
    public class LeaderboardImplTestsLeaderboard
    {
        private LeaderboardImpl leaderboard;
        private Dictionary<string, int> testLeaderboard;

        [TestInitialize]
        public void TestInitLeaderboard()
        {
            this.leaderboard = new LeaderboardImpl();
            this.testLeaderboard = new Dictionary<string, int>();

            this.leaderboard.AddPlayer("Alex", 1200);
            this.leaderboard.AddPlayer("Marco", 1400);
            this.leaderboard.AddPlayer("Massimo", 1800);

            this.testLeaderboard.Add("Alex", 1200);
            this.testLeaderboard.Add("Marco", 1400);
            this.testLeaderboard.Add("Massimo", 1800);
        }

        [TestMethod()]
        public void AddPlayerTestLeaderboard() {
            foreach (KeyValuePair<string, int> element in this.leaderboard.ranking) 
            {
                Console.WriteLine("Key = {0}, Value = {1}", element.Key, element.Value);
                Assert.IsTrue(this.testLeaderboard.ContainsKey(element.Key));
                Assert.IsTrue(this.testLeaderboard.ContainsValue(element.Value));
            }
        }

        [TestMethod()]
        public void TestOverWritePlayer() => Assert.ThrowsException<ArgumentException>(() => this.leaderboard.AddPlayer("Alex", 2000));

    }
}
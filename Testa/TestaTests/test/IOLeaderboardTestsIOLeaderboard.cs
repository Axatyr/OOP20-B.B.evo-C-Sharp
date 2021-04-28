using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Testa;

namespace src.src.Tests
{
    [TestClass()]
    public class IOLeaderboardTestsIOLeaderboard
    {
        private string nameFile = "leaderboard.json";
        private LeaderboardImpl leaderboard;

        [TestInitialize]
        public void InitiRanking() 
        {
            this.leaderboard = new LeaderboardImpl();
            this.leaderboard.AddPlayer("Alex", 2000);
            this.leaderboard.AddPlayer("Marco", 1600);
            this.leaderboard.AddPlayer("Massimo", 1800);
            this.leaderboard.AddPlayer("Franco", 1200);
        }
        [TestMethod()]
        public void PrintInJsonFormatTesIOLeaderboard()
        {
            try
            {
                IOLeaderboard.PrintInJsonFormat(nameFile, this.leaderboard.ranking);
            }
            catch 
            {
                Assert.Fail("Print failed");
            }

        }

        [TestMethod]
        public void ReadLeaderboardInJsonFile() 
        {
            try
            {
                IOLeaderboard.ReadLeaderboardOnJsonFile(nameFile);
            }
            catch 
            {
                Assert.Fail("Read Failed");
            }

            if (IOLeaderboard.ReadLeaderboardOnJsonFile(nameFile).Count != this.leaderboard.ranking.Count) 
            {
                Assert.Fail("The leaderboards are not equal");
            }
        }
    }
}
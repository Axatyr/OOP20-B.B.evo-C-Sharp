using System;
using System.Collections.Generic;
using System.Text;

namespace Testa
{
    class LeaderboardImpl : Leaderboard
    {
        public Dictionary<string, int> ranking { get; set; }

        public LeaderboardImpl() => this.ranking = new Dictionary<string, int>();

        public void AddPlayer(string alias, int score) => this.ranking.Add(alias, score);

        public void removePlayer(string alias)
        {
            if (this.ranking.ContainsKey(alias))
            {
                this.ranking.Remove(alias);
            } 
            else 
            {
                throw new ArgumentException();
            }

        }

        public void SortByScore(LeaderboardSortingStrategy ls)
        {
            throw new NotImplementedException();
        }
    }
}

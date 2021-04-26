using System;
using System.Collections.Generic;
using System.Text;

namespace Testa
{
    interface Leaderboard
    {
        void SortByScore(LeaderboardSortingStrategy ls);

        void AddPlayer(string alias, int score);

        void RemovePlayer(string alias);

    }
}

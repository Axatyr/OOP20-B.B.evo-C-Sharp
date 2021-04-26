using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testa
{
    class StandardScoreSortingStrategy : LeaderboardSortingStrategy
    {
        public Dictionary<string, int> SortDictionary(Dictionary<string, int> dictionary)
        {
            Dictionary<string, int> orderDictionary = new Dictionary<string, int>();
            foreach (KeyValuePair<string, int> player in dictionary.OrderBy(key => key.Value)) 
            {
                orderDictionary.Add(player.Key, player.Value);
            }
            return orderDictionary;
        }
    }
}

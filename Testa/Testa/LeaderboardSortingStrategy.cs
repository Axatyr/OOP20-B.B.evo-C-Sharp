using System.Collections.Generic;

namespace Testa
{
    interface LeaderboardSortingStrategy
    {
        Dictionary<string, int> SortDictionary(Dictionary<string, int> dictionary);
    }
}
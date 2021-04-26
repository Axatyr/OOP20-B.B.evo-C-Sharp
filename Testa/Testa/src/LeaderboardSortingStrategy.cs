using System.Collections.Generic;

namespace Testa
{
    public interface LeaderboardSortingStrategy
    {
        Dictionary<string, int> SortDictionary(Dictionary<string, int> dictionary);
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Testa
{
    class BasicScoreOperationStrategy : ScoreOperationStrategy
    {
        public int ScoreOperation(int currentScore, int value)
        {
            int result;

            if (value < 0 && (currentScore + value) < 0)
            {
                result = 0;
            }
            else 
            {
                result = currentScore + value;
            }

            return result;
        }
    }
}

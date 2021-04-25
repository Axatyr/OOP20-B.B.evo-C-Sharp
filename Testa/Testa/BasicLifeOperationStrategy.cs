using System;
using System.Collections.Generic;
using System.Text;

namespace Testa
{
    class BasicLifeOperationStrategy : LifeOperationStrategy
    {
        public int LifeOperation(int currentLife, int value, int maxLife)
        {
            var result = currentLife + value;

            if (result > maxLife) 
            {
                result = maxLife;
            }

            if (result < 0) 
            {
                result = 0;
            }

            return result;
        }
    }
}

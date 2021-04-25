using System;
using System.Collections.Generic;
using System.Text;

namespace Testa
{
    interface Player
    {
        void ScoreOperation(ScoreOperationStrategy operation, int value);

        void LifeOperation(LifeOperationStrategy operation, int value);

        bool IsAlive();
    }
}

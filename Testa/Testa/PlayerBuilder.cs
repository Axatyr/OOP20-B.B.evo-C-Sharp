using System;
using System.Collections.Generic;
using System.Text;

namespace Testa
{
    interface PlayerBuilder
    {
        PlayerBuilder Alias(string alias);

        PlayerBuilder Score(int score);

        PlayerBuilder Life(int life);

        PlayerBuilder MaxLife(int value);

        Player Build();
    }
}

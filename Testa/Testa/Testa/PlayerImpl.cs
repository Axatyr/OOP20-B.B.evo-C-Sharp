using System;
using System.Collections.Generic;
using System.Text;

namespace Testa
{
    class PlayerImpl : Player
    {
        string alias { get; }
        int score { get; }
        int life { get; }
        int maxNumberOfLife { get; set; }

        public PlayerImpl(string alias, int score, int life, int MaxNumberOfLife) 
        {
            this.alias = alias;
            this.score = score;
            this.life = life;
            this.maxNumberOfLife = maxNumberOfLife;
        }
        public bool IsAlive() => this.life > 0;

        public void LifeOperation(LifeOperationStrategy operation, int value)
        {
            throw new NotImplementedException();
        }

        public void ScoreOperation(ScoreOperationStrategy operationStrategy, int value)
        {
            throw new NotImplementedException();
        }
    }
}

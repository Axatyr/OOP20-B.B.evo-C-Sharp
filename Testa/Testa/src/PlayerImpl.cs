using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Testa
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class PlayerImpl : Player
    {
        private string alias { get; }
        public int score { get; private set; }
        public int life { get; private set; }
        private int maxNumberOfLife { get; set; }

        public PlayerImpl(string alias, int score, int life, int maxnumberOfLife)
        {
            this.alias = alias;
            this.score = score;
            this.life = life;
            this.maxNumberOfLife = maxnumberOfLife;
        }

        public bool IsAlive() => this.life > 0;

        public void LifeOperation(LifeOperationStrategy operation, int value)
        {
            if (this.IsAlive()) 
            {
                this.life = operation.LifeOperation(this.life, value, this.maxNumberOfLife);
            }
        }

        public void ScoreOperation(ScoreOperationStrategy operation, int value)
        {
            if (this.IsAlive()) 
            {
                this.score = operation.ScoreOperation(this.score, value);
            }
        }

        override
        public string ToString()
        {
            return "[alias = " + this.alias + " ,score = " + this.score + " ,life = " + this.life
                 + " ,maxLife = " + this.maxNumberOfLife + "]";
        }

        public override bool Equals(object obj)
        {
            return obj is PlayerImpl impl &&
                   this.alias == impl.alias &&
                   this.score == impl.score &&
                   this.life == impl.life &&
                   this.maxNumberOfLife == impl.maxNumberOfLife;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.alias, this.score, this.life, this.maxNumberOfLife);
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Testa
{
    class PlayerBuilderImpl : PlayerBuilder
    {
        private string alias;
        private int score;
        private int life;
        private int maxLife;

        public PlayerBuilder Alias(string alias)
        {
            this.alias = alias;
            return this;
        }

        public Player Build()
        {
            if (this.alias == null 
                || this.score < 0 
                || this.life < 0
                || this.life > this.maxLife
                || this.maxLife < 0)
            {
                throw new ArgumentException();
            }
            return new PlayerImpl(this.alias, this.score, this.life, this.maxLife);
        }

        public PlayerBuilder Life(int life)
        {
            this.life = life;
            return this;
        }

        public PlayerBuilder MaxLife(int value)
        {
            this.maxLife = value;
            return this;
        }

        public PlayerBuilder Score(int score)
        {
            this.score = score;
            return this;
        }
    }
}

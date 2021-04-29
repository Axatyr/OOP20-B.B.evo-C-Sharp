using System;
using System.Collections.Generic;

namespace Raso.src
{
public class PowerUp : GameObject
    {
    public enum PowerUpType
    {
        SPEED_UP,
        SPEED_DOWN,
        LIFE_UP,
        LIFE_DOWN,
        DAMAGE_UP,
        DAMAGE_DOWN
    }
        private long activeTime { get; set; }
        private double speedModifier { get; set; }
        private int lifeModifier { get; set; }
        private int damageModifier { get; set; }
        private PowerUpType pwupType { get; set; }
        private static Random randStatus = new Random();
        private string texturePath { get; set; }

        public PowerUp(Position pos, int height, int width, String tPath) :
            base(pos, new DirVector(0,-1), 0.2, height, width, new PowerUpComponentPhysics(), new ComponentInputEmpty())
        {
            texturePath = tPath;
        }

        public override void UpdateInput(IControllerInput controller)
        {
            base.Input.Update(this, controller);
        }

        public override void UpdatePhysics(int timeElapsed)
        {
            base.Physics.Update(timeElapsed, this);
        }

    }
}

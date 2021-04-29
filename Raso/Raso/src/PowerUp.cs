using System;
using System.Collections.Generic;

namespace Raso.src
{
public class PowerUp : GameObject
    {
        private long activeTime { get; set; }
        private double speedModifier { get; set; }
        private int lifeModifier { get; set; }
        private int damageModifier { get; set; }
        public PowerUpType pwupType { get; set; }
        private string texturePath { get; set; }

        public PowerUp(Position pos, int height, int width, String tPath) :
            base(pos, new DirVector(0,-1), 0.2, height, width, new PowerUpComponentPhysics(), new ComponentInputEmpty())
        {
            texturePath = tPath;
            pwupType = RandomPowerUpType.RandomPowerUpTypeValue<PowerUpType>();
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

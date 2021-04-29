using System;
using System.Collections.Generic;
using System.Text;

namespace Raso.src
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

    public static class RandomPowerUpType
    {
        static Random rnd = new Random();
        public static T RandomPowerUpTypeValue<T>()
        {
            var v = Enum.GetValues(typeof(PowerUpType));
            return (T)v.GetValue(rnd.Next(v.Length));
        }
    }

}

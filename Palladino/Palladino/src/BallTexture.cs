using System;
using System.Collections.Generic;
using System.Text;

namespace Palladino.src
{
    class BallTexture
    {
        private readonly string ballPath;
        private readonly string ballTheme;

        public BallTexture()
        {
            this.ballPath = "ballPath";
            this.ballTheme = "ballTheme";
        }

        public string GetBallPath()
        {
            return ballPath;
        }

        public string GetBallTheme()
        {
            return ballTheme;
        }
    }
}

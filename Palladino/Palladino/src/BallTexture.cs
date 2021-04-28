using System;
using System.Collections.Generic;
using System.Text;

namespace Palladino.src
{
    class BallTexture
    {
        private readonly string ballPath;
        private readonly string ballTheme;

        public BallTexture(string path, string theme)
        {
            this.ballPath = path;
            this.ballTheme = theme;
        }

        /// <returns>return path of ball resource</returns>
        public string GetBallPath()
        {
            return ballPath;
        }

        /// <returns>return name of ball resource</returns>
        public string GetBallTheme()
        {
            return ballTheme;
        }
    }
}

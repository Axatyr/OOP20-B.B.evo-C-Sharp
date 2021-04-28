using System;
using System.Collections.Generic;
using System.Text;

namespace Palladino.src
{
    class PaddleTexture
    {
        private readonly string paddlePath;
        private readonly string paddleTheme;

        public PaddleTexture(string path, string theme)
        {
            this.paddlePath = path;
            this.paddleTheme = theme;
        }

        /// <returns>return path of paddle resource</returns>
        public string GetPaddlePath()
        {
            return paddlePath;
        }

        /// <returns>return name of paddle resource</returns>
        public string GetPaddleTheme()
        {
            return paddleTheme;
        }
    }
}

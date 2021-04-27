using System;
using System.Collections.Generic;
using System.Text;

namespace Palladino.src
{
    class PaddleTexture
    {
        private readonly string paddlePath;
        private readonly string paddleTheme;

        public PaddleTexture()
        {
            this.paddlePath = "paddlePath";
            this.paddleTheme = "paddleTheme";
        }

        public string GetPaddlePath()
        {
            return paddlePath;
        }

        public string GetPaddleTheme()
        {
            return paddleTheme;
        }
    }
}

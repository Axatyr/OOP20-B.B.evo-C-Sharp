using System;
using System.Collections.Generic;
using System.Text;

namespace Palladino.src
{
    class BackgroundTexture
    {
        private readonly string backgroundPath;
        private readonly string backgroundTheme;

        public BackgroundTexture()
        {
            this.backgroundPath = "backgroundPath";
            this.backgroundTheme = "backgroundTheme";
        }

        public string GetBackgroundPath()
        {
            return backgroundPath;
        }

        public string GetBackgroundTheme()
        {
            return backgroundTheme;
        }
    }
}

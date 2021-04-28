using System;
using System.Collections.Generic;
using System.Text;

namespace Palladino.src
{
    class BackgroundTexture
    {
        private readonly string backgroundPath;
        private readonly string backgroundTheme;

        public BackgroundTexture(string path, string theme)
        {
            this.backgroundPath = path;
            this.backgroundTheme = theme;
        }

        /// <returns>return path of background resource</returns>
        public string GetBackgroundPath()
        {
            return backgroundPath;
        }

        /// <returns>return name of background resource</returns>
        public string GetBackgroundTheme()
        {
            return backgroundTheme;
        }
    }
}

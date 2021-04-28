using System;
using System.Collections.Generic;
using System.Text;

namespace Palladino.src
{
    class PersonalSounds
    {
        private readonly string musicPath;
        private readonly string musicTheme;

        public PersonalSounds(string path, string theme)
        {
            this.musicPath = path;
            this.musicTheme = theme;
        }

        /// <returns>return path of sound resource</returns>
        public string GetMusicPath()
        {
            return musicPath;
        }

        /// <returns>return name of sound resource</returns>
        public string GetMusicTheme()
        {
            return musicTheme;
        }
    }
}

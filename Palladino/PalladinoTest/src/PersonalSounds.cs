using System;
using System.Collections.Generic;
using System.Text;

namespace Palladino.src
{
    class PersonalSounds
    {
        private readonly string musicPath;
        private readonly string musicTheme;

        public PersonalSounds()
        {
            this.musicPath = "musicPath";
            this.musicTheme = "musicTheme";
        }

        public string GetMusicPath()
        {
            return musicPath;
        }

        public string GetMusicTheme()
        {
            return musicTheme;
        }
    }
}

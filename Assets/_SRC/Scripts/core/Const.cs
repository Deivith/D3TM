using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.odaclick.d3.core {

    public class Const {

        public static class TAG {
            public static string MAIN = "Main";
        }

        public static class RESOURCES {

            public static string CONFIG_FILE = "config/config";
            public static string LANG_FOLDER = "lang/";
            public static string MUSIC_AUDIO_MIXER = "sound/Music";            
            public static string FX_AUDIO_MIXER = "sound/Fx";

        }

        public static class AUDIO_MIXER {
            public static string MUSIC_VOLUME = "musicVolume";
            public static string FX_VOLUME = "fxVolume";
        }
        
        public static class STORAGE {

            public static string KEY_LANG = "lang";
            public static string KEY_MUSIC_VOLUME = "music_volume";
            public static string KEY_FX_VOLUME = "fx_volume";
            public static string KEY_DIFFICULTY = "difficulty";

        }

    }


}

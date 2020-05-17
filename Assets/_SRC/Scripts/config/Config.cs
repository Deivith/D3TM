using com.odaclick.d3.core;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace com.odaclick.d3.config {

    public class Config {

        private static Config _instance;
        public static Config instance
        {
            get
            {
                if (_instance == null) {
                    _instance = new Config();
                    _instance.Init();
                }
                return _instance;
            }
        }
        //
        private void Init() {

            TextAsset ta = Resources.Load<TextAsset>(Const.RESOURCES.CONFIG_FILE);
            variables = JsonUtility.FromJson<Variables>(ta.text);

        }

        private Variables variables;
        public Sound sound { get { return variables.sound; }  }
        public Lang lang { get { return variables.lang; } }
        public Difficulty difficulty { get { return variables.difficulty; } }

        [Serializable]
        public class Variables {
            public Sound sound;
            public Lang lang;
            public Difficulty difficulty;
        }

        [Serializable]
        public class Lang {

            public string defaultValue;
            public List<string> list;

        }

        [Serializable]
        public class Sound {

            public string music;
            public float defaultMusicVolume;
            public float defaultFxVolume;
            public float minVolumeValue;
            public float maxVolumeValue;

        }

        [Serializable]
        public class Difficulty {

            public string defaultValue;
            public List<Item> list;

            [Serializable]
            public class Item {
                public string identifier;
                public string label;
                public float modifier;
            }

        }


    }


}

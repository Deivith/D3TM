using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.odaclick.d3.config {

    public class Config {

        private static Config _instance;
        public static Config instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Config();

                return _instance;
            }
        }
        //

        private ConfigList list;

        public string music {
            get
            {
                if (list.music != null && list.music != "") return list.music;
                return null;
            }
        }


        public void AddMusic(GameObject gameObject) {

            if (music != null) {

                AudioClip audioClip = Resources.Load<AudioClip>(Config.instance.music);

                if (audioClip != null) {
                    AudioSource audioSource = gameObject.GetComponent<AudioSource>();
                    if (audioSource == null) {
                        audioSource = gameObject.AddComponent<AudioSource>();
                    }
                    audioSource.clip = audioClip;
                    audioSource.Play();
                }

            }

        }

        public void Init() {

            TextAsset ta = Resources.Load<TextAsset>("config/config");
            list = JsonUtility.FromJson<ConfigList>(ta.text);
            
        }

    }

   
}

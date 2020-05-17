using com.odaclick.d3.config;
using com.odaclick.d3.storage;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using static com.odaclick.d3.config.Config;

namespace com.odaclick.d3.core {


    public class GameData {

        public static GameData _instance;
        public static GameData instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GameData();

                return _instance;
            }
        }

        /** */
        public Difficulty.Item _difficulty;
        public Difficulty.Item difficulty
        {
            set
            {
                _difficulty = value;
                Storage.SaveString(Const.STORAGE.KEY_DIFFICULTY, _difficulty.identifier);
            }
            get
            {
                return _difficulty;
            }
        }

        private AudioMixer _musicMixer;
        public AudioMixer musicMixer
        {
            get
            {
                return _musicMixer;
            }
        }
        public float musicVolume
        {
            get
            {
                return Storage.GetFloat(Const.STORAGE.KEY_MUSIC_VOLUME, Config.instance.sound.defaultMusicVolume);
            }
            set
            {
                _musicMixer.SetFloat(Const.AUDIO_MIXER.MUSIC_VOLUME, value);
                Storage.SaveFloat(Const.STORAGE.KEY_MUSIC_VOLUME, value);

            }
        }

        private AudioMixer _fxMixer;
        public AudioMixer fxMixer
        {
            get
            {
                return _fxMixer;
            }
        }
        public float fxVolume
        {
            get
            {
                return Storage.GetFloat(Const.STORAGE.KEY_FX_VOLUME, Config.instance.sound.defaultFxVolume);
            }
            set
            {
                _fxMixer.SetFloat(Const.AUDIO_MIXER.FX_VOLUME, value);
                Storage.SaveFloat(Const.STORAGE.KEY_FX_VOLUME, value);
            }
        }

        public GameData() {

            string defaultDiff = Storage.GetString(Const.STORAGE.KEY_DIFFICULTY, Config.instance.difficulty.defaultValue);
            foreach(Difficulty.Item item in Config.instance.difficulty.list) {
                if (item.identifier.Equals(defaultDiff)) {
                    _difficulty = item;
                    break;
                }
            }
    
        }

        public void Init() {

            _musicMixer = Resources.Load<AudioMixer>(Const.RESOURCES.MUSIC_AUDIO_MIXER);
            _musicMixer.SetFloat(Const.AUDIO_MIXER.MUSIC_VOLUME, musicVolume);

            _fxMixer = Resources.Load<AudioMixer>(Const.RESOURCES.FX_AUDIO_MIXER);
            _fxMixer.SetFloat(Const.AUDIO_MIXER.FX_VOLUME, fxVolume);
        }

    }


}
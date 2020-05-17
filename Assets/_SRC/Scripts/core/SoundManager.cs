using com.odaclick.d3.config;
using com.odaclick.d3.core;
using com.odaclick.d3.storage;
using com.odaclick.d3.util;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager 
{
    public static GameObject AddMusic(string music,string mixer) {

        

        if (Util.isEmpty(music)) return null;
        
        GameObject go = GameObject.Find(music);
        if(go == null) {
            go = new GameObject();
            go.name = music;                
        }

        AudioClip audioClip = Resources.Load<AudioClip>(music);
        if (audioClip != null) {
            AudioSource audioSource = go.GetComponent<AudioSource>();
            if (audioSource == null) {
                audioSource = go.AddComponent<AudioSource>();
            }

            // get audiomixer and assign sound / master
            AudioMixer am = GameData.instance.musicMixer;                            
            audioSource.outputAudioMixerGroup = am.FindMatchingGroups("Master")[0];
            audioSource.clip = audioClip;
            audioSource.loop = true;
            audioSource.Play();

            // setup volume
            //float volume = Storage.GetFloat(Const.STORAGE.KEY_MUSIC_VOLUME, Config.instance.sound.defaultMusicVolume);
            //am.SetFloat(Const.AUDIO_MIXER.MUSIC_VOLUME, GameData.insta);

        }

        return go;

    }
}

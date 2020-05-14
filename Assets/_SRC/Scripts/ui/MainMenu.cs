using com.odaclick.d3.config;
using com.odaclick.d3.lang;
using com.odaclick.d3.storage;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    
    public AudioMixerGroup music;
    public AudioMixerGroup sfx;

    // Start is called before the first frame update
    void Start()
    {

        Language.instance.Init(Storage.GetString(Storage.KEY_LANG,"en"));
        Language.instance.OnChangeLanguage("es");


        Config.instance.Init();
        Config.instance.AddMusic(gameObject, music);

    }



}

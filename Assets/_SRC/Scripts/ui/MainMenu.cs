using com.odaclick.d3.config;
using com.odaclick.d3.core;
using com.odaclick.d3.lang;
using com.odaclick.d3.storage;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    private void OnEnable() {

        //Storage.ClearStorage();

        Language.instance.Init();        
    }

    // Start is called before the first frame update
    void Start()
    {
        GameData.instance.Init();

        GameObject musicGO = SoundManager.AddMusic(Config.instance.sound.music, Const.RESOURCES.MUSIC_AUDIO_MIXER);
        if(musicGO!=null) DontDestroyOnLoad(musicGO);


    }

    public void OnClickPlay() {
        SceneManager.LoadScene(Const.SCENES.GAMEPLAY);
    }

    public void OnClickExit() {
        Application.Quit();
    }



}

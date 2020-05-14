using com.odaclick.d3.lang;
using com.odaclick.d3.storage;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    public AudioMixer musicMixer;
    public Slider UISliderMusicVolume;


    private void Start() {

        UISliderMusicVolume.onValueChanged.AddListener(
            (float volume) => {
                musicMixer.SetFloat("musicVolume", volume);
            }
        );

    }
    // Start is called before the first frame update
    private void OnEnable() {

        Language.instance.OnChangeLanguage("es");
        
    }

    public void OnChangeLanguage(string lang) {
        
        Language.instance.Init(lang);
        Language.instance.OnChangeLanguage(lang);
        Storage.SaveString(Storage.KEY_LANG,lang);

    }




}

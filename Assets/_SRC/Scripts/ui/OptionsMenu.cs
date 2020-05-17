using com.odaclick.d3.config;
using com.odaclick.d3.core;
using com.odaclick.d3.lang;
using com.odaclick.d3.storage;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using static com.odaclick.d3.config.Config;

public class OptionsMenu : MonoBehaviour
{    
    public Slider UISliderMusicVolume;
    public Slider UISliderFXVolume;

    // multibutton options
    public GameObject baseButton;
    public Transform langPanel;
    private List<GameObject> langButtons;
    public Transform difficultyPanel;
    private List<GameObject> difficultyButtons;

    private void Start() {

        /*
         * add music listener
         */
        UISliderMusicVolume.onValueChanged.AddListener(
            (float volume) => {
                GameData.instance.musicVolume = volume;
            }
        );

        /*
         * add music listener
         */
        UISliderFXVolume.onValueChanged.AddListener(
            (float volume) => {
                GameData.instance.fxVolume = volume;
            }
        );

        /*
         *Setup lang buttons
         */
        langButtons = new List<GameObject>();
        foreach (string lang in Config.instance.lang.list) {
            GameObject l = CreateButton(lang, langPanel, lang);
            l.GetComponent<Button>().onClick.AddListener(() => {
                OnChangeLanguage(lang);
            });
            langButtons.Add(l);
        }
        UIUtil.SetupSelectedButtonByName(langButtons, Language.instance.GetCurrentLanguage());

        // difficulty buttons
        difficultyButtons = new List<GameObject>();
        foreach (Config.Difficulty.Item diff in Config.instance.difficulty.list) {

            GameObject l = CreateButton(diff.identifier, difficultyPanel, diff.label);
            l.GetComponent<Button>().onClick.AddListener(() => {
                OnChangeDifficulty(diff);
            });
            difficultyButtons.Add(l);
        }
        UIUtil.SetupSelectedButtonByName(difficultyButtons, GameData.instance.difficulty.identifier);
    }

    // Start is called before the first frame update
    private void OnEnable() {

        Language.instance.OnChangeLanguage(Language.instance.GetCurrentLanguage());

        // load volume value
        UISliderMusicVolume.minValue = Config.instance.sound.minVolumeValue;
        UISliderMusicVolume.maxValue = Config.instance.sound.maxVolumeValue;
        UISliderMusicVolume.value = GameData.instance.musicVolume;

        // load fx
        UISliderFXVolume.minValue = Config.instance.sound.minVolumeValue;
        UISliderFXVolume.maxValue = Config.instance.sound.maxVolumeValue;        
        UISliderFXVolume.value = GameData.instance.fxVolume;

    }


    private GameObject CreateButton(string name, Transform parent, string label) {
        GameObject l = Instantiate<GameObject>(baseButton);
        l.name = name;
        l.transform.SetParent(parent);
        l.GetComponentInChildren<UITextTranslation>().key = label;
        return l;
    }

    private void OnChangeLanguage(string lang) {
        
        Language.instance.Init(lang);
        UIUtil.SetupSelectedButtonByName(langButtons, lang);
    }

    private void OnChangeDifficulty(Difficulty.Item diff) {

        GameData.instance.difficulty = diff;
        UIUtil.SetupSelectedButtonByName(difficultyButtons, diff.identifier);
        
    }

}

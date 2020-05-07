using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
   
    private Text UIText;
    UITextTranslation[] UITranslate;
    public string currentLang;
    void Start()
    {
       
        ChangeLanguage(currentLang);
    }

    public void ChangeLanguage(string lang)
    {
        dictionaryWorks.InitLang(lang);
        UITranslate = GameObject.FindObjectsOfType<UITextTranslation>();
        foreach (UITextTranslation UIT in UITranslate)
        {
            UIT.SetText();

            
        }

    }
public void Translate()
    {
       
    }
}

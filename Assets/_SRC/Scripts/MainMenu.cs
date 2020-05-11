using com.odaclick.d3.lang;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        OnChangeLanguage("es");

    }

    public void OnChangeLanguage(string lang)
    {

        Language.Init("es");
        UITextTranslation[] tt = GameObject.FindObjectsOfType<UITextTranslation>();
        foreach (UITextTranslation t in tt)
        {
            t.SetText();
        }

    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dictionaryWorks
{
    private static Dictionary<string, string> language;
    private static languageList langList;
    public static void InitLang(string lang)
    {
        TextAsset ta = Resources.Load<TextAsset>("Diccionary/" + lang);
        langList = JsonUtility.FromJson<languageList>(ta.text);
        language = new Dictionary<string, string>();
        Debug.Log(langList.dictionary.Count);
        foreach (diccionaryScript diccScript in langList.dictionary)
        {
            language.Add(diccScript.key, diccScript.value);
            Debug.Log(diccScript.value);
        }
    }
    public static string GetString(string key)
    {
        if(language.ContainsKey(key))
        { return language[key];
        }
        return key;
    }
}


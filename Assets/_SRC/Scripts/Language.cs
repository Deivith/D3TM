using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.odaclick.d3.lang
{


    public class Language
    {

        private static Dictionary<string, string> language;

        public static void Init(string lang)
        {

            TextAsset ta = Resources.Load<TextAsset>("lang/" + lang);
            LanguageList langList = JsonUtility.FromJson<LanguageList>(ta.text);

            language = new Dictionary<string, string>();

            foreach (LanguageRef langRef in langList.lang)
            {
                language.Add(langRef.key, langRef.value);
            }

        }

        public static string GetString(string key)
        {

            if (language.ContainsKey(key))
            {
                return language[key];
            }

            return key;
        }

    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.odaclick.d3.lang
{
    public class Langues
    {
        private static Dictionary<string, string> language;

        public static void Init(string lang)
        {
            TextAsset la = Resources.Load<TextAsset>("lang/" + lang);
            LanguesList langList = JsonUtility.FromJson<LanguesList>(la.text);

            language = new Dictionary<string, string>();

            foreach (LanguesRef languesRef in langList.lang)
            {
                language.Add(languesRef.key, languesRef.value);
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


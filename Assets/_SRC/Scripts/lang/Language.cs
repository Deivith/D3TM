using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.odaclick.d3.lang {

    public class Language  {

        //
        private static Language _instance;
        public static Language instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Language();

                return _instance;
            }
        }
        //

        /*/* */
        private Dictionary<string, string> language;        

        public void Init(string lang) {

            TextAsset ta = Resources.Load<TextAsset>("lang/" + lang);
            LanguageList langList = JsonUtility.FromJson<LanguageList>(ta.text);

            language = new Dictionary<string, string>();

            foreach (LanguageRef langRef in langList.lang) {
                language.Add(langRef.key, langRef.value);
            }

        }

        public string GetString(string key) {

            if (language.ContainsKey(key)) {
                return language[key];
            }

            return key;
        }

        public void OnChangeLanguage(string lang) {

            UITextTranslation[] tt = GameObject.FindObjectsOfType<UITextTranslation>();
            foreach (UITextTranslation t in tt) {
                t.SetText();
            }

        }


    }


}

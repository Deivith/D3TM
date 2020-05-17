using com.odaclick.d3.config;
using com.odaclick.d3.core;
using com.odaclick.d3.storage;
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

        public void Init() {
            Init(GetCurrentLanguage());
        }

        public void Init(string lang) {

            TextAsset ta = Resources.Load<TextAsset>(Const.RESOURCES.LANG_FOLDER + lang);
            LanguageList langList = JsonUtility.FromJson<LanguageList>(ta.text);

            language = new Dictionary<string, string>();

            foreach (LanguageRef langRef in langList.lang) {
                language.Add(langRef.key, langRef.value);
            }

            OnChangeLanguage(lang);
            Storage.SaveString(Const.STORAGE.KEY_LANG, lang);

        }

        public string GetString(string key) {

            if (language.ContainsKey(key)) {
                return language[key];
            }

            return key;
        }

        public void OnChangeLanguage() {
            OnChangeLanguage(GetCurrentLanguage());
        }
        public void OnChangeLanguage(string lang) {

            UITextTranslation[] tt = GameObject.FindObjectsOfType<UITextTranslation>();
            foreach (UITextTranslation t in tt) {
                t.SetText();
            }

        }

        public string GetCurrentLanguage() {
            return Storage.GetString(Const.STORAGE.KEY_LANG,Config.instance.lang.defaultValue);
        }


    }


}

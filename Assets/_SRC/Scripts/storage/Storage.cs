using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.odaclick.d3.storage {


    public class Storage {

        public const string KEY_LANG = "lang";

        // Start is called before the first frame update
        public static void SaveString(string key, string value) {

            PlayerPrefs.SetString(key, value);
            PlayerPrefs.Save();

        }

        public static string GetString(string key,string defaultValue) {

            return PlayerPrefs.GetString(key,defaultValue);

        }

    }


}

using com.odaclick.d3.lang;
using com.odaclick.d3.storage;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Language.instance.Init(Storage.GetString(Storage.KEY_LANG,"en"));
        Language.instance.OnChangeLanguage("es");

    }
    


}

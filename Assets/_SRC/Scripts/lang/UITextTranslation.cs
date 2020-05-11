using com.odaclick.d3.lang;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITextTranslation : MonoBehaviour
{
    public string key;
    private Text UIText;

    // Start is called before the first frame update
    void Awake()
    {
        GetUIText();
    }

    private void GetUIText() {
        UIText = GetComponent<Text>();
    }

    public void SetText() {

        if (UIText == null) {
            GetUIText();
        }

        UIText.text = Language.instance.GetString(key);        

    }
    
}

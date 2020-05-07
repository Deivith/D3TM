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
        UIText = GetComponent<Text>();        
    }

    public void SetText() {
        UIText.text = Language.instance.GetString(key);
    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UITextTranslation : MonoBehaviour
{
    public string key;
    private Text UIText;
    void Awake()
    {
        UIText = GetComponent<Text>();
    }

    // Update is called once per frame
   public void SetText()
    {
        UIText.text = dictionaryWorks.GetString(key);
        
    }
}

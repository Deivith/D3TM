using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIButtonSpriteSelector : MonoBehaviour {

    private Button _UIButton;
    public Button UIButton
    {
        get
        {
            if (_UIButton == null) _UIButton = GetComponent<Button>();
            return _UIButton;
        }
    }

    public Sprite spriteSelected;
    public Sprite spriteUnselected;
    public Sprite spriteDisabled;

    // Start is called before the first frame update
    public void SetSelected()
    {
        SetStatusSprite(spriteSelected);
    }
    public void SetUnselected() {
        SetStatusSprite(spriteUnselected);
    }
    public void SetDisabled() {
        SetStatusSprite(spriteDisabled);
    }

    private void SetStatusSprite(Sprite sprite) {

        if (sprite == null) return;
        UIButton.GetComponent<Image>().overrideSprite = sprite;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIUtil { 

    public static void SetupSelectedButtonByName(List<GameObject> list, string match) {

        foreach (GameObject button in list) {
            UIButtonSpriteSelector spriteSelector = button.GetComponent<UIButtonSpriteSelector>();
            if (button.name.Equals(match)) {
                spriteSelector.SetSelected();
            } else {
                spriteSelector.SetUnselected();
            }
        }

    }

}

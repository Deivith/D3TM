using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPanel : MonoBehaviour
{

    public enum TYPE {
        SCALE,
        MOVE
    }

    public TYPE type;
    public int loopCount = 0;
    public float time = 1f;
    public float delay = 1.5f;
    public Vector3 value;

    public GameObject[] buttons;    

    // Start is called before the first frame update
    void Start()
    {        
        for(int i = 0; i < buttons.Length; i++) {

            switch (type) {
                case TYPE.SCALE:
                    LeanTween.scale(buttons[i], value, time).setLoopPingPong(loopCount).setDelay(delay * i);
                    break;
                case TYPE.MOVE:
                    LeanTween.move(buttons[i], value, time).setLoopPingPong(loopCount).setDelay(delay * i);
                    break;
            }

            
        }    
    }

}

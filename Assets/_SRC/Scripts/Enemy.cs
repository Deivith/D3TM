using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{    
    public enum TYPE {        
        BERSEKER,
        ASSASIN,
        PALADIN,
        PRIEST
    }
    public TYPE type;

    
    public int GetModifier() {

        switch (type) {
            case TYPE.BERSEKER:
                return 2;
            default:
                return 4;
        }

    }

}

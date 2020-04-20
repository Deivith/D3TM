using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeEntity : MonoBehaviour
{

    [Header("Health Settings")]
    public int life;

    [Range(0,100)]
    public int shield;
    
    public int mana;
    
}

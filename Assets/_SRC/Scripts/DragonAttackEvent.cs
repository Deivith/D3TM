using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonAttackEvent : MonoBehaviour
{
    public Player player;
    public void DoAttack() {
        player.CreateProjectil();
    }
}

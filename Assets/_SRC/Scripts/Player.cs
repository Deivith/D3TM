using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private LifeEntity lifeEntity;

    private void Start() {

        lifeEntity = GetComponent<LifeEntity>();

    }

    private void OnTriggerEnter(Collider other) {
        
        AttackerEntity attackerEntity = other.GetComponent<AttackerEntity>();
        if (attackerEntity != null) {
            int modifier = 1;
            Enemy enemy = other.GetComponent<Enemy>();
            if (enemy != null) modifier = enemy.GetModifier();
            lifeEntity.life -= attackerEntity.damage * modifier;
        }

        if (other.tag.Equals(Const.TAGS.PLAYER)) {
            Debug.Log("Collision con Player");
        }

    }

}

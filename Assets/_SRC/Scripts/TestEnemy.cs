using com.odaclick.enemies;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemy : MonoBehaviour
{
    public List<BaseEnemy> enemies;
    public BaseEnemy testComparission;

    private void Start() {

        for (int i = 0; i < enemies.Count; i++) {
            Debug.Log("Identifier: " + enemies[i].GetIdentifier());
            Debug.Log("Life: " + enemies[i].healthComponent.life);
            Debug.Log("Has Health" + enemies[i].HasHealthComponent());
            Debug.Log("Attack: " + enemies[i].Attack());
        }

        Debug.Log("Contains: " + enemies.Contains(testComparission));
        if (enemies.Contains(testComparission)) {
            enemies.Remove(testComparission); // no remueve el objeto de la escena
        }

        int identifier = 2;        
        BaseEnemy find = enemies.Find(item => item.GetIdentifier() == identifier);
        if (find != null) {
            Debug.Log("Find: " + find.GetIdentifier() + " - " + find.Attack());
            if(find is InmortalEnemy) {                
                Debug.Log( (find as InmortalEnemy).PowerUp() );
            }
        }

    }


}

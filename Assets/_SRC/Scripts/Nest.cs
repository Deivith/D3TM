using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nest : MonoBehaviour {

    public float life = 100f;
    public float cadency;
    public GameObject[] enemies;
    public GameObject spawnPoint;

    private float initialLife;
    public Color healthy;
    public Color damaged;

    public AudioSource spawnFX;
    
    private GameManager gameManager;

    private void Start()
    {        
        StartCoroutine("Spawn");
        initialLife = life;
        GetComponent<Renderer>().material.SetColor("_Color", healthy);
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    private IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(cadency);

            if (gameManager.IsSpawnAllowed())
            {
                if (!spawnFX.isPlaying)
                {
                    spawnFX.Play();
                }
                spawnPoint.SetActive(true);
                int index = Random.Range(0, enemies.Length);
                Instantiate(enemies[index], spawnPoint.transform.position, Quaternion.identity);
                gameManager.OnEnemySpawned();
                

            }
        }
        
    }

    public void ReceiveDamage(float damage)
    {
        life -= damage;

        Color c = Color.Lerp(damaged, healthy, (life * 100 / initialLife) * .01f);
        GetComponent<Renderer>().material.SetColor("_Color", c);

        if(life <=0)
        {
            
            for(int i = 0; i < 5; i++)
            {
                Vector3 pos = transform.position;
                pos.x += Random.Range(-2f, 2f);
                pos.y += Random.Range(-2f, 2f);
                pos.z += Random.Range(-2f, 2f);
                Instantiate(Resources.Load("Explotion"), pos, Quaternion.identity);
            }

            gameManager.OnNestDestroyed();

            Destroy(gameObject);

        }

    }

}

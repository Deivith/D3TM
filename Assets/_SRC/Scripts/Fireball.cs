using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour {

    private Transform t;
    public float damage = 10f;
    public float speed = 20f;


	// Use this for initialization
	void Start () {

        t = transform;

        // 
        Destroy(gameObject, 10f);

	}
	
	// Update is called once per frame
	void Update () {

        t.Translate(Vector3.forward * speed * Time.deltaTime);
        
	}

    private void OnCollisionEnter(Collision collision)
    {
        string tag = collision.gameObject.tag;        
        Instantiate(Resources.Load("Explotion"), t.position, Quaternion.identity);

        if (tag.Equals("Nest"))
        {
            collision.gameObject.GetComponent<Nest>().ReceiveDamage(damage);

        }

        if (tag.Equals("Enemy"))
        {
            collision.gameObject.GetComponent<Enemy>().ReceiveDamage(damage);

        }


        Destroy(gameObject);

    }
}

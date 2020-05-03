using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour {
    
    public float life;
    public float damage;

    private Animator animator;
    private Transform target;
    private NavMeshAgent navMesh;

	// Use this for initialization
	void Start () {

        target = GameObject.FindGameObjectWithTag("Player").transform;
        navMesh = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {

        navMesh.SetDestination(target.position);


    }

    public void ReceiveDamage(float damage)
    {
        life -= damage;
        if(life > 0)
        {
            animator.SetTrigger("damage");
        }
        else
        {
            navMesh.isStopped = true;
            navMesh.speed = 0f;
            animator.SetTrigger("die");
            Destroy(GetComponent<SphereCollider>());
            Destroy(GetComponent<Rigidbody>());
            Destroy(gameObject, 2f);

            GameObject.FindObjectOfType<GameManager>().OnEnemyDead();

        }
    }

}

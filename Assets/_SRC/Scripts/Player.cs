using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    private Transform t;
    private Transform c;

    public float shootCadency = 1f;    
    public float rotationSpeed = 180f;
    public float speed = 8f;
    private float initialLife;
    public float life = 100f;

    public enum MODE
    {
        DRAGON,
        WOLF
    }
    public GameObject dragon;
    public GameObject wolf;

    public Image healthBar;

    private MODE mode;
    private Animator animator;
    private bool canFire;

    // Use this for initialization
    void Start () {

        t = transform;
        c = Camera.main.transform;

        canFire = true;
        mode = MODE.DRAGON;
        ToggleMode();

        initialLife = life;
    }
	
	// Update is called once per frame
	void Update () {

     
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * GetSpeed();

        t.Rotate(0, x, 0);
        if(z > 0) {

            UpdateWalkingAnimator(true);
            t.Translate(0, 0, z);

        }else {
            UpdateWalkingAnimator(false);                
        }

        //
        if (Input.GetKeyDown(KeyCode.Space))
        {            
            ToggleMode();
        }

        if (Input.GetMouseButton(0) && canFire && mode.Equals(MODE.DRAGON))
        {
            canFire = false;
            animator.SetTrigger("attack");
            Vector3 pos = t.position;
            pos.y += 1f;
            Instantiate(Resources.Load("Fireball"),pos , t.rotation);
            Invoke("AllowFiring", shootCadency);
        }
        
        //
        c.position = new Vector3(t.position.x,15f,t.position.z-10f);

    }


    private void AllowFiring()
    {
        canFire = true;
    }

    private void UpdateWalkingAnimator(bool value){

        if (mode.Equals(MODE.WOLF))
        {            
            animator.SetBool("walking", value);
        }
    }


    private float GetSpeed()
    {

        /// en modo dragon no camina
        float modifier = mode.Equals(MODE.WOLF)?1f:0f;        
        return speed * modifier;

    }

    private void ToggleMode()
    {        
        switch (mode)
        {
            case MODE.DRAGON:
                wolf.SetActive(true);                
                animator = wolf.GetComponent<Animator>();
                mode = MODE.WOLF;
                dragon.SetActive(false);                
                break;
            case MODE.WOLF:                
                dragon.SetActive(true);
                animator = dragon.GetComponent<Animator>();
                mode = MODE.DRAGON;
                wolf.SetActive(false);
                break;
        }

    }


    private void OnCollisionEnter(Collision collision)
    {
        GameObject go = collision.gameObject;        
        string tag = go.tag;
        if (tag.Equals("Enemy"))
        {
            //
            float damage = go.GetComponent<Enemy>().damage;
            life -= damage;
            Vector3 p = t.position;
            p.y += 2f;
            Instantiate(Resources.Load("Enemies/Explotion"), p, Quaternion.identity);
            Destroy(go);

            // actualizar UI
            healthBar.fillAmount = (life * 100 / initialLife) * .01f;

            // die or damage animation
            if (life > 0)
            {
                animator.SetTrigger("damage");
            }
            else
            {
                GameObject.FindObjectOfType<GameManager>().GameOver();
                animator.SetTrigger("die");
            }

        }
    }
}

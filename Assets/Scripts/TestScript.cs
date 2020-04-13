using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private float projectBreaker;
    // Start is called before the first frame update
    void Start()
    {
        projectBreaker = 0;
        Laugh();
        Debug.Log("Initializing");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void AddContent() {
        Debug.Log("Adding Content");
    }

    private void Mover()
    {
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime);
        
    }
    private void Laugh()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Jajajaja");
        }

        
    }



}

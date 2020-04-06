using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    private float projectBreaker;
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Initializing");
        projectBreaker = 10;
        HateMe();
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
    private void HateMe()
    {
        while (projectBreaker < 100)
        {
            Debug.Log("HAHAHAHAHAHHA");
            projectBreaker = 10;
        }
    }
    
}

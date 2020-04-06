using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        while (i < 5)
        {
            Debug.Log("Jajajaja");
        }
        
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


}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Initializing");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Mover()
    {
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime);
    }
}

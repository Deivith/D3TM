using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEntity : MonoBehaviour
{
    public TestFieldA fields;

    private void Start() {

        Debug.Log(fields.Sum());

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TestFieldA 
{
    public int fieldA;
    public int fieldB;
    public int fieldC;

    public int Sum() {
        return fieldA + fieldB + fieldC;
    }

}

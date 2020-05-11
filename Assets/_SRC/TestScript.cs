using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using com.odaclick.d3.lang;

public class TestScript : MonoBehaviour
{
    Langues lang;
    // Start is called before the first frame update
    void Start()
    {
        Langues.GetString("btn_options");
        Langues.GetString("plaasdas");
    }
}

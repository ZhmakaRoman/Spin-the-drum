using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparentFront : MonoBehaviour
{
    private void Awake()
    {
       var unused =  GetComponent<Renderer>().enabled = false;
    }
}

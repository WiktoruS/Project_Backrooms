using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roof_visible : MonoBehaviour
{
    void Start() 
    {
        this.GetComponent<MeshRenderer>().enabled = true;
    }
    
}

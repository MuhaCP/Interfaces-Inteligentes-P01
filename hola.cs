using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hola : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello I'm a " + gameObject.name + "and my tag is " + gameObject.tag);
    }
}

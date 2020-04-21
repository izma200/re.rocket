using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocktengine : MonoBehaviour
{
   
    private ParticleSystem particle;
   
    // Start is called before the first frame update
    void Start()
    {
        particle = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
 
        if (Input.GetKeyUp(KeyCode.Space)||Input.GetKeyDown(KeyCode.Space))
        {
            particle.Play();
        }
    }  
}

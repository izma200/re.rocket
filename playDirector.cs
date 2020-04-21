using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playDirector : MonoBehaviour
{
    [SerializeField] private Renderer Rocket_object;
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!Rocket_object.isVisible)
        {
            SceneManager.LoadScene("ROCKET.end");
        }    
    }
}

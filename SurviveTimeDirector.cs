using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class SurviveTimeDirector : MonoBehaviour
{
    [SerializeField] private Renderer Rocket_object;
    public GameObject SurviveTimer;
    public GameObject Rocket;
    public static float time = 0.0f;

    private void Awake()
    {
        
    }

    // Start is called before the first frame update
    void Start()
    {
        this.SurviveTimer = GameObject.Find("surviveTime");
    }
    

    // Update is called once per frame
    void Update()
    {

        var cache = Rocket.GetComponent<Renderer>().isVisible;
        this.Rocket = GameObject.Find("Rocket");

       time += cache ? Time.deltaTime : 0;
        this.SurviveTimer.GetComponent<Text>().text = time.ToString("F1");
        if (!cache && time >= 1.0f){
            SceneManager.LoadScene("ROCKET.end");
        }
    }
}

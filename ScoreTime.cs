using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTime : MonoBehaviour
{
    public  float SaveTime;

    // Start is called before the first frame update
    void Start()
    {
       
        SaveTime = SurviveTimeDirector.time;
        GetComponent<Text>().text = SaveTime.ToString("F1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    public GameObject[] PlanetScript;
    public float BurnPlanetTime = 8.5f;
    public float AddTime1;
    public float AddTime2;
    public GameObject Background;
    public float AddbackgroundTime = 10.0f;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float RandomX = UnityEngine.Random.Range(-20.0f, 20.0f);
        int RandomPlanet = UnityEngine.Random.Range(0, 10);
      
        AddTime1 += Time.deltaTime;
        AddTime2 += Time.deltaTime;
        if (AddTime1 >= BurnPlanetTime)
        {
            Vector3 Camera_object = GameObject.Find("Main Camera").transform.position;
     
            Instantiate(PlanetScript[RandomPlanet], new Vector3(RandomX, Camera_object.y + 20.0f, -1.0f), Quaternion.identity);

            if (BurnPlanetTime > 1.0)
                BurnPlanetTime = BurnPlanetTime * 0.93f;
                AddTime1 = 0;
        }
        if (AddTime2 >= AddbackgroundTime)
        {
            Vector3 Camera_object = GameObject.Find("Main Camera").transform.position;
            Instantiate(Background, new Vector3(0.0f, Camera_object.y + 200.0f, 0.0f), Quaternion.identity);
            AddTime2 = 0;
        }


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float CameraSpeed = 1.8f;
    public float AddCameraTime;
    public float CameraSpeedUp = 9.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AddCameraTime += Time.deltaTime;
        if (AddCameraTime >= CameraSpeedUp)
        {
            CameraSpeed = CameraSpeed * 1.2f;
            AddCameraTime = 0;
        }

            GameObject camera_object = GameObject.Find("Main Camera");
        GetComponent<UnityEngine.Camera>().gameObject.transform.Translate(new Vector3(0.0f, 0.05f*CameraSpeed, 0.0f));
         
    }
}

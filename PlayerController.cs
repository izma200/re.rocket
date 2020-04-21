using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float jumpForce = 32.0f;
    float sideForce = 12.0f;
  
    public float aAddCameraTime;
    public float aCameraSpeedUp = 9.8f;
    public Button Left;
    public Button Right;
    public Button Up;
    float key = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        Left = GetComponent<Button>();
        Right = GetComponent<Button>();
        Up = GetComponent<Button>();
    }

   
    //スマホ操作用ボタン
    public void LButtonDown()
    {
        key = 1.0f;
    }
    public void RButtonDown()
    {
        key = -1.0f;
    }
    public void UpButtonDown()
    {
        this.rigid2D.AddForce(transform.up * this.jumpForce);
    }


    void Update()
    {
       
      

        //キーボード操作の場合
        if (Input.GetKey(KeyCode.RightArrow))
        {
            key = 1.0f;
        }
   
        if (Input.GetKey(KeyCode.LeftArrow))
            {
            key = -1.0f;
        }
        
        if (Input.GetKey(KeyCode.Space))
        {
            this.rigid2D.AddForce(transform.up * this.jumpForce);
        }

        this.rigid2D.AddForce(transform.right * key * this.sideForce);
        aAddCameraTime += Time.deltaTime;
        if (aAddCameraTime >= aCameraSpeedUp)
        {
            this.jumpForce = this.jumpForce * 1.1f;
            this.sideForce = this.sideForce * 1.1f;
            aAddCameraTime = 0;
        }

    }
}

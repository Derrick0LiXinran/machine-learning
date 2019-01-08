using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class first_trigger : MonoBehaviour
{
    public float possibility;
    public int target;
    void OnTriggerEnter(Collider other)
    {
        possibility = Random.Range(0, 100);
        SphereCollider sphere = GetComponent<SphereCollider>();
        BoxCollider box = GetComponent<BoxCollider>();
        if (possibility <= 30) {
            target = 1;
            sphere.isTrigger = true;
        }
        else{
            target = 2;
            box.isTrigger = true; 
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        //float x = Input.GetAxis("Vertical") * possibility;
        //float z = Input.GetAxis("Horizontal") * possibility;
        //x *= Time.deltaTime;
        //z *= Time.deltaTime;
       //string path = "C:\\Users\\A\\Desktop\\screenshot_unity\\mid\\"; 
        int i = 1;

      
        if (possibility < 20)
        {
            transform.position = transform.position + new Vector3(-0.01f, 0, -0.01f);
        }
        else if (possibility < 40)
        {
            transform.position = transform.position + new Vector3(0, 0, -0.01f);
        }
        else if (possibility < 60)
        {
            transform.position = transform.position + new Vector3(-0.01f, 0, 0);
        }
        else if (possibility < 80)
        {
            transform.position = transform.position + new Vector3(0,  0, 0);
        }
        else
        {
            transform.position = transform.position + new Vector3(-0.01f, 0, -0.01f);
        } 


        string temp =  "mid" + i + ".png";
        ScreenCapture.CaptureScreenshot(temp);
        i += 1;
    }
}

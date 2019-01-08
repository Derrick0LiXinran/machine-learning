using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class first_character : MonoBehaviour
{
    //public string path = "C:\\Users\\A\\Desktop\\screenshot_unity\\first\\";
    int i;
    int max;
    string line;
    // Start is called before the first frame update
    void Start()
    {
        i = 1;
        try {       
            //Pass the file path and file name to the StreamReader constructor
            //string path = "C:\\Users\\A\\Desktop\\screenshot_unity\\mid\\"; 
            //int i = 1;
            System.IO.StreamReader sr = new System.IO.StreamReader(@"/Users/Derrick_Burn/desktop/Sample.txt");

            //Read the first line of text
            string line = sr.ReadLine();
            int num = System.Int32.Parse(line);
            for(int j = 0; j < num; j++){
                line = sr.ReadLine();
                string[] words = line.Split(' ');
                int x = System.Int32.Parse(words[0]);
                int y = System.Int32.Parse(words[1]);
                int z = System.Int32.Parse(words[2]);
                float ax = float.Parse(words[3]);
                float ay = float.Parse(words[4]);
                float az = float.Parse(words[5]);
                transform.position = new Vector3(x,y,z);
                transform.Rotate(ax,ay,az);
                string tem =  i + ".png";
                i++;
                ScreenCapture.CaptureScreenshot(tem);
                
             //i += 1;
            } 
            /*string[] words = line.Split(' ');
            int x = System.Int32.Parse(words[0]);
            int y = System.Int32.Parse(words[1]);
            int z = System.Int32.Parse(words[2]);
            float ax = float.Parse(words[3]);
            float ay = float.Parse(words[4]);
            float az = float.Parse(words[5]);
            transform.position = new Vector3(x,y,z);
            transform.Rotate(ax,ay,az);
            string temp =  i + ".png";
            ScreenCapture.CaptureScreenshot(temp);
             i += 1;
            //Continue to read until you reach end of file
            line = sr.ReadLine();
            while (line != null){
                //write the lie to console window
                //Read the next line
                words = line.Split(' ');
                x = System.Int32.Parse(words[0]);
                y = System.Int32.Parse(words[1]);
                z = System.Int32.Parse(words[2]);
                ax = float.Parse(words[3]);
                ay = float.Parse(words[4]);
                az = float.Parse(words[5]);
                transform.position = new Vector3(x, y, z);
                transform.Rotate(ax, ay, az);
                temp =  i + ".png";
                ScreenCapture.CaptureScreenshot(temp);
                i += 1;
                line = sr.ReadLine();

            }*/

            //close the file
            sr.Close();
            System.Console.ReadLine();
        }
        catch(System.Exception e)
        {
            System.Console.WriteLine("Exception: " + e.Message);
        }
        
    }

    // Update is called once per frame
    void Update()
    { 
      
       /*try {       
            //Pass the file path and file name to the StreamReader constructor
            //string path = "C:\\Users\\A\\Desktop\\screenshot_unity\\mid\\"; 
            //int i = 1;
            System.IO.StreamReader sr = new System.IO.StreamReader("/Users/Derrick_Burn/desktop/Sample.txt");
            
            //Read the first line of text
            if(i == 1){
                line = sr.ReadLine();
                max = System.Int32.Parse(line);
                line = sr.ReadLine();
                string[] words = line.Split(' ');
                int x = System.Int32.Parse(words[0]);
                int y = System.Int32.Parse(words[1]);
                int z = System.Int32.Parse(words[2]);
                float ax = float.Parse(words[3]);
                float ay = float.Parse(words[4]);
                float az = float.Parse(words[5]);
                transform.position = new Vector3(x,y,z);
                transform.Rotate(ax,ay,az);
                string temp =  i + ".png";
                ScreenCapture.CaptureScreenshot(temp);
                i += 1;
                line = sr.ReadLine();

            } else if(i == max+1){
                string[] words = line.Split(' ');
                int x = System.Int32.Parse(words[0]);
                int y = System.Int32.Parse(words[1]);
                int z = System.Int32.Parse(words[2]);
                float ax = float.Parse(words[3]);
                float ay = float.Parse(words[4]);
                float az = float.Parse(words[5]);
                transform.position = new Vector3(x,y,z);
                transform.Rotate(ax,ay,az);
                string temp =  i + ".png";
                ScreenCapture.CaptureScreenshot(temp);
                i += 1;
                sr.Close();
                //System.Console.ReadLine();

            } else if(line != null){
                string[] words = line.Split(' ');
                int x = System.Int32.Parse(words[0]);
                int y = System.Int32.Parse(words[1]);
                int z = System.Int32.Parse(words[2]);
                float ax = float.Parse(words[3]);
                float ay = float.Parse(words[4]);
                float az = float.Parse(words[5]);
                transform.position = new Vector3(x,y,z);
                transform.Rotate(ax,ay,az);
                string temp =  i + ".png";
                ScreenCapture.CaptureScreenshot(temp);
                i += 1;
                line = sr.ReadLine();
            }
            

            //close the file
            
        }
        catch(System.Exception e)
        {
            System.Console.WriteLine("Exception: " + e.Message);
        }
        /* float x = Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Horizontal") * speed;
        x *= Time.deltaTime;
        z *= Time.deltaTime;
        float pos = Random.Range(0, 100);*/
        /* if (pos < 20)
        {
            transform.position = transform.position + new Vector3(-0.01f, 0, -0.01f);
        }
        else if (pos < 40)
        {
            transform.position = transform.position + new Vector3(0, 0, -0.01f);
        }
        else if (pos < 60)
        {
            transform.position = transform.position + new Vector3(-0.01f, 0, 0);
        }
        else if (pos < 80)
        {
            transform.position = transform.position + new Vector3(0,  0, 0);
        }
        else
        {
            transform.position = transform.position + new Vector3(-0.01f, 0, -0.01f);
        } */

        /*transform.position = transform.position + new Vector3(-0.04f,0,0);
        
        //Vector3 temp = transform.position;
        int x = 5;
        int y = 5;
        int z = 5;
        float ax;
        float ay;
        float az;

        transform.position = transform.position + new Vector3(x - transform.position.x, y - transform.position.y, z - transform.position.z);
 
        transform.Rotate(ax, ay, az);*/
        /* string temp = i + ".png";
        ScreenCapture.CaptureScreenshot(temp);
        i += 1; */
        /*transform.Translate(x, 0, 0);
        temp = path + i + ".png";
        ScreenCapture.CaptureScreenshot(temp);
        i += 1;*/
        /*Texture2D screenImage = new Texture2D(Screen.width, Screen.height);
        //Get Image from screen
        screenImage.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        screenImage.Apply();
        //Convert to png
        byte[] imageBytes = screenImage.EncodeToPNG();

        //Save image to file
        System.IO.File.WriteAllBytes(path, imageBytes);*/
        /*transform.Translate(0, x, 0);
        temp = path + i + ".png";
        ScreenCapture.CaptureScreenshot(temp);
        i += 1;*/

    }
}

 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
 int i = 1;
    // Start is called before the first frame update
    void Start()
    {
        System.IO.StreamReader sr = new System.IO.StreamReader(@"/Users/Derrick_Burn/desktop/Sample.txt");
        try
        {
           
            string line = sr.ReadLine();
            string[] words = line.Split(' ');
            int x = System.Int32.Parse(words[0]);
            int y = System.Int32.Parse(words[1]);
            int z = System.Int32.Parse(words[2]);
            float ax = float.Parse(words[3]);
            float ay = float.Parse(words[4]);
            float az = float.Parse(words[5]);
            transform.position = new Vector3(x, y, z);
            transform.Rotate(ax, ay, az);
            string temp = i + ".png";
            ScreenCapture.CaptureScreenshot(temp);
            i++;

            line = sr.ReadLine();
            while(line != null)
            {
                words = line.Split(' ');
                x = System.Int32.Parse(words[0]);
                y = System.Int32.Parse(words[1]);
                z = System.Int32.Parse(words[2]);
                ax = float.Parse(words[3]);
                ay = float.Parse(words[4]);
                az = float.Parse(words[5]);
                transform.position = new Vector3(x, y, z);
                transform.Rotate(ax, ay, az);
                temp = i + ".png";
                ScreenCapture.CaptureScreenshot(temp);
                i++;
                line = sr.ReadLine();
            }
                
        } catch(System.Exception e)
        {
            System.Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            sr.Close();
        }
    }
}
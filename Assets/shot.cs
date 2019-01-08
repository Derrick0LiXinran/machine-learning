using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour {

	System.IO.StreamReader sr;
	int i = 1;
	int max;
    string line;
	float x ;
    float y ;
    float z ;
    float ax ;
    float ay ;
    float az ;


	// Use this for initialization
	void Start () {
		sr = new System.IO.StreamReader("/Users/Derrick_Burn/desktop/Sample.txt");
	}
	
	// Update is called once per frame
	void Update () {
		if(i == 1){
			line = sr.ReadLine();
                max = System.Int32.Parse(line);
                line = sr.ReadLine();
				//i += 1;
                string[] words = line.Split(' ');
                 x = System.Int32.Parse(words[0]);
                 y = System.Int32.Parse(words[1]);
                 z = System.Int32.Parse(words[2]);
                 ax = float.Parse(words[3]);
                 ay = float.Parse(words[4]);
                 az = float.Parse(words[5]);
                transform.position = new Vector3(x,y,z);
                transform.Rotate(ax,ay,az);
                string temp =  i + ".png";
                ScreenCapture.CaptureScreenshot(temp);
				i += 1;
                line = sr.ReadLine();
		}else if(i == (max+1)){
			    string[] words = line.Split(' ');
                 x = System.Int32.Parse(words[0]);
                 y = System.Int32.Parse(words[1]);
                 z = System.Int32.Parse(words[2]);
                 ax = float.Parse(words[3]);
                 ay = float.Parse(words[4]);
                 az = float.Parse(words[5]);
                transform.position = new Vector3(x,y,z);
                transform.Rotate(ax,ay,az);
                string temp =  i + ".png";
                ScreenCapture.CaptureScreenshot(temp);
                i += 1;
                sr.Close();
                //System.Console.ReadLine();

		}else if(line != null){
			    string[] words = line.Split(' ');
                 x = System.Int32.Parse(words[0]);
                 y = System.Int32.Parse(words[1]);
                 z = System.Int32.Parse(words[2]);
                 ax = float.Parse(words[3]);
                 ay = float.Parse(words[4]);
                 az = float.Parse(words[5]);
                transform.position = new Vector3(x,y,z);
                transform.Rotate(ax,ay,az);
                string temp =  i + ".png";
                ScreenCapture.CaptureScreenshot(temp);
                i += 1;
                line = sr.ReadLine();
		}
	}
}

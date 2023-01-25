using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    public int time = 100;
    public string weather = "Clear";
    public bool isLightGreen =  true;
    public float gpa = 3.25f;
    public double temperature = 101.45d;

    // Start is called before the first frame update
    void Start()
    {

        //Check Time
        if(time >= 200)
        {
            Debug.Log("Rise and shine!");
        } 
        else
        {
            Debug.Log("It's too early, go back to bed!");
        }

        /*
        if(conditional_01)
        {
            //If condition_01 is true, run this code
        }
        else if (conditional_02)
        {
            //If conditional_02 is true, run this code
        }
        else
        {
            //If no other conditions are true, run this code.
        }
        */

    }

    // Update is called once per frame
    void Update()
    {

       //Check Weather
       if(weather == "Cloudy")
       {
          Debug.Log("It is cloudy outside");
       }
       else if(weather == "Raining")
       {
          Debug.Log("It is raining outside!");
       }
       else if(weather == "Clear")
       {
          Debug.Log("It is a beautiful day outside!");
       }
       else if(weather == "ThunderLightning")
       {
           Debug.Log("There is thunder and lightning outside, stay indoors!");
       }
       else if(weather == "Snowing")
       {
          Debug.Log("Its snowing, bundle up it is cold");
       }
       else
       {
            Debug.Log("Weather unknown.");
       }
 

        //Check light
        if(isLightGreen == true)
        {
            Debug.Log("Proceed");
        }
        else
        {
            Debug.Log("Come to a stop, do not proceed into intersection");
        }


        //GPA
        if(gpa >= 3.9)
        {
            Debug.Log("A+, nice work!");
        }

        else if(gpa >= 3.5)
        {
            Debug.Log("Very good!");
        }
        else if(gpa >= 3.0)
        {
            Debug.Log("You got this!");
        }
        else
        {
            Debug.Log("Don't give up, keep trying!");
        }


        //Temperature
        if(temperature >= 75)
        {
            Debug.Log("Sure am glade to have AC!");
        }
        else if(temperature <=65)
        {
            Debug.Log("Lets get the heater going!");
        }
        else
        {
            Debug.Log("Can't complain.");
        }

    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class timer : MonoBehaviour
{
    // public float timeRemaining = 10;
    public float timepassed;

    void start(){

    }
    void Update()
    {
        timepassed += Time.deltaTime;
        // if (timeRemaining > 0)
        // {
        //     timeRemaining -= Time.deltaTime;
        //     Debug.Log(timeRemaining);

        //     if(timeRemaining == 5){
        //         Debug.Log("5 sec");
        //     }
        // }


    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 5; // speed value (can be changed from unity)

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float h = Input.GetAxis("Horizontal"); //gets horizontal movement input and assigns to h
        float v = Input.GetAxis("Vertical"); //gets vertical movement input and assigns to v 

        Vector2 pos = transform.position; //sets pos to current position on screen

        pos.x += h * Time.deltaTime; //calculates the distance moved on x axis
        pos.y += v * Time.deltaTime; //calculates the distance moved on y axis

        transform.position = pos; //sets current position to new pos
    }
}

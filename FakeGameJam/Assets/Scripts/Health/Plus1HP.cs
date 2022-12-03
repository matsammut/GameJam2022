using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plus1HP : MonoBehaviour
{

    //to dissapear on collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            /*
            if (health < 5)
            {
                health++;
            }*/
        }
    }


}

/*
 * generated with random map generation (we'll have multiple clones, some with the +hp, some without)
 */

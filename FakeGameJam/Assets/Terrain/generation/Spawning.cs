using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
  public GameObject basicPlatform;
  public GameObject enemySpawn;
  public GameObject Stairs;
  public GameObject Jump;
  public GameObject JumpAndDuck;
  public GameObject Gaps;

  public Transform[] nextSection;
  public int randomSection = 0;
  public int distance = 15;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D other)
     {
       Debug.Log("Collided");
       //Detect player collision with current section to spawn the next.
       int randomSection = Random.Range(0,7);

       if (other.gameObject.tag == "Player") {

         Debug.Log("Triggered");

        Vector3 spawnPosition = transform.position + new Vector3 (distance, 0, 0);
        Debug.Log("Triggered next");
        Quaternion spawnRotation = Quaternion.identity;
        Debug.Log("Triggered next 2");
        Instantiate (nextSection[randomSection], spawnPosition, spawnRotation);
        Destroy(GetComponent<Spawning>());
       }

     }

}

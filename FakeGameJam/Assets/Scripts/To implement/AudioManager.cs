using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


/*
 * Ok besties, these need to be implemented to their respective gameobjects
 * 
 * 
 * Token: added in the Plus1HP script to sound during a collision with the player.
 * I've added the audio source component to the prefab with the default sound matchstick.
 *                         Public AudioSource matchstick;
 * In start method -->     matchstick = GetComponent<AudioSource>();
 * In collision method --> matchstick.Play();
 *  
 *  
 * Flickering Lights:
 * Needs an audio source component with the sound flickering lights attached.
 * Should play on awake and it'll terminte by itself when the scene changes.
 *  
 *  
 * Player walking:
 * Attach the audio source component with the audio player walking.
 *      Public AudioClip walking;
 *     Public AudioSource walking; 
 *     walking = GetComponent<AudioSource>();
 * Add this method and refernce it in the if statement for when he walks left or right.
 *      void playSound()
 *      {
 *          walking.PlayOneShot(walking);
 *      }
 *      
 *      
 * Damage:
 * For the enemy gameObject add the audio source component and attach  the damage audio.
 * In the enemy script we need to add:
 *      Public AudioClip damage;
 *      Public AudioSource damage; 
 *      damage = GetComponent<AudioSource>();
 * And in the collider method add:
 *          if(collision.gameObject.CompareTag("Player"))
 *          {
 *              damage.PlayOneShot(damage);
 *              Destory(gameObject);
 *          }
 *      
 * 
 * Death:
 * For the player gameObject add another audio source component and attach  the fire dies out audio.
 * In the player script we need to add:
 *      Public AudioClip fireDiesOut;
 *      Public AudioSource death; 
 *      death = GetComponent<AudioSource>();
 * And in the collider method add:
 *     if(health == 0)
 *     {
 *          death.PlayOneShot(fireDiesOut);
 *     }
 *     
 *     
 * Enemy Idle:
 * For the enemy gameObject add another audio source component and attach  the enemy audio.
 * In the player script we need to add:
 *      Public AudioClip enemy;
 *      Public AudioSource idle; 
 *      death = GetComponent<AudioSource>();
 * And while the enemy is on screen it should play.
 *      death.PlayOneShot(idle);
 *      
 *      
 * Raven:
 * NOTE! the raven noise has not been added to the folders
 * Give it an audio source component.
 * Add these to the code:
 *       Public AudioSource caw; 
 *       caw = GetComponent<AudioSource>();
 *       var prob;
 * Once the raven starts following the player it'll make the noise at random intervals of time.
 * I'm implemting this by randomly generating a number ever 5 seconds, if it is in a particular range, the noise plays.
 *  IEnumerator FiveSeconds()
 *  {
 *      while (true)
 *      {
 *           yield return new WaitForSeconds(0.5f);
 *           noise();
 *      }
 *  }
 *  
 *  void noise()
 *  {
 *      prob = Random.Range(0, 10);
 *      if(prob >= 8)
 *      {
 *          caw.Play();
 *      }
 *  }
 *  
 *  And in the start() method add:
 *     StartCoroutine(FiveSeconds());
 *       
 * 
 * Need to add for the buttons and slider
 * 
 */

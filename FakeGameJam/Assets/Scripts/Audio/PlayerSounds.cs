using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PlayerSounds : MonoBehaviour
{
    public AudioClip matchstick;
    public AudioClip damage;
    AudioSource audioSource;
       

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Collider collision = GetComponent<Collider>();
        PlayerPrefs.SetFloat("volume", 0.5f);

    }



    void OnTriggerEnter2D(Collider2D collision)
    {
        bool positive;

        if (collision.gameObject.CompareTag("Heal"))
        {
            audioSource.PlayOneShot(matchstick, PlayerPrefs.GetFloat("volume"));
            positive = true;
            Epops.popUp(positive);
        }
        else if (collision.gameObject.CompareTag("Damage"))
        {
            audioSource.PlayOneShot(damage, PlayerPrefs.GetFloat("volume"));
            positive = false;
            Epops.popUp(positive);
        }
    }

    
}

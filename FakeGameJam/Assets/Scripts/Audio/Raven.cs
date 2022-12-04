using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raven : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip raven;
   
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Invoke("audioSource", 3.0f);

    }

    void playAudio()
    {
        audioSource.PlayOneShot(raven, 0.8f);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class volume_slider : MonoBehaviour {

    //public AudioMixer audioMixer;

    public void SetVolume (float volume)
    {
        PlayerPrefs.SetFloat("volume", volume);

    }

}

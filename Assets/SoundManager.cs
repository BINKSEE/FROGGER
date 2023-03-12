using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    
    public static AudioClip froggerDeath;
    static AudioSource audioSrc;

    void Start()
    {
        froggerDeath = Resources.Load<AudioClip>("froggerDeath");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound (string clip)
    {
        switch (clip) {
            case "Death":
                audioSrc.PlayOneShot (froggerDeath);
                break;
        }
    }
}

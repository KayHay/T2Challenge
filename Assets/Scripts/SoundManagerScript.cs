using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip winSound;

    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        winSound = Resources.Load<AudioClip> ("win");

        audioSrc = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "win":
            audioSrc.PlayOneShot (winSound);
            break;
        }
    }
}
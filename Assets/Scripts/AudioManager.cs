using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager instance;

    

    public AudioClip pickup, obstacle,coinPickup, yuppie,ouch;
    [SerializeField] AudioSource audioSource;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(AudioClip sound)
    {
        audioSource.PlayOneShot(sound,6f);
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

    public AudioClip quietMusic, fastMusic;

    private AudioSource audioSource;
    private Helmet helmet;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        helmet = GameObject.FindObjectOfType<Helmet>();
	}
	
	// Update is called once per frame
	void Update () {
		if (helmet.helmetOff)
        {
            audioSource.clip = fastMusic;
            audioSource.volume = 1f;
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        } else
        {
            audioSource.clip = quietMusic;
            audioSource.volume = 0.1f;

            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundWaves : MonoBehaviour {

    public float damageDistance;

    public float audioNormalDistance = 10f;
    public float audioBoostedDistance = 30f;

    private Health health;
    private AudioSource audioSource;
    private Helmet helmet;
	
    // Use this for initialization
	void Start () {
        health = GameObject.FindObjectOfType<Health>();
        audioSource = GetComponent<AudioSource>();
        helmet = GameObject.FindObjectOfType<Helmet>();
	}
	
	// Update is called once per frame
	void Update () {
        float distanceToPlayer = Vector3.Magnitude(health.transform.position - this.transform.position);

        if (distanceToPlayer <= damageDistance)
        {
            health.ReduceHealth();
        }

        if (helmet.helmetOff)
        {
            audioSource.maxDistance = audioBoostedDistance;
            audioSource.volume = 0.6f;
        } else
        {
            audioSource.maxDistance = audioNormalDistance;
            audioSource.volume = 0.3f;
        }
	}
}

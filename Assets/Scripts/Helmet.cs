using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helmet : MonoBehaviour {

	public bool helmetOff = false;

	private Health health;
    private SoundWaves[] soundWaves;

	// Use this for initialization
	void Start () {
		health = GetComponent<Health> ();
        soundWaves = GameObject.FindObjectsOfType<SoundWaves>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton("Helmet")) {
			helmetOff = true;
			health.ReduceHealth ();
			Debug.Log("Helmet taken off");
		} else {
			helmetOff = false;
			health.RecoverHealth ();
		}

        ControlWaves();
	}

    void ControlWaves()
    {
        foreach (SoundWaves waves in soundWaves)
        {
            waves.GetComponent<Animator>().SetBool("HelmetOff", helmetOff);
        }

        /*if (helmetOff)
        {
            foreach (SoundWaves waveParent in soundWaves)
            {
                waveParent.GetComponent<Animator>().enabled = true;
            }
        }
        else
        {
            foreach (SoundWaves waveParent in soundWaves)
            {
                waveParent.GetComponent<Animator>().enabled = false;
            }
        }*/
    }
}

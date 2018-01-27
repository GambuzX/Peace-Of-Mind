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
        if (helmetOff)
        {
            foreach (SoundWaves wave in soundWaves)
            {
                wave.gameObject.SetActive(true);
            }
        }
        else
        {
            foreach (SoundWaves wave in soundWaves)
            {
                wave.gameObject.SetActive(false);
            }
        }
    }
}

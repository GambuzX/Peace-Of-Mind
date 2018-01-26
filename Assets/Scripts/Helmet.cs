using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helmet : MonoBehaviour {

	private bool helmetOff = false;
	private Health health;

	// Use this for initialization
	void Start () {
		health = GetComponent<Health> ();
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
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bell : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D col){
		if (col.transform.tag == "Player") {
			GetComponent<AudioSource> ().Play ();
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float velocity;
	public float jumpForce;

	private Rigidbody2D rigidBody;

	void Start() {
		rigidBody = this.GetComponent<Rigidbody2D> ();
	}

	void Update () {

		if (Input.GetButtonDown ("Up")) {
			rigidBody.AddForce (Vector2.up * jumpForce);
		}

		if (Input.GetButton ("Right")) {
			this.transform.Translate (Vector3.right * velocity);
		} else if (Input.GetButton ("Left")) {
			this.transform.Translate (Vector3.left * velocity);
		}
	}
}

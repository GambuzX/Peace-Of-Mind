using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float velocity;
	public float jumpForce;

	private Rigidbody2D rigidBody;
	private bool grounded = false;
	private CircleCollider2D feetCollider;
	private BoxCollider2D bodyCollider;

	void Start() {
		rigidBody = this.GetComponent<Rigidbody2D> ();
		feetCollider = this.GetComponent<CircleCollider2D> ();
		bodyCollider = this.GetComponent<BoxCollider2D> ();
	}

	void Update () {

		if (Input.GetButtonDown ("Up")) {
			rigidBody.AddForce (Vector2.up * jumpForce );
		}

		if (Input.GetButton ("Right")) {
			this.transform.Translate (Vector3.right * velocity* Time.deltaTime);
		} else if (Input.GetButton ("Left")) {
			this.transform.Translate (Vector3.left * velocity* Time.deltaTime);
		}
	}

	void OnCollisionStay2D(Collision2D col) {
		if (col.gameObject.tag == "Ground") {
			grounded = true;
			feetCollider.enabled = true;
			bodyCollider.enabled = true;
		}
	}

	void OnCollisionExit2D(Collision2D col) {
		if (col.gameObject.tag == "Ground") {
			grounded = false;
			feetCollider.enabled = false;
			bodyCollider.enabled = false;
		}
	}
}

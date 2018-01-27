using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour {

    public Camera gameCamera;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(gameCamera.transform.position.x, gameCamera.transform.position.y, gameCamera.transform.position.z + 10);
	}
}

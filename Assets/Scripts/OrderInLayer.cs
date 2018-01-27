using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrderInLayer : MonoBehaviour {

    private Helmet helmet;

	// Use this for initialization
	void Start () {
        helmet = GameObject.FindObjectOfType<Helmet>();
	}
	
	// Update is called once per frame
	void Update () {
		if (helmet.helmetOff)
        {
            GetComponent<SpriteRenderer>().sortingOrder = 3;
        } else
        {
            GetComponent<SpriteRenderer>().sortingOrder = 1;
        }
	}
}

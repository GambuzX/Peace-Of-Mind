using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        
	}


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.name == "Player")
        {
            Debug.LogWarning("Player in sight");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.name == "Player")
        {
            Debug.LogWarning("Player caught by trigger");
        }
    }
}

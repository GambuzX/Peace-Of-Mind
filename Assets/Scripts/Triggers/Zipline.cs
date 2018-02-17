using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zipline : MonoBehaviour {

    public Transform startPos, endPos;

    private GameObject player;
    private bool zip = false;

    // Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
        if (zip)
        {
            player.transform.position = Vector3.Lerp(startPos.position, endPos.position, 1f);
        }

        if (player.transform.position == endPos.position)
        {
            zip = false;
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            zip = true;
        }
    }
}

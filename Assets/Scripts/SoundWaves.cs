using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundWaves : MonoBehaviour {

    public float damageDistance;

    private Health health;
	
    // Use this for initialization
	void Start () {
        health = GameObject.FindObjectOfType<Health>();
	}
	
	// Update is called once per frame
	void Update () {
        float distanceToPlayer = Vector3.Magnitude(health.transform.position - this.transform.position);

        if (distanceToPlayer <= damageDistance)
        {
            health.ReduceHealth();
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Wave : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Sound_Wave")
        {
            Destroy(gameObject);
        }

    }
}

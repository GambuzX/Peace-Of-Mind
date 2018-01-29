using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportSecondScene : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Application.LoadLevel(2);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalAnimation : MonoBehaviour {

    public GameObject finalAnimation;
    public GameObject environment;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.gameObject.SetActive(false);
            finalAnimation.SetActive(true);
            environment.GetComponent<Animator>().enabled = true;
        }
    }
}

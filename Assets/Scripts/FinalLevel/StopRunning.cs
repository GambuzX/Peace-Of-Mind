using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopRunning : MonoBehaviour {

    public bool stopRunning = false;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {

        animator.SetBool("stopRunning", stopRunning);

        if (stopRunning)
        {
            animator.SetLayerWeight(1, 0f);
        }
    }
}

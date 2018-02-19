using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    public GameObject PauseScreen;

    private bool isPaused = false;
    private float initialFixedDeltaTime;
    private float lastPlayerHealth;

    private Health health;
    private CameraShake gameCamera;

    // Use this for initialization
    void Start () {
        initialFixedDeltaTime = Time.fixedDeltaTime;
        health = GameObject.FindObjectOfType<Health>();
        gameCamera = GameObject.FindObjectOfType<CameraShake>();
        lastPlayerHealth = health.playerHealth;
        PauseScreen.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Pause") && !isPaused)
        {
            isPaused = true;
            PauseScreen.SetActive(true);
            gameCamera.enabled = false;
            Time.timeScale = 0;
            Time.fixedDeltaTime = 0;

            lastPlayerHealth = health.playerHealth;
        }
        else if (Input.GetButtonDown("Pause") && isPaused)
        {
            isPaused = false;
            PauseScreen.SetActive(false);
            gameCamera.enabled = true;
            Time.timeScale = 1;
            Time.fixedDeltaTime = initialFixedDeltaTime;
        }

        if(isPaused)
        {
            health.playerHealth = lastPlayerHealth;
        }
    }
}

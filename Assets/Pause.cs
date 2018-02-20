using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

    //static Pause instance = null;

    public GameObject PauseScreen;

    private bool isPaused = false;
    private float initialFixedDeltaTime;
    private float lastPlayerHealth;

    private Health health;
    private CameraShake gameCamera;

    // Use this for initialization
    void Start () {
        /*if (instance != null) //Guarantees there is only one Pause System
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }*/

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
            AudioListener.volume = 0; //Sets global volume at 0
            Time.timeScale = 0;
            Time.fixedDeltaTime = 0;

            lastPlayerHealth = health.playerHealth;
        }
        else if (Input.GetButtonDown("Pause") && isPaused)
        {
            isPaused = false;
            PauseScreen.SetActive(false);
            gameCamera.enabled = true;
            AudioListener.volume = 1; //Sets normal global volume
            Time.timeScale = 1;
            Time.fixedDeltaTime = initialFixedDeltaTime;
        }

        if(isPaused)
        {
            health.playerHealth = lastPlayerHealth;
        }
    }
}

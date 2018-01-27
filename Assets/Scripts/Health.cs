using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public float playerHealth;

	public float cameraDistance = -10f; 
	public float cameraLift = 1.5f;
    public SpriteRenderer noiseRender;

    private Camera camera;
	private CameraShake cameraShake;
    private ViewClip viewClip;

	// Use this for initialization
	void Start () {
		camera = transform.GetComponentInChildren<Camera> ();
		cameraShake = camera.GetComponent<CameraShake> ();
        viewClip = transform.GetComponentInChildren<ViewClip>();
	}
	
	// Update is called once per frame
	void Update () {
		if (playerHealth > 500) { //Caps health at 100
			playerHealth = 500;
		}

		if (playerHealth <= 0) {
			//Dead
			Debug.LogWarning ("Player dead");
		}
	}

	/*private void UpdateCameraColor() {
		float redValue = Mathf.Log10((500 - playerHealth) / 500) + 0.2f;
		Color newColor = new Color (redValue - 0.5f, 0f, 0f);

		camera.backgroundColor = newColor;
	}*/

    private void UpdateNoiseRender()
    {
        Color temp = new Color(1f, 1f, 1f, 0f);
        temp.a = Mathf.Log10((500 - playerHealth) / 500)+  0.4f;
        noiseRender.color = temp;
    }

	private void CameraTwitch() {
		float twitchAmount = Mathf.Clamp ((500 - playerHealth) / 500, 0f, 1f);
		cameraShake.ChangeShakeAmount (twitchAmount);
		cameraShake.ChangeShakeDuration (1f);
	}

	public void ReduceHealth() {
		playerHealth -= 1f;
		//UpdateCameraColor ();
		CameraTwitch ();
        UpdateNoiseRender();
        viewClip.UpdateViewClip(playerHealth);
        
    }

	public void RecoverHealth() {
		playerHealth += 0.5f;
		//UpdateCameraColor ();
		CameraTwitch ();
        UpdateNoiseRender();
        viewClip.UpdateViewClip(playerHealth);
    }
}

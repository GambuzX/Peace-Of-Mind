using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewClip : MonoBehaviour {

    private Helmet helmet;
    private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
        helmet = GameObject.FindObjectOfType<Helmet>();
        spriteRenderer = GetComponent<SpriteRenderer>();
	}


    public void UpdateViewClip(float health)
    {
        Color temp = new Color(1f, 1f, 1f, 0f);
        temp.a = Mathf.Log(health, 500f);
        spriteRenderer.color = temp;
    }
}

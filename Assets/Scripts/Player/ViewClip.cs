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
		temp.a = health / 1000f + 0.2f;
        spriteRenderer.color = temp;
    }
}

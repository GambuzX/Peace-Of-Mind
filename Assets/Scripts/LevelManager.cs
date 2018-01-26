using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void LoadGame() {
		Application.LoadLevel ("Game");
	}

	public void ExitGame() {
		Application.Quit ();
	}
}

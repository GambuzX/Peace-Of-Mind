using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void LoadGame() {
		Application.LoadLevel ("Level01");
	}

	public void ExitGame() {
		Application.Quit ();
	}
}

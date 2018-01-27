using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void LoadGame() {
		Application.LoadLevel ("Level01");
	}

    public void loadLevel(string level)
    {
        Application.LoadLevel(level);
    }

	public void ExitGame() {
		Application.Quit ();
	}
}

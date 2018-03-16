using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuBtns : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Allows player to continue to game or to close the window
    public void PlayGame()
    {
        Application.LoadLevel(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }


// Update is called once per frame
void Update () {

    }
}
using UnityEngine;
using System.Collections;

public class menuGUI : MonoBehaviour {

	public AudioClip click;

	void OnGUI () {
		audio.clip = click;
		GUI.skin.button.fontSize = 48;
		int x = 280;
		int y = 50;
		if(GUI.Button(new Rect(Screen.width/2-(x/2), 	Screen.height/2-(y/2)-75, x, y), "New Game")) {
			audio.Play();
			Application.LoadLevel(1);
		}

		if(GUI.Button(new Rect(Screen.width/2-(x/2), 	Screen.height/2-(y/2)-25, x, y), "Load Game")) {
			audio.Play();
			//Application.LoadLevel(2);
		}

		if(GUI.Button(new Rect(Screen.width/2-(x/2), 	Screen.height/2-(y/2)+25, x, y), "Credits")) {
			audio.Play();
			//Application.LoadLevel(3);
		}

		if(GUI.Button(new Rect(Screen.width/2-(x/2), 	Screen.height/2-(y/2)+75, x, y), "Exit")) {
			audio.Play();
			Application.Quit();
		}
	}
}

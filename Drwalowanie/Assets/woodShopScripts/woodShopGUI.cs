using UnityEngine;
using System.Collections;

public class woodShopGUI : MonoBehaviour {

	public AudioClip click;

	//rozmiary zwyklych butonnów
	int x = 300;
	int y = 50;

	//rozmiary strzałek
	int xS = 100;
	int yS = 50;

	int iloscDrewnaDoSprzedania = 0;
	int iloscPosiadanegoDrewna = PlayerEquipment.Wood;



	void OnGUI () {
		audio.clip = click;
		GUI.skin.button.fontSize = 48;

		if(iloscDrewnaDoSprzedania >= iloscPosiadanegoDrewna){
			iloscDrewnaDoSprzedania = iloscPosiadanegoDrewna;
		}

		if(iloscDrewnaDoSprzedania <= 0){
			iloscDrewnaDoSprzedania = 0;
		}

		GUI.Label(new Rect(10, 10, 100, 20), iloscDrewnaDoSprzedania + "/" + iloscPosiadanegoDrewna);

		if(GUI.Button(new Rect(Screen.width/2-(x/2), 	Screen.height/2-(yS/2)-75, xS, yS), "<")) {
			audio.Play();
			iloscDrewnaDoSprzedania++;
		}
		
		if(GUI.Button(new Rect(Screen.width/2+(xS), 	Screen.height/2-(yS/2)-75, xS, yS), ">")) {
			audio.Play();
			iloscDrewnaDoSprzedania--;
		}

		if(GUI.Button(new Rect(Screen.width/2-(x/2), 	Screen.height/2-(y/2)+25, x, y), "max")) {
			audio.Play();
			iloscDrewnaDoSprzedania = iloscPosiadanegoDrewna;
		}

		if(GUI.Button(new Rect(Screen.width/2-(x/2), 	Screen.height/2-(y/2)+75, x, y), "confirm")) {
			audio.Play();
			zatwierdzZakup(iloscDrewnaDoSprzedania);
			Application.LoadLevel(1);
		}

		if(GUI.Button(new Rect(Screen.width/2-(x/2), 	Screen.height/2-(y/2)+125, x, y), "Return")) {
			audio.Play();
			Application.LoadLevel(1);
		}
	}

	private void zatwierdzZakup(int iloscSprzedanegoDrewna){
		PlayerEquipment.Wood -= iloscSprzedanegoDrewna;
		PlayerEquipment.Money += iloscSprzedanegoDrewna * Wood.woodPrice;
	}
}

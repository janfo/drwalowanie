using UnityEngine;
using System.Collections;

public class woodShopGUI : MonoBehaviour {

	public AudioClip click;
	public GUITexture texture;

	//rozmiary zwyklych butonnów
	int x = 300;
	int y = 50;

	//rozmiary strzałek
	int xS = 100;
	int yS = 50;

	int iloscDrewnaDoSprzedania = 0;
	int iloscPosiadanegoDrewna = PlayerEquipment.Wood;

	void Start(){
		texture.pixelInset = new Rect(-Screen.width, -Screen.height, Screen.width*2, Screen.height*2);
		audio.clip = click;
	}

	void OnGUI () {
		GUI.skin.button.fontSize = 48;
		GUI.skin.label.fontSize = 28;

		if(iloscDrewnaDoSprzedania >= iloscPosiadanegoDrewna){
			iloscDrewnaDoSprzedania = iloscPosiadanegoDrewna;
		}

		if(iloscDrewnaDoSprzedania <= 0){
			iloscDrewnaDoSprzedania = 0;
		}

		// Styl do nagłówka
		GUIStyle myStyle = new GUIStyle();
		myStyle.fontSize = 60;
		myStyle.normal.textColor = Color.white;

		//
		//	NAGŁÓWEK
		//
		GUI.Label(new Rect(Screen.width/2 - xS*1.5f,Screen.height/2-200, xS*4, yS*2),
		          "Wood Shop", myStyle);

		//
		//	PIERWSZY RZĄD
		//
		if(GUI.Button(new Rect(Screen.width/2-(x/2), Screen.height/2-(yS/2)-75, xS, yS), "<")) {
			audio.Play();
			iloscDrewnaDoSprzedania--;
		}

		GUI.Label(new Rect(Screen.width/2-35,Screen.height/2-(yS/2)-75, xS, yS),
		          iloscDrewnaDoSprzedania + "/" + iloscPosiadanegoDrewna);

		if(GUI.Button(new Rect(Screen.width/2+(xS/2), Screen.height/2-(yS/2)-75, xS, yS), ">")) {
			audio.Play();
			iloscDrewnaDoSprzedania++;
		}

		//
		//	DRUGI RZĄD
		//
		GUI.Label(new Rect(Screen.width/2-35,Screen.height/2-(yS/2)-25, xS, yS), (iloscDrewnaDoSprzedania * Wood.woodPrice).ToString());

		//
		//	POZOSTAŁE RZĘDY
		//		
		if(GUI.Button(new Rect(Screen.width/2-(x/2), Screen.height/2-(y/2)+25, x, y), "sell")) {
			audio.Play();
			zatwierdzZakup(iloscDrewnaDoSprzedania);
			Application.LoadLevel(1);
		}

		if(GUI.Button(new Rect(Screen.width/2-(x/2), Screen.height/2-(y/2)+75+10, x, y), "max")) {
			audio.Play();
			iloscDrewnaDoSprzedania = iloscPosiadanegoDrewna;
		}

		if(GUI.Button(new Rect(Screen.width/2-(x/2), Screen.height/2-(y/2)+125+20, x, y), "Return")) {
			audio.Play();
			Application.LoadLevel(1);
		}
	}

	private void zatwierdzZakup(int iloscSprzedanegoDrewna){
		PlayerEquipment.Wood -= iloscSprzedanegoDrewna;
		PlayerEquipment.Money += iloscSprzedanegoDrewna * Wood.woodPrice;
	}
}

using UnityEngine;
using System.Collections;

public class DrawEnter : MonoBehaviour {

	public Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		changeTextToEnterShop();
	}

	void changeTextToEnterShop(){
		if(SprzedazDrewna.accessWoodShopEnter){
			GetComponent<TextMesh>().text = "Q enter Shop";

			if(Input.GetKey("q")){

				//Zapisanie bieżacej pozycji
				TemporaryClass.isBooked = true; //Podanie parametru ze instnieja zapisana pozycja
				TemporaryClass.xPlayerPosition = player.position.x;
				TemporaryClass.yPlayerPosition = player.position.y;
				TemporaryClass.zPlayerPosition = player.position.z;

				//załadowanie sklepu
				Application.LoadLevel(2);
			}
		}else{
			GetComponent<TextMesh>().text = "";
		}
	}

}

using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	//zmienne publiczne do celów programistycznych
	public float hp = 0.0f;			//życie gracza
	public float stamina = 0.0f;	//zmęczenie gracza
	public float hungry = 0.0f;		//głod gracza
	public int money = 0;			//pieniadze gracza
	public int wood = 0;			//ilość drewna w inventory
	public int strenght = 0;		//siła gracza

	void Start () {
		hp = 100;
		stamina = 0;
		hungry = 0;
		money = 0;
		wood = 0;
		strenght = 10;
	}

	void FixedUpdate () {
		hungryFunction();
	}
	
	///
	///	PRIVATE METHODS
	///
	
	//metoda służy do obniżania pozoimu hp względem głodu
	private void hungryFunction(){
		if(hungry>75){
			//jeżeli obiekt głodny ujmuj mu życia
			hp = hp - Time.deltaTime * 0.3f;
		}
		//obiekt głodnieje
		hungry = hungry + Time.deltaTime * 0.3f;
	}

	private void staminaFunction(){

	}

	///
	/// PUBLIC METHODS 
	///

	//metoda ma na celu zwiększenie staminy gracza wtedy giety zostanie wykonane uderzenie siekierą
	public void setOneHitAxeSTAMINA(){

	}

	//metoda zwraca zakrąglony poziom życia
	public int getCircledHP(){
		return Mathf.RoundToInt(hp);
	}

	//metoda zwraca zakrąglony poziom głodu
	public int getCircledHungry(){
		return Mathf.RoundToInt(hungry);
	}

	//metoda zwraca money
	public int getMoney(){
		return money;
	}

	//metoda zwraca ilość posiadanego drewna
	public int getWood(){
		return wood;
	}

}

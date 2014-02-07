using UnityEngine;
using System.Collections;

public class treeCollision : MonoBehaviour {
	
	public Transform[] drzewka;					//na drzewa
	public Transform axe;						//na siekiere
	
	public static bool isTreeWithAxeCollision;	//zmienna określająca czy jest kolizja siekiery z drzewem
	public static int treeIndex;

	//zmienne odpowiedzialne za pozycję drzewa
	private float xTreePosition = 0.0f;
	private float zTreePosition = 0.0f;

	//zmienne odpowiedzialne za pozycję siekiery	
	private float xAxePosition = 0.0f;
	private float zAxePosition = 0.0f;

	//zmienna określająca dopuszczalną odległość siekiery od drzewa
	private int odlegloscOdKolizji = 15;	
	
	void Update () {
		collisionWithTree();
	}

	//metoda wylicza kolizję
	private void collisionWithTree(){
		for(int i = 0; i < drzewka.Length; i++){

			//pobranie pozycji drzewka X i Z
			xTreePosition = drzewka[i].position.x;
			zTreePosition = drzewka[i].position.z;
			
			//pobranie pozycji siekiery X i Y
			xAxePosition = axe.position.x;
			zAxePosition = axe.position.z;

			//warunek odległosiowy
			if(xAxePosition - xTreePosition < odlegloscOdKolizji &&
			   xAxePosition - xTreePosition > -odlegloscOdKolizji &&
			   zAxePosition - zTreePosition < odlegloscOdKolizji &&
			   zAxePosition - zTreePosition > -odlegloscOdKolizji)
			{
				treeIndex = i;
				isTreeWithAxeCollision = true;
			} else {
				isTreeWithAxeCollision = false;
			}
		}
	}
}

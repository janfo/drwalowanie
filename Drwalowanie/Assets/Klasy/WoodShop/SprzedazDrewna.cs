/*
 * Klasa ma za zadanie wyliczyć odległość miedzytartakiem, a graczem w celu
 * uzyskania dostępu wejścia do sklepu z drewnem
 */
using UnityEngine;
using System.Collections;

public class SprzedazDrewna : MonoBehaviour {

	public Transform player;
	public Transform tartak;

	public float xPlayer;
	public float yPlayer;
	public float zPlayer;

	public float xTartak;
	public float yTartak;
	public float zTartak;

	public static bool accessWoodShopEnter;

	// Use this for initialization
	void Start () {
		accessWoodShopEnter = false;
	}
	
	// Update is called once per frame
	void Update () {

		//pobranie wartości obydwóch obiektów
		xPlayer = player.position.x;
		yPlayer = player.position.y;
		zPlayer = player.position.z;

		xTartak = tartak.position.x;
		yTartak = tartak.position.y;
		zTartak = tartak.position.z;

		//warunek sprawdza czy zachodzi kolizja
		if(xPlayer - xTartak < 35 && xPlayer - xTartak > -38 &&
		   zPlayer - zTartak < 60 && zPlayer - zTartak > -50){
			accessWoodShopEnter = true;
		} else {
			accessWoodShopEnter = false;
		}
	}
}

using UnityEngine;
using System.Collections;

public class Tartak : MonoBehaviour {
	public Transform tartak;

	float x,y,z;

	void Start(){
		x = tartak.position.x;
		y = tartak.position.y;
		z = tartak.position.z;
	}

	public float getXTartakPosition(){
		return x;
	}

	public float getYTartakPosition(){
		return y;
	}

	public float getZTartakPosition(){
		return z;
	}
}

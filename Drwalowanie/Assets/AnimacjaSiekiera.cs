using UnityEngine;
using System.Collections;

public class AnimacjaSiekiera : MonoBehaviour {

	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
			GameObject.Find("axe").animation.Play("axeHit");
	}
}

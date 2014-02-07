using UnityEngine;
using System.Collections;

public class AnimacjaSiekiera : MonoBehaviour {

	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
		{
			Debug.Log("wywolanie");
			gameObject.particleSystem.Play();

		}
			//GameObject.Find("axe").animation.Play("axeHit");
	}
}

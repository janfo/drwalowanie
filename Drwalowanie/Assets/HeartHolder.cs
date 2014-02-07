using UnityEngine;
using System.Collections;

public class HeartHolder : MonoBehaviour {

	// Use this for initialization
	public GameObject[] Hearts;
	float[] left= new float[5];
	float[] top=new float[5];
	float[] width=new float[5];
	float[] height=new float[5];
	float betwenHearts=20;
	void SetPosition()
	{
		for(int i=0; i<Hearts.Length; i++)
		{
			Hearts[i].gameObject.guiTexture.pixelInset=new Rect(left[i],top[i], width[i], height[i]);
		}
	}
	void Start () {
	
	//	Hearts[0].transform.position.Set(200,200,0);
			//Screen.width-20;
		for(int i=0; i<Hearts.Length; i++)
		{
			Hearts[i].gameObject.transform.position = Vector3.zero;
			Hearts[i].gameObject.transform.localScale = Vector3.zero;

			betwenHearts+=40;
			left[i]=betwenHearts%Screen.width;
			top[i]=Screen.height-50;
			width[i]=32;
			height[i]=32;

		}
		//Ustaw pozycje serc

		SetPosition();
		//Hearts[0].gameObject.guiTexture.pixelInset=new Rect(20%Screen.width, Screen.height-50,32, 32);
	}
	
	// Update is called once per frame
	void Update () {

	}
}

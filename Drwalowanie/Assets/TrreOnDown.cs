using UnityEngine;
using System.Collections;

public class TrreOnDown : MonoBehaviour {

	// Use this for initializati
	float z;
	float ActualPosition=0;
	public GameObject[] tree;

	void TreeOnDown(int index)
	{

		if(ActualPosition>=-90)
		{
			z+=-1*Time.deltaTime;
			ActualPosition+=z;
			tree[index].transform.Rotate(0,0,z);
		}
			Debug.Log("Drzewo spada na dol");

	}

	void Start () {


	//GameObject.FindWithTag("BT").SetActive(false);


		//gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	//	if(TA.GetIsOnDown())
		TreeOnDown(0);
	
	}
}

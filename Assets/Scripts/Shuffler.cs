using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuffler : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Shuffle ();
	}

	public void Shuffle()
	{
		for (int i = 0; i < transform.childCount; i++)
		{
			int auxChild = Random.Range (i, transform.childCount - 1);
			Vector3 tempPos = transform.GetChild (i).position;
			transform.GetChild (i).position = transform.GetChild (auxChild).position;;
			transform.GetChild (auxChild).position = tempPos;
		}
	}
}

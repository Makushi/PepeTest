using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipCard : MonoBehaviour {

	private Rigidbody card;
	private bool showCard = false;
	private bool hideCard = false;
	private bool isShown = false;
	private bool isHidden = true;
	private string value;

	// Use this for initialization
	void Start () 
	{
		card = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (showCard)
		{
			if (card.transform.eulerAngles.z <= 180)
			{
				card.transform.Rotate (Vector3.forward * Time.deltaTime * 180f);	
			} else
			{
				card.transform.eulerAngles = new Vector3 (0, 0, 180);
				showCard = false;
				isShown = true;
				isHidden = false;
			}	
		}

		if (hideCard)
		{
			if (card.transform.eulerAngles.z >= 0 && card.transform.eulerAngles.z <= 358)
			{
				card.transform.Rotate (Vector3.back * Time.deltaTime * 180f);	
			} else
			{
				card.transform.eulerAngles = new Vector3 (0, 0, 0);
				hideCard = false;
				isShown = false;
				isHidden = true;
			}	
		}
	}

	public void Show()
	{
		showCard = true;
	}

	public void Hide ()
	{
		hideCard = true;
	}

	public bool IsShown()
	{
		return isShown;
	}

	public bool IsHidden()
	{
		return isHidden;
	}

	public string GetValue()
	{
		var child = transform.FindChild ("Face");

		if (child)
		{
			return child.GetComponent<MeshRenderer> ().material.name;
		}

		return "0";
	}
}

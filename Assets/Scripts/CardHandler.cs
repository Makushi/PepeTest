using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardHandler : MonoBehaviour {

	private GameObject card1;
	private GameObject card2;
	private bool rotate = true;
	private bool bothAssigned = false;
	public GameObject board;

	// Update is called once per frame
	void Update () 
	{
		if(!bothAssigned && Input.GetMouseButtonDown(0) )
		{
			Ray ray = Camera.main.ScreenPointToRay( Input.mousePosition );
			RaycastHit hit;

			if( Physics.Raycast( ray, out hit, 100 ) )
			{
				if (card1 == null)
				{
					card1 = hit.transform.gameObject;
					card1.GetComponent<FlipCard> ().Show();

				} else if (hit.transform.gameObject != card1)
				{
					card2 = hit.transform.gameObject;
					card2.GetComponent<FlipCard> ().Show();
					bothAssigned = true;
				}
			}
		}
	
		if (bothAssigned == true)
		{
			if(card1.GetComponent<FlipCard>().IsShown() && card2.GetComponent<FlipCard>().IsShown())
			{
				if (card1.GetComponent<FlipCard> ().GetValue () == card2.GetComponent<FlipCard> ().GetValue ())
				{
					DestroyCards ();
					card1 = null;
					card2 = null;
					bothAssigned = false;
				} else
				{
					card1.GetComponent<FlipCard> ().Hide ();
					card2.GetComponent<FlipCard> ().Hide ();
					card1 = null;
					card2 = null;
					bothAssigned = false;
				}
			}
		}
	}

	void DestroyCards()
	{
		Destroy (card1);
		Destroy (card2);
	}
}
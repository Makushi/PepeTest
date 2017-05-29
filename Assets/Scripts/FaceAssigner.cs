using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceAssigner : MonoBehaviour {
	public GameObject board;
	// Use this for initialization
	void Start () {
		AssingFaces ();
	}

	void AssingFaces()
	{
		var i = 0;
		for (int materialName = 1; materialName < 9; materialName++)
		{
			for (int j = 0; j < 2; j++)
			{
				var currentCard = board.transform.GetChild (i).FindChild("Face").GetComponent<MeshRenderer> ();
				LoadMaterial (materialName, currentCard);
				i++;
			}
		}
	}

	void LoadMaterial (int materialName, MeshRenderer currentCard)
	{
		Material m = Resources.Load<Material>("Materials/" + materialName) as Material;
		Material[] materials = currentCard.GetComponent<MeshRenderer>().materials;

		if (materials.Length > 0)
		{
			materials[0] = m;
			currentCard.GetComponent<MeshRenderer>().materials = materials;
		}
	}
}

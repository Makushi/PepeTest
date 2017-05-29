using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public Text timer;
	private float time = 60.0f;

	void Update()
	{
		time -= Time.deltaTime;
		timer.text = time.ToString ("0");

		if(time <= 0)
		{
			SceneManager.LoadScene("GameOver",LoadSceneMode.Single);
		}

		if (transform.childCount == 0)
		{
			SceneManager.LoadScene("GameOver",LoadSceneMode.Single);
		}
	}
}

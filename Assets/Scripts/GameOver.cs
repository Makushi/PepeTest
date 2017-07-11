using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public Text timer;
	private float timePerCard = 5.0f;
	private float time;

	void Start()
	{
		time = timePerCard * transform.childCount;
	}

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

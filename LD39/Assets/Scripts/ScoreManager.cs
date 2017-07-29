using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public static int score = 100;

	public static bool dead = false;

	public static Text scoreText;
	public Canvas deadCanvas;

	void Start () {
		scoreText = GetComponent<Text>();
		InvokeRepeating("TickingScore", 1, 1);
	}

	public static void AddScore (int input) {
		score += input;
		score = Mathf.Clamp(score, 0, 100);
		scoreText.text = score.ToString();
	}

	void Update () {
		dead = score < 1;
		deadCanvas.enabled = dead;
	}

	void TickingScore () {
		if (dead)
			return;
		AddScore(-1 * (int)SpeedManager.speedMultiplier);
	}

}

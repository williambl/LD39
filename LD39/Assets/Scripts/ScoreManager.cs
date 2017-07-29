using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	static int score = 100;

	public static Text scoreText;

	void Start () {
		scoreText = GetComponent<Text>();
		InvokeRepeating("TickingScore", 1, 1);
	}

	public static void AddScore (int input) {
		score += input;
		scoreText.text = score.ToString();
	}

	void TickingScore () {
		AddScore(-1 * (int)SpeedManager.speedMultiplier);
	}

}

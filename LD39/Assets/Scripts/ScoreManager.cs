using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	static int score = 0;

	public static Text scoreText;

	void Start () {
		scoreText = GetComponent<Text>();
	}

	public static void AddScore (int input) {
		score += input;
		scoreText.text = score.ToString();
	}

}

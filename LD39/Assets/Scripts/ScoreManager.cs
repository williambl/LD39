using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public static int score = 100;

	public static bool dead = false;

	public Image scoreImage;
	public Canvas deadCanvas;

	void Start () {
		InvokeRepeating("TickingScore", 1, 1);
	}

	public static void AddScore (int input) {
		score += input;
        score = Mathf.Clamp(score, 0, 100);
    }

	void Update () {
		dead = score < 1;
		deadCanvas.enabled = dead;
		scoreImage.fillAmount = (float)score/100;
	}

	void TickingScore () {
		if (dead)
			return;
		AddScore(-1 * (int)SpeedManager.speedMultiplier);
	}

}

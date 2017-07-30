using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public static int score = 100;

	public static bool dead = false;

	public Image scoreImage;
	public Canvas deadCanvas;
	Renderer rend;
	new Light light;

	void Start () {
		InvokeRepeating("TickingScore", 1, 1);
		rend = GetComponent<Renderer>();
		light = GetComponent<Light>();
	}

	public static void AddScore (int input) {
		score += input;
        score = Mathf.Clamp(score, 0, 100);
    }

	void Update () {
		dead = score < 1;
		deadCanvas.enabled = dead;

		scoreImage.fillAmount = (float)score/100;

		Color emissionColour = Color.HSVToRGB(0.13f, 0.817f, (float)score/100 * 1.5f, true);
		Debug.Log(emissionColour.ToString());
		rend.material.SetColor("_EmissionColor", emissionColour);

		light.intensity = ((float)score/100) * 3;
	}

	void TickingScore () {
		if (dead)
			return;
		AddScore(-1 * (int)SpeedManager.speedMultiplier);
	}

}

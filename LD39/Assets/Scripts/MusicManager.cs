using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

	AudioSource audiosrc;

	void Start () {
		audiosrc = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {
		audiosrc.pitch = (float)ScoreManager.score/100 * SpeedManager.speedMultiplier;
	}
}

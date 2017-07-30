using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

	public int score;
	public Material overpoweredMaterial;
	public AudioClip audioClip;

	void Start ()
	{
		if (Random.Range(0f, 1f) > 0.75 && score > 0) {
			GetComponent<Renderer>().material = overpoweredMaterial;
			GetComponent<Light>().color = Color.HSVToRGB(254, 100, 99);
			score = 5;
        }
	}

	void OnTriggerEnter (Collider other) {
		ScoreManager.AddScore(score);
		AudioSource otherAudio = other.GetComponent<AudioSource>();
		otherAudio.clip = audioClip;
		otherAudio.Play();
		Destroy(gameObject);
	}
}

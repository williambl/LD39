using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

	public int score;
	public Material overpoweredMaterial;

	void Start ()
	{
		if (Random.Range(0f, 1f) > 0.75 && score > 0) {
			GetComponent<Renderer>().material = overpoweredMaterial;
			score = 5;
        }
	}

	void OnTriggerEnter (Collider other) {
		ScoreManager.AddScore(score);
		Destroy(gameObject);
	}
}

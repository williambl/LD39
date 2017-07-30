using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DeathManager : MonoBehaviour {

	public bool dead = false;
	bool stopped = false;
	public Canvas canvas;
	public Text text;
	public Text spaceToRestart;
	public Transform player;
	public AudioSource audiosrc;

	// Update is called once per frame
	void Update () {
		if (stopped) {
			if (Input.GetButtonDown("Submit")) {
				audiosrc.Play();
				SceneManager.LoadScene(0);
			}
			return;
		}
		canvas.enabled = dead;
		if (dead) {
			StartCoroutine(ShowDeadText());
			stopped = true;
		}
	}

	IEnumerator ShowDeadText () {
		yield return new WaitForSeconds(1);
		text.enabled = true;
		audiosrc.Play();
		yield return new WaitForSeconds(1);
		audiosrc.Play();
		text.text = "YOUR SCORE WAS:\n" + (int)(player.position.z - 4);
		yield return new WaitForSeconds(1);
		audiosrc.Play();
		spaceToRestart.enabled = true;
	}
}

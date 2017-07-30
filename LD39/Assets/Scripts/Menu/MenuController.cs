using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	int status = 0;

	public GameObject instructions;
	public GameObject objects;

	void Update () {
		if (Input.GetButtonDown("Submit")) {
			status++;
		}

		switch (status) {
			case 0:
			instructions.SetActive(true);
			objects.SetActive(false);
			break;
			case 1:
			instructions.SetActive(false);
			objects.SetActive(true);
			break;
			case 2:
			SceneManager.LoadScene(1);
			break;
			default:
			SceneManager.LoadScene(1);
			break;
		}
	}
}

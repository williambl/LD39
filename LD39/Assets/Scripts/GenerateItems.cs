using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateItems : MonoBehaviour {

	public GameObject item;
	public GameObject player;

	void Start () {
		for (int i = 0; i < 20; i++) {
				Vector3 position = player.transform.position;
				position += new Vector3(0, 0.1f, Random.Range(5, 100));
				position.x = Random.Range(-5, 5);
				Instantiate(item, position, Quaternion.Euler(Vector3.zero));
		}
	}

	void Update () {

		if (Random.Range(0f, 1f) > 0.91f) {
			Vector3 position = player.transform.position;
			position += new Vector3(0, 0.1f, Random.Range(100, 200));
			position.x = Random.Range(-5, 5);
			Instantiate(item, position, Quaternion.Euler(Vector3.zero));
		}

	}
}

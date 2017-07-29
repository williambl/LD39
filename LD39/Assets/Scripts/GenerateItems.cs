using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateItems : MonoBehaviour {

	public GameObject[] items;
	public GameObject player;

	void Start () {
		for (int i = 0; i < Random.Range(20, 50); i++) {
				GameObject toSpawn = items[Random.Range(0, items.Length)];
				Vector3 position = player.transform.position;
				position += new Vector3(0, 0.1f, Random.Range(5, 200));
				position.x = Random.Range(-4, 4);
				Instantiate(toSpawn, position, Quaternion.Euler(Vector3.zero));
		}
	}

	void Update () {

		if (Random.Range(0f, 1f) > 0.8f) {
			GameObject toSpawn = items[Random.Range(0, items.Length)];
			Vector3 position = player.transform.position;
			position += new Vector3(0, 0.1f, Random.Range(100, 200));
			position.x = Random.Range(-4, 4);
			Instantiate(toSpawn, position, Quaternion.Euler(Vector3.zero));
		}

	}
}

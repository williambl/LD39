using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float moveSpeed = 10;
    public GameObject level;
    float levelSpawnPoint = 0;

    void FixedUpdate()
    {
		if (ScoreManager.dead)
            return;

		var x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed * SpeedManager.speedMultiplier;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed * SpeedManager.speedMultiplier;
        z = Mathf.Clamp(z, 0, Mathf.Infinity);
		x = Mathf.Clamp(x, -4-transform.position.x, 4-transform.position.x);
        transform.Translate(x, 0, z);

        if (transform.position.z > levelSpawnPoint - 75)
        {
            levelSpawnPoint += 100;
            Instantiate(level, new Vector3(0, 0, levelSpawnPoint + 50), Quaternion.Euler(Vector3.zero));
        }
	}
}

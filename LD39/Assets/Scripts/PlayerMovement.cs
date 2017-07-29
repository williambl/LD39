using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float rotateSpeed = 30;
    float moveSpeed = 10;
    public Transform level;

    void FixedUpdate()
	{
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed * SpeedManager.speedMultiplier;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed * SpeedManager.speedMultiplier;
        z = Mathf.Clamp(z, 0, Mathf.Infinity);
		x = Mathf.Clamp(x, -4-transform.position.x, 4-transform.position.x);
        transform.Translate(x, 0, z);
		level.Translate(0, 0, z);
	}
}

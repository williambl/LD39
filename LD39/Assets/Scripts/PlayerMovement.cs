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
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
		z = Mathf.Clamp(z, 0, Mathf.Infinity);
        transform.Translate(x, 0, z);
		level.Translate(0, 0, z);
	}
}

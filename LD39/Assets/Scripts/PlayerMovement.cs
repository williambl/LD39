using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    float rotateSpeed = 30;
    float moveSpeed = 10;

    void FixedUpdate()
	{
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * rotateSpeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
		transform.Translate (x, 0, z);
	}
}

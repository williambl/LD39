using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedManager : MonoBehaviour {

	public static float speedMultiplier = 1;

	void Start () {
		InvokeRepeating("TickingSpeed", 0.5f, 0.5f);
	}

	public static void AddSpeed (float input)
	{
		speedMultiplier += input;
	}

	void TickingSpeed ()
	{
		AddSpeed(0.1f);
	}

}

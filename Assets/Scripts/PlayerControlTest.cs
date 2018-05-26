using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlTest : MonoBehaviour {

	private void Update()
	{
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		this.transform.Translate(Vector3.forward * v * 3 * Time.deltaTime);
		this.transform.Rotate(Vector3.up * h * 120 * Time.deltaTime);
	}
}

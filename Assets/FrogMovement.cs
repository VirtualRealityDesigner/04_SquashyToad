using UnityEngine;
using System.Collections;

public class FrogMovement : MonoBehaviour {

	public Vector3 jumpVector;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space))
		{
			GetComponent<Rigidbody>().AddForce(jumpVector, ForceMode.VelocityChange);
		}
	}
}

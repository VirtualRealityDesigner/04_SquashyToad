using UnityEngine;
using System.Collections;

public class VehicleMovement : MonoBehaviour {

    float velocity = 1000;

	// Use this for initialization
	void Start () {
	
	}
	
	void FixedUpdate () {
        GetComponent<Rigidbody>().MovePosition(transform.position - transform.right * velocity * Time.deltaTime);
	}
}

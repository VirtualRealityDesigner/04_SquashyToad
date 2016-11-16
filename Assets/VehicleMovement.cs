using UnityEngine;
using System.Collections;

public class VehicleMovement : MonoBehaviour {

    public float velocity = 500;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, velocity * Time.deltaTime);
	}
}

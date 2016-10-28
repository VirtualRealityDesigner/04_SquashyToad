using UnityEngine;
using System.Collections;

public class FrogMovement : MonoBehaviour {

    public float jumpElevationInDegrees = 45;
    public float jumpSpeedInMPS = 5;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        var camera = GetComponentInChildren<Camera>();
        Debug.DrawRay(transform.position, camera.transform.forward, Color.blue);
        var projectedLookDirection = Vector3.ProjectOnPlane(camera.transform.forward, Vector3.up);
        Debug.DrawRay(transform.position, projectedLookDirection, Color.blue);
        var radiansToRotate = Mathf.Deg2Rad * jumpElevationInDegrees;
        var unnormalizedJumpDirection = Vector3.RotateTowards(projectedLookDirection, Vector3.up, radiansToRotate, 0);
        var jumpVector = unnormalizedJumpDirection.normalized * jumpSpeedInMPS;
        Debug.DrawRay(transform.position, jumpVector, Color.blue);
        if (Input.GetKeyDown(KeyCode.Space))
		{
			GetComponent<Rigidbody>().AddForce(jumpVector, ForceMode.VelocityChange);
		}
	}
}

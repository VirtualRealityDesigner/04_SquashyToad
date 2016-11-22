using UnityEngine;
using System.Collections;

public class FrogMovement : MonoBehaviour {

    public float jumpElevationInDegrees = 45;
    public float[] jumpSpeeds = { 200, 300, 400 };
    public float jumpGroundClearance = 2;
    public int jumpCount = 0;
    public int collisionCount = 0;

	// Use this for initialization
	void Start () {
	
	}

    void OnCollisionEnter ()
    {
        collisionCount++;
    }

    void OnCollisionExit ()
    {
        collisionCount--;
    }
	
	// Update is called once per frame
	void Update () {
        print(jumpCount);

        if (collisionCount > 0)
        {
            jumpCount = 0;
        }
        Debug.DrawRay(transform.position, -transform.up * jumpGroundClearance);
        if (GvrViewer.Instance.Triggered && jumpSpeeds.Length > jumpCount)
		{
            var camera = GetComponentInChildren<Camera>();
            var projectedLookDirection = Vector3.ProjectOnPlane(camera.transform.forward, Vector3.up);
            var radiansToRotate = Mathf.Deg2Rad * jumpElevationInDegrees;
            var unnormalizedJumpDirection = Vector3.RotateTowards(projectedLookDirection, Vector3.up, radiansToRotate, 0);
            var jumpVector = unnormalizedJumpDirection.normalized * jumpSpeeds[jumpCount];
            GetComponent<Rigidbody>().AddForce(jumpVector, ForceMode.VelocityChange);
            jumpCount++;
        }
    }
}

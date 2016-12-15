using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class LightSetter : MonoBehaviour {

    public float shadowBias = 0;

	// Use this for initialization
	void Update () {
        GetComponent<Light>().shadowBias = shadowBias;
	}
	
}

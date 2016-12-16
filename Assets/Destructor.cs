using UnityEngine;
using System.Collections;

public class Destructor : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}

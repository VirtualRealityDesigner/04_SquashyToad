using UnityEngine;
using System.Collections;

public class Lethal : MonoBehaviour {

    Death deathComponent; 

    void Start()
    {
        deathComponent = FindObjectOfType<Death>();
    }

	void OnCollisionEnter(Collision collision)
    {
        deathComponent.OnDeath();
    }
}

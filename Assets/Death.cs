using UnityEngine;
using System.Collections;

public class Death : MonoBehaviour {

    public GameObject UICanvas;

    public void OnDeath()
    {
        UICanvas.SetActive(true);
        GetComponent<Rigidbody>().isKinematic = true;

    }
}

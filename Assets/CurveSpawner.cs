using UnityEngine;
using System.Collections;

public class CurveSpawner : MonoBehaviour {

    public float rate = 4;
    public float minimumGap = 2;
    public GameObject prefab;
    float nextArrivalTime = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(nextArrivalTime < Time.time)
        {
            Spawn();
            var interval = NextArrivalInterval();
            print(interval);
            nextArrivalTime = Time.time + interval;
        }
	}

    void Spawn()
    {
        var instance = Instantiate(prefab, transform.position, transform.rotation, transform);
    }

    float NextArrivalInterval()
    {
        return -Mathf.Log(Random.value) * rate + minimumGap;
    }
}

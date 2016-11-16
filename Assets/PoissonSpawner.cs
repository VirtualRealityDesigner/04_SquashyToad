using UnityEngine;
using System.Collections;

public class PoissonSpawner : MonoBehaviour {

    public float rate = 4;
    public float minimumGap = 2;
    public float[] prefabProbabilities;
    public GameObject[] prefabs;
    float nextArrivalTime = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if(nextArrivalTime < Time.time)
        {
            var prefab = ChoosePrefab();
            Spawn(prefab);
            var interval = NextArrivalInterval();
            print(interval);
            nextArrivalTime = Time.time + interval;
        }
	}

    void Spawn(GameObject prefab)
    {
        var instance = Instantiate(prefab, transform.position, transform.rotation, transform);
    }

    GameObject ChoosePrefab()
    {
        float cumProb = 0;
        float p = Random.value;
        for (int i = 0; i < prefabProbabilities.Length; i++)
        {
            cumProb += prefabProbabilities[i];
            if (p <= cumProb)
            {
                return prefabs[i];
            }
        }
        return null;
    }

    float NextArrivalInterval()
    {
        return -Mathf.Log(Random.value) * rate + minimumGap;
    }
}

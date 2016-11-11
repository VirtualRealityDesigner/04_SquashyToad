using UnityEngine;
using System.Collections;

public class LaneSpawner : MonoBehaviour {

    public GameObject[] lanePrefabs;

	// Use this for initialization
	void Start () {
        int offset = 0;
        while (offset < 50000)
        {
            CreateRandomLane(offset);
            offset += 1000;
        }
    }

    void CreateRandomLane(float offset)
    {
        int laneIndex = Random.Range(0, lanePrefabs.Length);
        var lane = Instantiate(lanePrefabs[laneIndex]);
        lane.transform.parent = transform;
        lane.transform.Translate(0, 0, offset);
    }

    // Update is called once per frame
    void Update () {
	
	}
}

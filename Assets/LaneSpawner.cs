using UnityEngine;
using System.Collections;

enum LaneType { Safe, Danger };

public class LaneSpawner : MonoBehaviour {

    public GameObject[] safeLanePrefabs;
    public GameObject[] dangerousLanePrefabs;
    LaneType lastLaneType = LaneType.Safe;
    public float safeLaneRunProbability = 0.2f;
    public float laneSpawnDistance = 50000;

    // Use this for initialization
    void Start () {
        int offset = 0;
        while (offset < laneSpawnDistance)
        {
            CreateRandomLane(offset);
            offset += 1000;
        }
    }

    void CreateRandomLane(float offset)
    {
        GameObject lane;
        if (lastLaneType == LaneType.Safe)
        {
            if (Random.value < safeLaneRunProbability)
            {
                lastLaneType = LaneType.Safe;
                lane = InstantiateRandomLane(safeLanePrefabs);
            } else
            {
                lastLaneType = LaneType.Danger;
                lane = InstantiateRandomLane(dangerousLanePrefabs);
            }
        }
        else
        {
            lastLaneType = LaneType.Safe;
            lane = InstantiateRandomLane(safeLanePrefabs);
        }
        lane.transform.SetParent(transform, false);
        lane.transform.Translate(0, 0, offset);
    }

    GameObject InstantiateRandomLane(GameObject[] lanes)
    {
        int laneIndex = Random.Range(0, lanes.Length);
        return Instantiate(lanes[laneIndex]);
    }

    // Update is called once per frame
    void Update () {
	
	}
}

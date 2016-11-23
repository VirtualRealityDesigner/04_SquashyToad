using UnityEngine;
using System.Collections;

public class TreeSpawner : MonoBehaviour {

    public GameObject TreePrefab;
    public int minTrees = 5;
    public int maxTrees = 15;

	// Use this for initialization
	void Start () {
        int treeNumber = Random.Range(minTrees, maxTrees);
        for (int currentTree = 0; currentTree < treeNumber; currentTree++) {
            CreateTree();
        }
    }

    void CreateTree()
    {
        var tree = Instantiate(TreePrefab);
        tree.transform.parent = transform;
        tree.transform.localPosition = new Vector3(Random.Range(-5000, 5000), 0, Random.Range(-500, 500));
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

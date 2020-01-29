using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGenerator : MonoBehaviour
{
    public GameObject       treePrefabVar;
    public List<GameObject> gameObjectList;
    public float            scalingFartor = 0.95f;
    public int              maxTrees = 50;
    public int              distribution = 50;

    // Start is called before the first frame update
    void Start()
    {
        gameObjectList = new List<GameObject>();
        for (int i = 0; i <= maxTrees; i++)
        {
            GameObject newTree = Instantiate(treePrefabVar) as GameObject;
            gameObjectList.Add(newTree);
            newTree.transform.position = new Vector3(Random.value * distribution, 0, Random.value * distribution);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

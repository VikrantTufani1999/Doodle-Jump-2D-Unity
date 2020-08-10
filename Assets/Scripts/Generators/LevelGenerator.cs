using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject platformPrefab;           // Prefab which needs to be spawned
    Transform parent;

    // Declarations
    public int numberOfPlatforms = 100;
    public float levelWidth = 3f;
    public float minY = 1f;
    public float maxY = 5f;

    void Start()
    {
        parent = GetComponent<Transform>();
        Vector3 spawnPosition = new Vector3();      // To store instantiated object position

        for (int i = 0; i<numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);    // Randomize Y positions before instantiation
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);    // Randomize X positions before instantiation
            var instance = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);    // instantiation
            instance.transform.SetParent(parent);
        }
    }


}

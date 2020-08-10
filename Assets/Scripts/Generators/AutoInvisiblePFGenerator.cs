using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoInvisiblePFGenerator : MonoBehaviour
{
    // Declarations
    public GameObject autoInvisiblePrefab;           // Prefab which needs to be instantiated
    Transform parent;

    public int numberOfPlatforms5 = 5;
    public float levelWidth5 = 3f;
    public float minY5 = 3f;
    public float maxY5 = 5f;

    void Start()
    {
        parent = GetComponent<Transform>();
        Vector3 spawnPosition5 = new Vector3();                  // Vector to store position of instantiated object

        for (int i = 0; i < numberOfPlatforms5; i++)
        {
            spawnPosition5.y += Random.Range(minY5, maxY5);                  // Randomize Y position of instantiation
            spawnPosition5.x = Random.Range(-levelWidth5, levelWidth5);      // Randomize X position of instantiation
            var instance5 = Instantiate(autoInvisiblePrefab, spawnPosition5, Quaternion.identity);     // Instantiation
            instance5.transform.SetParent(parent);
        }
    }
}

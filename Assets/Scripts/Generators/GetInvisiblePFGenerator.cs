﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInvisiblePFGenerator : MonoBehaviour
{
    public GameObject getInvisiblePrefab;           // Prefab which needs to be instantiated
    Transform parent;

    // Declarations
    public int numberOfPlatforms4 = 5;
    public float levelWidth4 = 3f;
    public float minY4 = 3f;
    public float maxY4 = 5f;

    void Start()
    {
        parent = GetComponent<Transform>();
        Vector3 spawnPosition = new Vector3();                  // Vector to store position of instantiated object

        for (int i = 0; i < numberOfPlatforms4; i++)
        {
            spawnPosition.y += Random.Range(minY4, maxY4);                  // Randomize Y position of instantiation
            spawnPosition.x = Random.Range(-levelWidth4, levelWidth4);      // Randomize X position of instantiation
            var instance = Instantiate(getInvisiblePrefab, spawnPosition, Quaternion.identity);     // Instantiation
            instance.transform.SetParent(parent);
        }
    }

}

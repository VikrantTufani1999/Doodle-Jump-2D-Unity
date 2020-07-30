using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrackGenerator : MonoBehaviour
{
    public GameObject breakingPrefab;           // Prefab which needs to be instantiated

    // Declarations
    public int countOfPlatforms = 10;
    public float width = 3f;
    public float minY1 = 10f;
    public float maxY1 = 15f;

    private void Start()
    {
        Vector3 spawnCracked = new Vector3();       // Vector to store position of instantiated object

        for (int i=0; i < countOfPlatforms; i++)
        {
            spawnCracked.y += Random.Range(minY1, maxY1);   // Randomize Y position of instantiation
            spawnCracked.x = Random.Range(-width, width);   // Randomize X position of instantiation
            Instantiate(breakingPrefab, spawnCracked, Quaternion.identity);     // Instantiation
        }
    }


}

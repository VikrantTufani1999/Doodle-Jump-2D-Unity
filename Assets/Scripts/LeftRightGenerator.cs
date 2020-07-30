using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightGenerator : MonoBehaviour
{
    public GameObject LeftRightPrefab;          // Prefab which needs to be instantiated

    //Declarations
    public int countOfPlatforms2 = 10;         
    public float width2 = 3f;
    public float minY3 = 10f;
    public float maxY3 = 15f;

    private void Start()
    {
        Vector3 spawnLeftRight = new Vector3();             // Vector to store position of instantiated object

        for (int i = 0; i < countOfPlatforms2; i++)
        {

            spawnLeftRight.y += Random.Range(minY3, maxY3);         // Randomize Y position of instantiation
            spawnLeftRight.x = Random.Range(-width2, width2);       // Randomize X position of instantiation
            var instance = Instantiate(LeftRightPrefab, spawnLeftRight, Quaternion.identity);   // Instantiation
            // Debug.Log(instance.transform.position.y);        // Just to check y positions of the instantiated objects.

        }
    }
    }

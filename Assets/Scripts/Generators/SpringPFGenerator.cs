using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringPFGenerator : MonoBehaviour
{
    public GameObject springPrefab;          // Prefab which needs to be instantiated
    Transform parent;

    //Declarations
    public int countOfPlatforms6 = 10;
    public float width6 = 3f;
    public float minY6 = 10f;
    public float maxY6 = 15f;

    private void Start()
    {
        parent = GetComponent<Transform>();
        Vector3 spawnLeftRight = new Vector3();             // Vector to store position of instantiated object

        for (int i = 0; i < countOfPlatforms6; i++)
        {

            spawnLeftRight.y += Random.Range(minY6, maxY6);         // Randomize Y position of instantiation
            spawnLeftRight.x = Random.Range(-width6, width6);       // Randomize X position of instantiation
            var instance = Instantiate(springPrefab, spawnLeftRight, Quaternion.identity);   // Instantiation
            instance.transform.SetParent(parent);
            // Debug.Log(instance.transform.position.y);        // Just to check y positions of the instantiated objects.

        }

    }
}

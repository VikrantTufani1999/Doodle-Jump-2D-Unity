using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownGenerator : MonoBehaviour
{
    public GameObject UpDownPrefab;                 // Prefab which needs to be spawned

    //Declarations
    public int countOfPlatforms1 = 10;
    public float width1 = 3f;
    public float minY2 = 10f;
    public float maxY2 = 15f;
    public bool isUp;

    private void Start()
    {
        Vector3 spawnUpDown = new Vector3();                // To store instantiated object position

        for (int i = 0; i < countOfPlatforms1; i++)
        {
            
            spawnUpDown.y += Random.Range(minY2, maxY2);        // Randomize Y positions before instantiation
            spawnUpDown.x = Random.Range(-width1, width1);      // Randomize X Positions before instantiation
            var instance = Instantiate(UpDownPrefab, spawnUpDown , Quaternion.identity);      // Instantiation
            //Debug.Log(instance.transform.position.y);       // Just to check y positions of instantiated objects

        }
    }

    



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRightPool : MonoBehaviour
{
    [SerializeField] GameObject poolObj;
    [SerializeField] int poolAmount;

    List<GameObject> pooledObjects;

    [SerializeField] float minmY;
    [SerializeField] float maxmY;
    [SerializeField] float width;



    private void Start()
    {
        pooledObjects = new List<GameObject>();
        Vector3 spawnpos2 = new Vector3 (0, 25, 0);
        for (int i = 0; i < poolAmount; i++)
        {
            spawnpos2.y += Random.Range(minmY, maxmY);
            spawnpos2.x = Random.Range(-width, width);
            GameObject obj = (GameObject)Instantiate(poolObj, spawnpos2, Quaternion.identity);
            //Debug.Log("Spawn Pos: " + spawnpos2);
            obj.transform.SetParent(this.transform);
            //obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    public GameObject GetPooledObj()
    {
        for (int i = 0; i < pooledObjects.Count; i++)
        {
            if (!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }

        GameObject obj = (GameObject)Instantiate(poolObj);
        obj.SetActive(false);
        pooledObjects.Add(obj);

        return obj;
    }
}

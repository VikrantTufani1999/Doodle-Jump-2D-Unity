using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetInvisiblePool : MonoBehaviour
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
        Vector3 spawnpos4 = new Vector3(0, 35, 0);
        for (int i = 0; i < poolAmount; i++)
        {
            spawnpos4.y += Random.Range(minmY, maxmY);
            spawnpos4.x = Random.Range(-width, width);
            GameObject obj = (GameObject)Instantiate(poolObj, spawnpos4, Quaternion.identity);
            //Debug.Log("Spawn Pos: " + spawnpos4);
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

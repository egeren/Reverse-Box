using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] prefabs;

    // -2.65, 2.106089, 129.2
    public float spawnTime = 2f;
    float time = 2f;
    Vector3 spawnLocation;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = time - Time.deltaTime;
        if(time < 0)
        {
            time = spawnTime;
            spawnLocation = new Vector3(Random.Range(-2.65f, 3f), 2.106089f, 129.2f);
            Instantiate(prefabs[0], spawnLocation, Quaternion.identity);
        }
    }
}

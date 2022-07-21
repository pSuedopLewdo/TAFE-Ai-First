using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnBalls : MonoBehaviour
{
    
    public GameObject ballPrefab;
    public Vector3 spawnLocation;
    
    [Space(8)]
    public Transform ballHolder;
    
    private float spawnTimer = 0.2f;
    private float lastSpawnTime = float.MinValue;

    private void Start()
    {
        spawnTimer = 0.2f;
    }

    void Update()
    {
        //checks if Q is pressed
        if (Input.GetKey(KeyCode.Q) == true && Time.time > lastSpawnTime + spawnTimer)
        {
            float randomX = Random.Range(-0.5f, 0.5f);
            spawnLocation.x = spawnLocation.x + randomX;
            float randomZ = Random.Range(-0.5f, 0.5f);
            spawnLocation.z = spawnLocation.z + randomZ;
            
            GameObject tmpBall = Instantiate(ballPrefab.gameObject, spawnLocation, Quaternion.identity);
            tmpBall.transform.SetParent(ballHolder);
            lastSpawnTime = Time.time;
        }
    }
}

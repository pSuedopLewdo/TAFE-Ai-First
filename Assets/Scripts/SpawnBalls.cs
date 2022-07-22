using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnBalls : MonoBehaviour
{
    
    public GameObject ballPrefab;
    public GameObject mouseBallPrefab;
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
        //checks mouse position and sets it to mousePosition
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        //checks if Q is pressed spawns ball on mouse position
        if (Input.GetKey(KeyCode.Q) == true && Time.time > lastSpawnTime + spawnTimer)
        {
            GameObject tmpBall = Instantiate(mouseBallPrefab.gameObject, mousePosition, Quaternion.identity);
            tmpBall.transform.SetParent(ballHolder);
            lastSpawnTime = Time.time;
        }
    
        //checks if e is being presse dand spawns ball randomly
        if (Input.GetKey(KeyCode.E) == true && Time.time > lastSpawnTime + spawnTimer)
        {
            float randomX = Random.Range(-2, 2f);
            spawnLocation.x = spawnLocation.x + randomX;
            float randomZ = Random.Range(-2f, 2f);
            spawnLocation.z = spawnLocation.z + randomZ;
            
            GameObject tmpBall = Instantiate(ballPrefab.gameObject, spawnLocation, Quaternion.identity);
            tmpBall.transform.SetParent(ballHolder);
            lastSpawnTime = Time.time;
        }
    }
}

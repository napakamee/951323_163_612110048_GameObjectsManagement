﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameObjectsSpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    GameObject _itemToBeSpawn;

    [SerializeField]
    GameObject[] _obstaclesToBeSpawn;
    void Start()
    {
        Invoke("SpawnItem", 2.0f);
        Invoke("SpawnObstacle", 2.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnItem(){
        GameObject go = Instantiate(_itemToBeSpawn ,
            new Vector3(Random.Range(-4.5f, 4.5f), 5, 0),
            Quaternion.identity);
        Destroy(go, 5);

        float nextSpawnTime = Random.Range(0.2f, 1);
        Invoke("SpawnItem", nextSpawnTime);
    }

    void SpawnObstacle(){
        int obsIdx = Random.Range(0, _obstaclesToBeSpawn.Length);
        GameObject go = Instantiate(_obstaclesToBeSpawn[obsIdx],
            new Vector3(Random.Range(-4.5f, 4.5f), 5, 0), Quaternion.identity);
        Destroy(go, 5);

        float nextSpawnTime = Random.Range(0.2f, 1);
        Invoke("SpawnObstacle", nextSpawnTime);
    }
}
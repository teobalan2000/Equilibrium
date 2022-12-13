using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] objects;                // The prefab to be spawned.
    public float spawnTime = 6f;            // How long between each spawn.
    private Vector2 spawnPosition;
    public bool SpawnOn_Off = true;

    // Use this for initialization
    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        if (SpawnOn_Off)
        {
            InvokeRepeating("Spawn", spawnTime, spawnTime);
        }

    }

    void Spawn()
    {

        spawnPosition.x = Random.Range(-17, 17);
        spawnPosition.y = 0.5f;

        Instantiate(objects[Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);
    }
}

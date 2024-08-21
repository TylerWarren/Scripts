using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
public GameObject[] ufoPrefabs; // Array to store Pickup itam
    private float spawnRangeX = 20f;
    private float spawnPosZ = 20f;

    private float startDelay = 5f;
    private float spawnInterval = 2.5f;

    void Start()
    {
        InvokeRepeating("SpawnPickup", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnPickup()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);
        int ufoIndex = Random.Range(0,ufoPrefabs.Length); // Picks the pickup from the array
        Instantiate(ufoPrefabs[ufoIndex],spawnPos, ufoPrefabs[ufoIndex].transform.rotation); // Spawns the pickup itam the array a random location on the X-Axis
    }
}

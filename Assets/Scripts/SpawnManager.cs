using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] carPrefabs;
    private float spawnRangeX = 15;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 2.5f;
    private float spawnLastX;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomCar", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomCar()
    {
        float spawnX = Random.Range(-spawnRangeX, spawnRangeX);
        if (Mathf.Abs(spawnX - spawnLastX) > 3.64f) 
        {
            Vector3 spawnPos = new Vector3(spawnX, 0, spawnPosZ);
            int carIndex = Random.Range(0, carPrefabs.Length);
            Instantiate(carPrefabs[carIndex], spawnPos,
            carPrefabs[carIndex].transform.rotation);
            spawnLastX = spawnX;
        }
    }
}

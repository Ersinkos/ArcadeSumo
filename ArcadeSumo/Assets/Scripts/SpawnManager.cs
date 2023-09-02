using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnPosX;
    private float spawnPosZ;
    private float spawnRangeX = 7.0f;
    private float spawnRangeZ = 9.0f;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
    }


    // Update is called once per frame
    void Update()
    {

    }
    private Vector3 GenerateSpawnPosition()
    {
        spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
        spawnPosZ = Random.Range(-spawnRangeZ, spawnRangeZ);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }
}

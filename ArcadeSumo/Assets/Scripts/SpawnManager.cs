using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] powerupPrefab;
    public GameObject[] enemyPrefab;
    private int powerupIndex;
    private int enemyIndex;
    private float spawnPosX;
    private float spawnPosZ;
    private float spawnRangeX = 7.0f;
    private float spawnRangeZ = 9.0f;
    public int enemyCount;
    public int waveNumber = 1;
    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumber);
        powerupIndex = Random.Range(0, powerupPrefab.Length);
        Instantiate(powerupPrefab[powerupIndex], GenerateSpawnPosition(), powerupPrefab[powerupIndex].transform.rotation);
    }


    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            powerupIndex = Random.Range(0, powerupPrefab.Length);
            Instantiate(powerupPrefab[powerupIndex], GenerateSpawnPosition(), powerupPrefab[powerupIndex].transform.rotation);
        }
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            enemyIndex = Random.Range(0, enemyPrefab.Length);
            Instantiate(enemyPrefab[enemyIndex], GenerateSpawnPosition(), enemyPrefab[enemyIndex].transform.rotation);
        }
    }
    private Vector3 GenerateSpawnPosition()
    {
        spawnPosX = Random.Range(-spawnRangeX, spawnRangeX);
        spawnPosZ = Random.Range(-spawnRangeZ, spawnRangeZ);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;
    }
}

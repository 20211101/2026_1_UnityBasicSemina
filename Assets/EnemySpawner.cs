using System;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform enemySpawnPoint;
    public GameObject enemyPrefab;

    float spawnTime = 3f;
    float curTime = 0f; // currentTime

    void Update()
    {
        curTime += Time.deltaTime;

        if(curTime > spawnTime)
        {
            curTime = 0f;
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        Instantiate(enemyPrefab, enemySpawnPoint.position, enemySpawnPoint.rotation);
    }
}

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpawnerEnemigos : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] spawnPoints;
    public int maxEnemies = 10;
    public int maxSimultaneousEnemies = 4;

    private int currentEnemies = 0;
    private bool[] occupiedSpawnPoints;

    private void Start()
    {
        occupiedSpawnPoints = new bool[spawnPoints.Length];
    }

    private void Update()
    {
        if (currentEnemies < maxEnemies)
        {
            int availableSpawnPoints = 0;
            for (int i = 0; i < spawnPoints.Length; i++)
            {
                if (!occupiedSpawnPoints[i])
                {
                    availableSpawnPoints++;
                }
            }

            if (availableSpawnPoints > 0 && currentEnemies < maxSimultaneousEnemies)
            {
                int spawnIndex = Random.Range(0, spawnPoints.Length);
                if (!occupiedSpawnPoints[spawnIndex])
                {
                    Instantiate(enemyPrefab, spawnPoints[spawnIndex].position, Quaternion.identity);
                    occupiedSpawnPoints[spawnIndex] = true;
                    currentEnemies++;
                }
            }
        }
    }

    private void OnEnemyDestroyed()
    {
        currentEnemies--;
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (occupiedSpawnPoints[i])
            {
                occupiedSpawnPoints[i] = false;
                break;
            }
        }
    }
}

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpawnerEnemigos : MonoBehaviour
{
    public GameObject[] enemyPrefab;
    public Transform[] spawnPoints;
    public int maxEnemies = 10;
    public int maxSimultaneousEnemies = 4;
    GameObject pantallaVictoria;
    private int currentEnemies = 0;
    private bool[] occupiedSpawnPoints;
    public int contador = 0;
    private void Start()
    {
        occupiedSpawnPoints = new bool[spawnPoints.Length];
        pantallaVictoria = GameObject.Find("PANTALLA Completado");
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
                    Instantiate(enemyPrefab[Random.Range(0, enemyPrefab.Length)], spawnPoints[spawnIndex].position, Quaternion.identity);
                    occupiedSpawnPoints[spawnIndex] = true;
                    currentEnemies++;
                }
            }
        }
        if (contador >= 18)
        {
            pantallaVictoria.SetActive(true);
        }
        else
        {

            pantallaVictoria.SetActive(false);
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

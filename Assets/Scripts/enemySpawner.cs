using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawner : MonoBehaviour
{

    [Header("Enemy Settings")]
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private float spawnRate = 2f;
    [SerializeField] private Transform[] spawnPoints;
    [SerializeField] private int maxEnemies = 5;
    
    private int currentEnemies = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void SpawnEnemy()
    {
        if(currentEnemies >= maxEnemies) return;
        Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
        GameObject spawnEnemy = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);

        enemyControler enemyController = spawnedEnemy.GetComponent<enemyControler>();
        enemyControler.Instantiate(this);

        currentEnemies++;
    }
}

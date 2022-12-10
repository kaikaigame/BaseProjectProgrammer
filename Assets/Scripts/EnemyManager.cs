using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public Transform[] spawnPoints;

    public float interval = 3.0f;
    private float _time;

    private void Update()
    {
        _time += Time.deltaTime;

        if (!(_time > interval)) return;

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

        GameObject enemy = Instantiate(enemyPrefab, spawnPoints[spawnPointIndex].position,
            spawnPoints[spawnPointIndex].rotation);
        _time = 0f;
    }
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Enemy enemy;
    public List<Transform> spawnPoints;
    public float spawnTimeFraquency;

    public void Spawn()
    {
        Instantiate(enemy, spawnPoints[Random.Range(0, spawnPoints.Count)].position, enemy.transform.rotation);
    }
    private void Start()
    {
        InvokeRepeating("Spawn", 0f, spawnTimeFraquency);
    }

}

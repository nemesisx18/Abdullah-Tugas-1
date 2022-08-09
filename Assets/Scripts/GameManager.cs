using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int point;
    public int health;
    public int waveCount = 1;
    public int destroyQty;

    public bool isLose;
    public SpawnController spawn;

    void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        if(health == 0)
        {
            isLose = true;
            Time.timeScale = 0;
        }

        if(destroyQty == spawn.maxSpawn)
        {
            waveCount++;
            destroyQty = 0;
            spawn.zombieSpawned = 0;
            spawn.maxSpawn += 2;

            if (waveCount % 5 == 0 && spawn.spawnChance > 0.3)
            {
                spawn.spawnChance = spawn.spawnChance - 0.1f;
            }
        }
    }
}

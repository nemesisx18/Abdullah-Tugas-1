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

    public static GameManager instance;
    
    SpawnController spawn;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        Time.timeScale = 1;
        spawn = GetComponent<SpawnController>();
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
            if (waveCount % 5 == 0 && spawn.spawnChance > 0.3)
            {
                spawn.spawnChance = spawn.spawnChance - 0.1f;
            }
            destroyQty = 0;
            spawn.maxSpawn += 2;
            spawn.zombieSpawned = 0;
        }
    }
}

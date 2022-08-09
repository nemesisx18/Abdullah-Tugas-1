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
            Debug.Log("you lose");
            isLose = true;
            Time.timeScale = 0;
        }

        if(destroyQty == spawn.maxSpawn)
        {
            waveCount++;
            destroyQty = 0;
            spawn.zombieSpawned = 0;
            spawn.maxSpawn += 2;
        }
    }
}

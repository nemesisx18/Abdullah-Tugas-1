using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public Transform[] spawnPos;
    public GameObject human, zombie;
    private GameObject randomObj;

    public int maxSpawn;
    public int zombieSpawned;
    [Range(0,1)] public float spawnChance;
    public float timeSpawn;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if(timer > timeSpawn)
        {
            SpawnZombie();
            timer = 0;
        }
    }

    public void SpawnZombie()
    {
        if (Random.value > spawnChance)
        {
            randomObj = human;
        }
        else
        {
            randomObj = zombie;
        }

        if (zombieSpawned < maxSpawn)
        {
            float yPos = Random.Range(-1.2f, 1.2f);
            GameObject go = Instantiate(randomObj,
                new Vector2(yPos, spawnPos[Random.Range(0, spawnPos.Length)].position.y), Quaternion.identity);

            go.SetActive(true);

            zombieSpawned++;
        }
    }
}

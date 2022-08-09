using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public Transform[] spawnPos;
    public GameObject[] objectSpawn;

    public int maxSpawn;
    public int zombieSpawned;
    public float timeSpawn;

    private float timer;
    
    // Update is called once per frame
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
        if (zombieSpawned < maxSpawn)
        {
            float yPos = Random.Range(-1.2f, 1.2f);
            GameObject go = Instantiate(objectSpawn[Random.Range(0, objectSpawn.Length)], new Vector2(yPos , spawnPos[Random.Range(0,spawnPos.Length)].position.y ), Quaternion.identity);
            go.SetActive(true);

            zombieSpawned++;
        }
    }
}

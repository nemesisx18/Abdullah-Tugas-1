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
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
            Instantiate(objectSpawn[Random.Range(0, objectSpawn.Length)], spawnPos[Random.Range(0, spawnPos.Length)].position, Quaternion.identity);
            zombieSpawned++;
        }
    }
}

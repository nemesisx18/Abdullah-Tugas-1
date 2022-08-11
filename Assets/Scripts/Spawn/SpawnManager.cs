using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spawn
{
    public class SpawnManager : MonoBehaviour
    {
        public Transform spawnPos;
        public Transform spawnParent;
        public GameObject human, zombie;
        private GameObject randomObj;
        private List<GameObject> spawnObject;

        private int maxSpawn = 8;
        private int zombieSpawned;
        private float timeSpawn = 1;
        private float timer;
        private float spawnChance = 0.9f;

        private void Start()
        {
            SpawnZombie();
        }

        void Update()
        {
            timer += Time.deltaTime;

            if (timer > timeSpawn)
            {
                DespawnZombie();
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

            spawnObject = new List<GameObject>();

            for (int i = 0; i < maxSpawn; i++)
            {
                GameObject go = Instantiate(randomObj, spawnPos.position, Quaternion.identity, spawnParent);
                go.SetActive(false);
                spawnObject.Add(go);
            }
        }

        public void DespawnZombie()
        {
            float xPos = Random.Range(-1.2f, 1.2f);

            GameObject respawn = GetPooledObject();
            if(respawn != null)
            {
                respawn.transform.position = new Vector2(xPos, spawnPos.position.y);
                respawn.SetActive(true);
            }
        }

        public GameObject GetPooledObject()
        {
            for (int i =0; i < spawnObject.Count; i++)
            {
                if(!spawnObject[i].activeInHierarchy)
                {
                    return spawnObject[i];
                }
            }
            return null;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Spawn
{
    public class SpawnManager : MonoBehaviour
    {
        [SerializeField] private List<GameObject> spawnObject;

        public Transform spawnPos;
        public Transform spawnParent;
        public GameObject human, zombie;
        private GameObject randomObj;

        private int maxSpawn = 8;
        private int zombieSpawned;
        public float timeSpawn;
        [Range(0, 1)] private float spawnChance = 0.9f;

        private float timer;

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
                float yPos = Random.Range(-1.2f, 1.2f);

                GameObject go = Instantiate(randomObj, new Vector2(yPos, spawnPos.position.y), Quaternion.identity, spawnParent);
                go.SetActive(false);
                spawnObject.Add(go);
            }

            //if (zombieSpawned < maxSpawn)
            //{
            //    float yPos = Random.Range(-1.2f, 1.2f);
            //    GameObject go = Instantiate(randomObj,
            //        new Vector2(yPos, spawnPos[Random.Range(0, spawnPos.Length)].position.y), Quaternion.identity, spawnParent);

            //    go.SetActive(true);

            //    zombieSpawned++;


            //}
        }

        public void DespawnZombie()
        {
            GameObject respawn = GetPooledObject();
            if(respawn != null)
            {
                while(zombieSpawned < maxSpawn)
                {
                    respawn.transform.position = spawnPos.position;
                    respawn.SetActive(true);
                }
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

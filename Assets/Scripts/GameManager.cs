using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int health;
    public int point;

    public SpawnController spawn;

    private void Update()
    {
        if(health == 0)
        {
            Debug.Log("you lose");
            Time.timeScale = 0;
        }
    }
}

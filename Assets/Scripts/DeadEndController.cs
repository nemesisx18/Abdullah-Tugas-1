using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadEndController : MonoBehaviour
{
    public GameManager gameManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        gameManager.destroyQty++;

        if(other.tag == "Zombie")
        {
            gameManager.health--;
        }
    }
}

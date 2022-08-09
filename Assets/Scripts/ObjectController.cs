using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public int speed;
    public bool isZombie;

    public GameManager game;
    Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MoveObj();
    }

    public void MoveObj()
    {
        rig.velocity = Vector2.down * speed;
    }

    private void OnMouseDown()
    {
        if (isZombie)
        {
            game.point++;
            game.destroyQty++;
            Destroy(gameObject);
        }

        else
        {
            game.isLose = true;
            Time.timeScale = 0;
        }
    }
}

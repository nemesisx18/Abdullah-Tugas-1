using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI health;
    public TextMeshProUGUI poin;

    public GameManager game;
    
    // Update is called once per frame
    void Update()
    {
        health.text = "Health: " + game.health.ToString();
        poin.text = "Point: " + game.point.ToString();
    }
}

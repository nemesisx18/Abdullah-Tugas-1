using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI health;

    public GameManager game;
    
    // Update is called once per frame
    void Update()
    {
        health.text = game.health.ToString();
    }
}

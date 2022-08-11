using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI poin;
    public TextMeshProUGUI waveInfo;
    public TextMeshProUGUI health;

    public GameObject loseUI;
    public GameManager game;
    
    // Update is called once per frame
    void Update()
    {
        health.text = "Health: " + game.health.ToString();
        poin.text = "Point: " + game.point.ToString();
        waveInfo.text = "WAVE " + game.waveCount.ToString();

        if(game.isLose)
        {
            loseUI.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void RetryGame()
    {
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
    }
}

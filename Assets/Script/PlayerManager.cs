using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    public static bool isGameStarted;
    public GameObject gameOverPanel;
    public GameObject tabToSart;

    void Start()
    {
        gameOver = false;
        isGameStarted = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver){
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
        }
        if(SwipeManager.tap){
            isGameStarted = true;
            tabToSart.SetActive(false);
        }
    }
}

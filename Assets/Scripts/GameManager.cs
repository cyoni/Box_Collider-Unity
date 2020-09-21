using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.WSA.Input;

public class GameManager : MonoBehaviour
{
    public bool isRunning = true;
    float restartGame = 1f;
    public GameObject completeGameUI;


    public void EndGame()
    {
        if (isRunning)
        {
            Debug.Log("game over.");
            isRunning = false;
            Invoke("restart", restartGame);
        }
    }

    public void CompleteLevel()
    {
        isRunning = false;
        completeGameUI.SetActive(true);
        Invoke("restart", restartGame);
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour {

    [SerializeField] float delayInSeconds = 2f;
    GameSession gameSession;

    private void Awake() {
        Screen.SetResolution(576, 1024, true);
    }

    public void LoadStartMenu() {
        SceneManager.LoadScene(0);
    }

    public void LoadGame() {
        SceneManager.LoadScene("Game");
        gameSession = FindObjectOfType<GameSession>();
        gameSession.ResetGame();
    }

    public void LoadGameOver() {
        StartCoroutine(WaitAndLoad());
    }

    IEnumerator WaitAndLoad() {
        yield return new WaitForSeconds(delayInSeconds);
        SceneManager.LoadScene("Game Over");
    }

    public void QuitGame() {
        Application.Quit();
    }

}

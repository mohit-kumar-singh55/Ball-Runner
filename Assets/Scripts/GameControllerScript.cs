using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameControllerScript : MonoBehaviour
{
    public GameObject gameOverPanal;
    public GameObject tapToStartText;
    public GameObject scoreText;

    private void Start()
    {
        gameOverPanal.SetActive(false);
        // initially pausing the game
        PauseGame();
    }

    private void Update()
    {
        // playing game on tap to start
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartGame();
        }
    }

    public void ShowGameOverPanal(bool visible)
    {
        gameOverPanal.SetActive(visible);
        scoreText.SetActive(false);
    }

    public void Restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
        tapToStartText.SetActive(true);
        scoreText.SetActive(false);
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        tapToStartText.SetActive(false);
        scoreText.SetActive(true);
    }
}

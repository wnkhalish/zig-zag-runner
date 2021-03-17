using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    float exitTime = 2.5f;

    public GameObject gameOverState, startGameState, saveScoreState;
    Animator animatorEndGame, animatorStartGame;
    public GameObject player;
    public GameObject score;
    private void Start()
    {
        if (gameOverState)
        {
            animatorEndGame = gameOverState.GetComponent<Animator>();
           
        }
        else if (startGameState)
        {
            animatorStartGame = startGameState.GetComponent<Animator>();
        }
        else if (saveScoreState)
        {
            animatorEndGame = gameOverState.GetComponent<Animator>();
        }
    }

    public void StartGame()
    {
        StartCoroutine(StartGameCoroutine()); 
      
    }

    IEnumerator StartGameCoroutine()
    {
        animatorStartGame.SetTrigger("Button Pressed");
        yield return new WaitForSeconds(exitTime);
        SceneManager.LoadScene("GameScene");
       
    }


    public void Highscore()
    {
        StartCoroutine(HighscoreCoroutine());
    }
    public void ConfirmSave()
    {
        StartCoroutine(ConfirmSaveCoroutine());
    }

    IEnumerator HighscoreCoroutine()
    {
        animatorStartGame.SetTrigger("Button Pressed");
        yield return new WaitForSeconds(exitTime);
        SceneManager.LoadScene("Highscore");
    }

    IEnumerator ConfirmSaveCoroutine()
    {
        animatorEndGame.SetTrigger("Button Pressed");
        yield return new WaitForSeconds(exitTime);
        SceneManager.LoadScene("Highscore");
    }
    public void BackGame()
    {
        StartCoroutine(BackGameCoroutine());
    }

    IEnumerator BackGameCoroutine()
    {
        animatorStartGame.SetTrigger("Button Pressed");
        yield return new WaitForSeconds(exitTime);
        SceneManager.LoadScene("MainMenu");
    }

    public void CancelSave()
    {
        StartCoroutine(CancelSaveCoroutine());
    }


    IEnumerator CancelSaveCoroutine()
    {
        animatorEndGame.SetTrigger("Button Pressed");
        yield return new WaitForSeconds(exitTime);
        SceneManager.LoadScene("MainMenu");
    }


    public void QuitApp()
    {
        Application.Quit();
    }


    public void ResetLevel()
    {
        StartCoroutine(ResetGameCoroutine());
    }

    IEnumerator ResetGameCoroutine()
    {
        animatorEndGame.SetTrigger("Button Pressed");
        yield return new WaitForSeconds(exitTime);
        SceneManager.LoadScene("GameScene");
    }

    public void SaveScore()
    {
        StartCoroutine(SaveScoreCoroutine());
    }

    IEnumerator SaveScoreCoroutine()
    {
        animatorEndGame.SetTrigger("Button Pressed");
        yield return new WaitForSeconds(exitTime);
        saveScoreState.SetActive(true);
        player.SetActive(false);
        score.SetActive(false);
    }



}

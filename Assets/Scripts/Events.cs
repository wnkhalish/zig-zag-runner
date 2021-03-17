using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Events : MonoBehaviour
{

    public InputField playerNameInput;
    public Button confirmPlayerNameBtn;
    public Button skipSavingScoreBtn;
  
    public void OnConfirmPlayerNameBtnClick()
    {
        ScoreHolder.SetPlayerName(this.playerNameInput.text);
        Highscore.isScoreAlreadyAdded = false;
        SceneManager.LoadScene("Highscore");
    }

    public void OnSkipBtnClick()
    {


        Highscore.isScoreAlreadyAdded = true;
        SceneManager.LoadScene("MainMenu");
    }


    public void HighscoreTable()
    {

        SceneManager.LoadScene("HighScore", LoadSceneMode.Additive);
    }
}

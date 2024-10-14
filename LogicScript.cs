using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Note we have used a new library to interact with UI
using UnityEngine.SceneManagement; //Used in restartgame()

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;

    [ContextMenu("Increase Score")] //Used to provide an option to increase score in Unity's ui, without this we cannot manually increase the score in unity by clicking the 3 dots on logic script then clicking increase score
    public void addScore() //void indicates no value is being returned
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString(); //scoreText = playerScore. Note: playerScore.ToString() converts playerScore which was initially an int to a string. Unity does not allow scoreText.text = playerScore if playerScore is int.
    }

    public void restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //restarts game
        
    }

    public GameObject gameOverScreen;
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}

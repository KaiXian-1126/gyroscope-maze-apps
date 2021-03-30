using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void startGame()
    {
        // The index of the first level is 1
        SceneManager.LoadScene(1);
    }
    public void restartGame() //For the Play Again button
    {
        Scene loadedLevel = SceneManager.GetActiveScene();
        SceneManager.LoadScene(loadedLevel.buildIndex);
        //Unpaused the game
        Time.timeScale = 1;
    }
    public void goNextLevel() //For the Next Level button
    {
        Scene loadedLevel = SceneManager.GetActiveScene();
        SceneManager.LoadScene(loadedLevel.buildIndex + 1);
        //Unpaused the game
        Time.timeScale = 1;
    }
    public void quitGame() //For the Exit button
    {
        Application.Quit();

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        if (PlayerPrefs.GetInt("LevelIndex") >= Consts.FIRST_LEVEL_SCENE_INDEX)
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("LevelIndex"));
        }
        else
        {
            PlayerPrefs.SetInt("LevelIndex", Consts.FIRST_LEVEL_SCENE_INDEX);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void Options()
    {
        SceneManager.LoadScene(14);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    //return to main menu
    public void OnBackButtonClicked()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayFirstLevel()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("LevelIndex"));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartTask : MonoBehaviour
{
    public void Restart()
    {
        PlayerPrefs.SetInt($"statusLevel{PlayerPrefs.GetInt("LevelIndex")}", 0);
        
        SceneManager.LoadScene(PlayerPrefs.GetInt("LevelIndex"));
    }
}

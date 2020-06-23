using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetProgress : MonoBehaviour
{
    public void OnClick()
    {
        /*for (int i = 1; i <= 10; i++)
        {
            PlayerPrefs.SetInt($"statusLevel{i}", 0);
        }*/
        PlayerPrefs.DeleteAll();
        
        PlayerPrefs.SetInt("LevelIndex", 0);
        SceneManager.LoadScene(0);
    }
}

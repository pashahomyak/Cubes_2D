using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetProgress : MonoBehaviour
{
    public void OnClick()
    {
        PlayerPrefs.SetInt("LevelIndex", 0);
        SceneManager.LoadScene(0);
    }
}

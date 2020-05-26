using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 30.0f;
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = Convert.ToInt32(timer).ToString();
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            DataHolder.MyAnswer = "time is over";

            PlayerPrefs.SetInt("LevelIndex", PlayerPrefs.GetInt("LevelIndex") + 1);
            
            SceneManager.LoadScene(12);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class AnswerChecker : MonoBehaviour
{
    public Button myButton;
    
    void Start () {
		Button btn = myButton.GetComponent<Button>();
        if (btn.tag == "TrueAnswer")
        {
            DataHolder.TrueAnswer = myButton.GetComponentInChildren<Text>().text;
        }

		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick(){
        DataHolder.MyAnswer = myButton.GetComponentInChildren<Text>().text;

        PlayerPrefs.SetInt("LevelIndex", PlayerPrefs.GetInt("LevelIndex") + 1);

        SceneManager.LoadScene(12); //AnswerChecker scene
	}
}
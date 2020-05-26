using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;
using System.Threading.Tasks;

public class NextLevel : MonoBehaviour
{
    public Button myButton;
    void Start()
    {
        Button btn = myButton.GetComponent<Button>();

		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
    {   
        if (PlayerPrefs.GetInt("LevelIndex") > Consts.NUM_OF_LEVEL + 1)
        {
            PlayerPrefs.SetInt("LevelIndex", Consts.FIRST_LEVEL_SCENE_INDEX);
            SceneManager.LoadScene("GameOver");
        }
        else
        {
            SceneManager.LoadScene(PlayerPrefs.GetInt("LevelIndex"));
        }
        
	}
}
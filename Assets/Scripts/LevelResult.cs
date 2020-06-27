using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelResult : MonoBehaviour
{
    public Image levelImage;

    void Start()
    {
        GameObject LevelState = GameObject.FindWithTag("LevelState");

        Sprite levelSprite = Resources.Load<Sprite>("Levels/" + PlayerPrefs.GetString("LevelSpriteName"));
        levelImage.GetComponent<Image>().sprite = levelSprite;

        Sprite redBackSprite = Resources.Load<Sprite>("levelBackBlue");
        Sprite greenBackSprite = Resources.Load<Sprite>("levelBackGreen");

        if (PlayerPrefs.GetString("LevelResult") == "false")
        {
            levelImage.transform.localPosition = new Vector3(-2, 47);

            LevelState.GetComponent<Image>().sprite = redBackSprite;
            LevelState.GetComponentInChildren<Text>().fontSize = 96;
            LevelState.GetComponentInChildren<Text>().text = $"FAILURE";

            PlayerPrefs.SetInt($"statusLevel{PlayerPrefs.GetInt("LevelIndex")}", -1);
        }
        else
        {
            //restart
            GameObject restartButton = GameObject.FindWithTag("Restart");
            restartButton.SetActive(false);
            levelImage.transform.localPosition = new Vector3(-2, -67);
            
            LevelState.GetComponent<Image>().sprite = greenBackSprite;
            LevelState.GetComponentInChildren<Text>().fontSize = 96;
            LevelState.GetComponentInChildren<Text>().text = $"COMPLETED";

            PlayerPrefs.SetInt($"statusLevel{PlayerPrefs.GetInt("LevelIndex")}", 1);
        }
    }
}

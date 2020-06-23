using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelResult : MonoBehaviour
{
    public Image levelImage;
    public Text trueAnswer;
    public Text playerAnswer;

    void Start()
    {
        GameObject LevelState = GameObject.FindWithTag("LevelState");

        trueAnswer.text = DataHolder.TrueAnswer;
        playerAnswer.text = DataHolder.MyAnswer;

        Sprite levelSprite = Resources.Load<Sprite>("Levels/" + DataHolder.LevelSpriteName);
        levelImage.GetComponent<Image>().sprite = levelSprite;

        Sprite redBackSprite = Resources.Load<Sprite>("redBack2");
        Sprite greenBackSprite = Resources.Load<Sprite>("greenBack");

        if (DataHolder.TrueAnswer != DataHolder.MyAnswer)
        {
            playerAnswer.color = Color.red;

            LevelState.GetComponent<Image>().sprite = redBackSprite;
            LevelState.GetComponentInChildren<Text>().fontSize = 96;
            LevelState.GetComponentInChildren<Text>().text = $"FAILED";

            PlayerPrefs.SetInt($"statusLevel{PlayerPrefs.GetInt("LevelIndex") - 2}", -1);
        }
        else
        {
            playerAnswer.color = Color.green;
            LevelState.GetComponent<Image>().sprite = greenBackSprite;
            LevelState.GetComponentInChildren<Text>().fontSize = 96;
            LevelState.GetComponentInChildren<Text>().text = $"COMPLETED";

            PlayerPrefs.SetInt($"statusLevel{PlayerPrefs.GetInt("LevelIndex") - 2}", 1);

        }
    }
}

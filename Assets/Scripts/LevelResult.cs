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
        trueAnswer.text = DataHolder.TrueAnswer;
        playerAnswer.text = DataHolder.MyAnswer;

        Sprite levelSprite = Resources.Load<Sprite>("Levels/" + DataHolder.LevelSpriteName);
        levelImage.GetComponent<Image>().sprite = levelSprite;

        if (DataHolder.TrueAnswer != DataHolder.MyAnswer)
        {
            playerAnswer.color = Color.red;
        }
        else
        {
            playerAnswer.color = Color.green;
        }
    }
}

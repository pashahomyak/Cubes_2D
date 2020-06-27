using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelStatus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //обновление для 2 уровня
        if (PlayerPrefs.GetInt("LevelIndex") == 6)
        {
            for (int i = 1; i <= 5; i++)
            {
                PlayerPrefs.SetInt($"statusLevel{i}", 0);

                Sprite levelSprite = Resources.Load<Sprite>("LevelState/blue_circle");

                GameObject level = GameObject.FindWithTag($"task{i}");
                level.GetComponent<Image>().sprite = levelSprite;
                level.GetComponent<Image>().rectTransform.sizeDelta = new Vector2(100, 100); 
            }
        }
        
        
        if (PlayerPrefs.GetInt("LevelIndex") < 6)
        {
            ChangeLevelStatus(1, 5);
        }
        else
        {
            ChangeLevelStatus(6, 10);
        }
    }

    private void ChangeLevelStatus(int startIndex, int endIndex)
    {
        for (int i = startIndex; i <= endIndex; i++)
        { 
            int taskIndex = i < 6 ? i : i - 5;

            if (PlayerPrefs.GetInt($"statusLevel{i}") == 0)
            {
                Sprite levelSprite = Resources.Load<Sprite>("LevelState/curr_circle");

                GameObject level = GameObject.FindWithTag($"task{taskIndex}");
                level.GetComponent<Image>().sprite = levelSprite;
                level.GetComponent<Image>().rectTransform.sizeDelta = new Vector2(120, 120);

                break;
            }
            else if (PlayerPrefs.GetInt($"statusLevel{i}") == 1) //good
            {
                Sprite levelSprite = Resources.Load<Sprite>("LevelState/green_circle");

                GameObject level = GameObject.FindWithTag($"task{taskIndex}");
                level.GetComponent<Image>().sprite = levelSprite;
                level.GetComponent<Image>().rectTransform.sizeDelta = new Vector2(100, 100);
            }
            else if (PlayerPrefs.GetInt($"statusLevel{i}") == -1) //bad
            {
                Sprite levelSprite = Resources.Load<Sprite>("LevelState/red_circle");

                GameObject level = GameObject.FindWithTag($"task{taskIndex}");
                level.GetComponent<Image>().sprite = levelSprite;
                level.GetComponent<Image>().rectTransform.sizeDelta = new Vector2(100, 100);
            }
        }
    }
}

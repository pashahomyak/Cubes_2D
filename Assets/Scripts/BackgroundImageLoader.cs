using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundImageLoader : MonoBehaviour
{
    public Image backgroundImage;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("LevelIndex") > 6)
        {
            Sprite backgroundSprite = Resources.Load<Sprite>("Background2");
            backgroundImage.GetComponent<Image>().sprite = backgroundSprite;
        }
    }
}

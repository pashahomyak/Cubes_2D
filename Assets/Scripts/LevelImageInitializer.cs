﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelImageInitializer : MonoBehaviour
{
    public Image image;
    void Start()
    {
        PlayerPrefs.SetString("LevelSpriteName", image.sprite.name + "_result");
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rules : MonoBehaviour
{
    // Start is called before the first frame update
    public void Continue()
    {
        PlayerPrefs.SetInt("Rules", 1);

        GameObject.Find("Rules").SetActive(false);
    }
}

using UnityEngine;
using UnityEngine.UI;

public static class DataHolder
{
    private static string levelSpriteName;
    private static string myAnswer;
    private static string trueAnswer;

    public static string LevelSpriteName
    {
        get
        {
            return levelSpriteName;
        }
        set
        {
            levelSpriteName = value;
        }
    }

    public static string MyAnswer
    {
        get
        {
            return myAnswer;
        }
        set
        {
            myAnswer = value;
        }
    }

    public static string TrueAnswer
    {
        get
        {
            return trueAnswer;
        }
        set
        {
            trueAnswer = value;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Threading;
using System.Threading.Tasks;

public class AnswerChecker : MonoBehaviour
{
    public Button myButton;

    private Sprite redCircle;
    private Sprite greenCircle;
    
    void Start () {
		redCircle = Resources.Load<Sprite>("redCircle");
        greenCircle = Resources.Load<Sprite>("greenCircle");
    
        Button btn = myButton.GetComponent<Button>();

		btn.onClick.AddListener(TaskOnClick);
	}

	async void TaskOnClick()
    {
        if (myButton.GetComponent<Button>().tag == "TrueAnswer")
        {
            GameObject.Find("AnswerTexts/AnswerResult" + myButton.name[myButton.name.Length - 1]).GetComponent<Text>().text = "True!";
            GameObject.Find("AnswerTexts/AnswerResult" + myButton.name[myButton.name.Length - 1]).GetComponent<Text>().color = Color.green;

            myButton.GetComponent<Image>().sprite = greenCircle;
            PlayerPrefs.SetString("LevelResult", "true");
        }
        else
        {
            GameObject.Find("AnswerTexts/AnswerResult" + myButton.name[myButton.name.Length - 1]).GetComponent<Text>().text = "False!";

            myButton.GetComponent<Image>().sprite = redCircle;
            PlayerPrefs.SetString("LevelResult", "false");
        }

        await Task.Delay(2000);

        SceneManager.LoadScene(11); //AnswerChecker scene
	}
}
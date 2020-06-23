using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    // Start is called before the first frame update
    public void OnClick()
    {
        Image settings = this.GetComponent<Image>();
        settings.transform.Rotate(0, 0, 180); 
    }

}

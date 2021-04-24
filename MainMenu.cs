using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Text PrevioustimeText;
    public static float theprevioustime;
    void Start()
    {
        theprevioustime = PlayerPrefs.GetFloat("Besttime");
        PrevioustimeText.text = theprevioustime.ToString();
    }


}

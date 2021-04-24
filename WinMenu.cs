using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinMenu : MonoBehaviour
{
    public float goalTime = 0.0f;
    public float previoustime;
    public Text goalTimeText;
    public Text bestTimeText;

    void Start()
    {
        previoustime = PlayerPrefs.GetFloat("Besttime");

        GetComponent<TimeCount>();
        GetComponent<MainMenu>();

    }

    // Update is called once per frame
    void Update()
    {
        goalTime = TimeCount.time;
        goalTimeText.text = goalTime.ToString();

        if (previoustime >= goalTime)
        { PlayerPrefs.SetFloat("Besttime", goalTime); }

        bestTimeText.text = previoustime.ToString();

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public Text timeText;
    float timer;
    
    void Update()
    {
        timer += Time.deltaTime;
        timeText.text = timer.ToString();
    }
    
}

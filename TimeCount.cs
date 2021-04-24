using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCount : MonoBehaviour
{
    static public float time = 0.0f;

    private bool timerisActive = true;

    public Text timeText;

    //void Awake()
    //{
    //    DontDestroyOnLoad(transform.gameObject);
    //}
    void Start()
    {

        timeText.text = "Time";
    }
    void Update()
    {
        if (timerisActive == true)
        {
            time += Time.deltaTime;
            timeText.text = time.ToString();
        }
        else
        {
            timerisActive = false;
        }

    }




}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public int Coins_To_Unlocked;
    public GameObject Next_Level;
    public int max_level;
    public string num_level;
    public static int thelevel;
    public int t;
    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;
        ItemManager.Coins = 0;
        thelevel = PlayerPrefs.GetInt("thelevel", thelevel);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 1; i < max_level; i++)
        {
            if (ItemManager.Coins == Coins_To_Unlocked && LevelUnlocked.level == i)
            {
                Time.timeScale = 0;
                Next_Level.SetActive(true);
            }
        }
    }
    public static void the_level(int t)
    {
        thelevel = t;
        PlayerPrefs.SetInt("thelevel", thelevel);
    }
    public void next()
    {
        LevelUnlocked.Next_Level();
        SceneManager.LoadScene("Map_Select");
    }
    public void _level()
    {
        the_level(t);
        SceneManager.LoadScene(num_level);

    }
}

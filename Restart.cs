using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    public void RestartLevelOne()
    {
        SceneManager.LoadScene("Scene01");
    }

    public void RestartLevelTwo()
    {
        SceneManager.LoadScene("Scene02");
    }

    public void RestartLevelThree()
    {
        SceneManager.LoadScene("Scene03");
    }

    public void RestartLevelFour()
    {
        SceneManager.LoadScene("Scene04");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void GoToCharacterSelect()
    {
        SceneManager.LoadScene("CharacterSelect");
    }

    public void GoToHowToPlay()
    {
        SceneManager.LoadScene("HowToPlay");
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CollisionCheck : MonoBehaviour
{
    private IEnumerator LevelOne()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Scene02");
    }

    private IEnumerator LevelTwo()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Scene03");
    }

    private IEnumerator LevelThree()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Scene04");
    }

    private IEnumerator LevelFour()
    {
        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Complete");
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Goal001")
        {
            StartCoroutine(LevelOne());
            Debug.Log("Level 1 Passed!");
        }

        if (other.name == "Goal002")
        {
            StartCoroutine(LevelTwo());
            Debug.Log("Level 2 Passed!");
        }

        if (other.name == "Goal003")
        {
            StartCoroutine(LevelThree());
            Debug.Log("Level 3 Passed!");

        }

        if (other.name == "Goal004")
        {
            StartCoroutine(LevelFour());
            Debug.Log("Level 4 Passed!");

        }

        if (other.name == "Death002")
        {
            SceneManager.LoadScene("Scene02");
            Debug.Log("Dead in Level 2!");
        }

        if (other.name == "Death003")
        {
            SceneManager.LoadScene("Scene03");
            Debug.Log("Dead in Level 3!");
        }

        if (other.name == "Death004")
        {
            SceneManager.LoadScene("Scene04");
            Debug.Log("Dead in Level 4!");
        }
    }
}
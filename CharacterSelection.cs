using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection : MonoBehaviour
{
    private GameObject[] characterList;
    private int index;

    private void Start()
    {
        GetComponent<TimeCount>();

        index = PlayerPrefs.GetInt("CharacterSelected");

        characterList = new GameObject[transform.childCount];

        //fill an array with models
        for (int i = 0; i < transform.childCount; i++)
        {
            characterList[i] = transform.GetChild(i).gameObject;
        }

        //toggle off the model render
        foreach (GameObject _go in characterList)
        {
            _go.SetActive(false);
        }

        //toggle on the selected character
        if (characterList[index])
        {
            characterList[index].SetActive(true);
        }
    }

    public void ToggleLeft()
    {
        //toggle of the current model
        characterList[index].SetActive(false);

        index -= 1;
        if (index < 0)
        {
            index = characterList.Length - 1;
        }

        //toggle on the new model
        characterList[index].SetActive(true);
    }

    public void ToggleRight()
    {
        //toggle of the current model
        characterList[index].SetActive(false);

        index += 1;
        if (index == characterList.Length)
        {
            index = 0;
        }

        //toggle on the new model
        characterList[index].SetActive(true);
    }

    public void PlayButton()
    {
        //set int from the index to player prefs
        PlayerPrefs.SetInt("CharacterSelected", index);
        SceneManager.LoadScene("Scene01");
        TimeCount.time = 0.0f;
    }
}

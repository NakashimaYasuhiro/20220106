using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleStart : MonoBehaviour
{
    private bool firstPush = false;
 //When StartButton is pushed
 public void PressStart()
    {
        Debug.Log("Press Start");

        if(!firstPush)
        {
            Debug.Log("Go to next Scene");
            SceneManager.LoadScene("MainScene");
            firstPush = true;


        }

    }
}

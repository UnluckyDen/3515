using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMain : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("game"); 
    }

    public void Exit()
    {
        Application.Quit();
    }
}

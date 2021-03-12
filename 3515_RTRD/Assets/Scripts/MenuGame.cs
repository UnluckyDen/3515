using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGame : MonoBehaviour
{
    public GameObject PanelMenu;

    private void Start()
    {
        PanelMenu.SetActive(false);
    }

    public void BackToMain()
    {
        SceneManager.LoadScene("main");

    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PanelMenu.SetActive(!PanelMenu.activeSelf);
        }
    }
}

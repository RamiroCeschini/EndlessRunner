using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void ButtonPlay()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1.0f;
    }

    public void ButtonExit()
    {
        Application.Quit();
    }

    public void ButtonMenu()
    {
        SceneManager.LoadScene(0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void onClickPlay()
    {
        SceneManager.LoadScene("BowlingGame");
    }

    public void onClickCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void onClickMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void onClickExit()
    {
        Application.Quit();
    }
}

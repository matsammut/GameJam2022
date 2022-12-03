using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Victory : MonoBehaviour
{
    public string SceneName = "Game";
    public string SceneName2 = "Menu";


    public void PlayGame()
    {

        SceneManager.LoadScene(SceneName);
    }

    public void Menu()
    {
        SceneManager.LoadScene(SceneName2);
    }
}
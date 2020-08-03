using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartQuit : MonoBehaviour
{
    public void SceneChange(string name)
    {

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

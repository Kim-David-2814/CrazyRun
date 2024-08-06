using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManegrcomponent : MonoBehaviour
{
    public void SwitchScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void Pause()
    {
        Time.timeScale = 0f;
    }

    public void Play()
    {
        Time.timeScale = 1f;
    }

}

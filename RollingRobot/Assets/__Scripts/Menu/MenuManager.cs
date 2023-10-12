using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private void Awake()
    {
        SetPause(false);
        
    }
   
    public void LoadMainScene()
    {
       // LevelManager.Instance.DisablePauseButton();
        SceneManager.LoadScene(0);
    }

    public void LoadNextScene()
    {
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextScene < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextScene);
        }
        else
        {
            // LoadMainScene();
            SceneManager.LoadScene(1);
        }

    }

    public void ReloadScene()
    {
        SetPause(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void SetPause(bool isOn)
    {
        Time.timeScale = isOn ? 0 : 1;
    }
}

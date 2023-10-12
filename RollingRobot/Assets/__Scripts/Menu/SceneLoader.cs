using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    private int sceneNumber = 0;
    public void LoadSettedScene()
    {
        if (sceneNumber > 0)
        {
            SceneManager.LoadScene(sceneNumber);
        }
    }
    public void SetSceneToLoad(int n, bool available)
    {
        sceneNumber = available ? n : 0;
        GetComponentInChildren<TMPro.TextMeshProUGUI>().text = n.ToString();
        if (!available)
        {
            GetComponent<Image>().color = Color.gray;
        }
        else
        {
            GetComponent<Image>().color = new Color(0.51f, 0.78f, 0.23f);
        }
    }
}

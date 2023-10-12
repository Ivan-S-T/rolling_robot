using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] GameObject pauseButton;
    [SerializeField] GameObject winPanel;
    [SerializeField] GameObject loosePanel;

    public static LevelManager Instance { get; private set; }

    private void Awake()
    {
        Instance = this;        
    }

    //private void Start()
    //{
    //    StartCoroutine(nameof(PauseDisabling));
    //}

    //IEnumerator PauseDisabling()
    //{
    //    yield return new WaitForSeconds(0.01f);
    //    Time.timeScale = 1;
    //}

    public void FinishLevel(bool isWin)
    {
        Debug.Log("WRITE scores etc in GameManager, show ADD checking= in game manager set played games variable");
        winPanel.SetActive(isWin);
        loosePanel.SetActive(!isWin);

        pauseButton.SetActive(false);

        if (isWin&&GameManager.Instance!=null)
        {
            int thisScene = SceneManager.GetActiveScene().buildIndex;
            GameManager.Instance.SetFinishedLevels(thisScene);
        }
        GameManager.Instance.AddPlayedRounds();
    }
    public  void DisablePauseButton()
    {
        pauseButton.SetActive(false);
    }
}

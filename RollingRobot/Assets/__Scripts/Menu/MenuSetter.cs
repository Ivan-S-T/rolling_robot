using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSetter : MonoBehaviour
{
    [SerializeField] private GameObject[] levelButtons;
    private int nextLevel;
    private int panelNumber;
    private int buttonsOnPanel;
    private int scenesInGame;

    public int PanelNumber { get => panelNumber; set => panelNumber = value > 0 ? (value > NextLevel / buttonsOnPanel ? NextLevel / buttonsOnPanel : value) : 0; }
    public int NextLevel { get => nextLevel; set => nextLevel = (value >= scenesInGame) ? scenesInGame - 1 : value; }

    private void Awake()
    {
        scenesInGame = SceneManager.sceneCountInBuildSettings;
    }
    private void Start()
    {
        NextLevel = GameManager.Instance.FinishedLevels + 1;
        buttonsOnPanel = levelButtons.Length;
        PanelNumber = NextLevel / buttonsOnPanel;
        FillPanel();
    }
    public void FillPanel()
    {
        for (int i = 0; i < buttonsOnPanel; i++)
        {
            levelButtons[i].gameObject.SetActive(true);

            int levelNumber = i + 1 + PanelNumber * buttonsOnPanel;
            var sceneLoader = levelButtons[i].GetComponent<SceneLoader>();
            if (levelNumber < scenesInGame)
            {
                sceneLoader.SetSceneToLoad(levelNumber, levelNumber <= NextLevel);
            }
            else
            {
                levelButtons[i].gameObject.SetActive(false);
            }
        }
    }
    public void NextPanel()
    {
        ++PanelNumber;
        FillPanel();
    }
    public void PreviousPanel()
    {
        --PanelNumber;
        FillPanel();
    }
    public void PlayLastLevel()
    {
        SceneManager.LoadScene(NextLevel);
    }
}

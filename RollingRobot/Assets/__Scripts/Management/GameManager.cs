using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    private int finishedLevels;
    private int playedRounds;
    private int adsRate = 10;
    private int feedbackAskRate = 17;
    public static GameManager Instance { get; private set; }
    public int FinishedLevels { get => finishedLevels; private set => finishedLevels = value; }
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        FinishedLevels = PlayerPrefs.GetInt("finishedLevels", 0);
        playedRounds = PlayerPrefs.GetInt("playedRounds", 0);

    }
    public void SetFinishedLevels(int level)
    {
        if (level > FinishedLevels)
        {
            FinishedLevels = level;
            PlayerPrefs.SetInt("finishedLevels", FinishedLevels);
        }
    }
    public void AddPlayedRounds()
    {
        playedRounds++;
    }
}

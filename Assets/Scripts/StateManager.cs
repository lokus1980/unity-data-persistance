using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    private const string BestScoreKey = "BestScore";

    public int bestScore = 0;

    public static StateManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        bestScore = PlayerPrefs.GetInt(BestScoreKey, 0);
    }

    public void SaveGame()
    {
        PlayerPrefs.SetInt(BestScoreKey, bestScore);
        PlayerPrefs.Save();
    }
}

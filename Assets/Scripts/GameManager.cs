using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //점수
    [SerializeField]
    private int score = 0;
    [SerializeField]
    private int targetScore = 0;

    [SerializeField]
    private TMPro.TextMeshProUGUI scoreText;
    [SerializeField]
    private TMPro.TextMeshProUGUI clearText;
    private void Awake()
    {
        targetScore = GameObject.FindGameObjectsWithTag("Item").Length;
    }

    public void AddScore()
    {
        score = score + 1;

        scoreText.text = $"Score : {score}";
        if (IsGameClear())
        {
            Debug.Log("게임클리어!");
            clearText.text = $"GameClear!";
        }
    }
    
    //게임 클리어
    private bool IsGameClear()
    {
        // 게임클리어 조건
        // 예외처리 할수 있으면 해라
        return score == 2 * targetScore;
    }
}

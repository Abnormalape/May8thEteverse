using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //����
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
            Debug.Log("����Ŭ����!");
            clearText.text = $"GameClear!";
        }
    }
    
    //���� Ŭ����
    private bool IsGameClear()
    {
        // ����Ŭ���� ����
        // ����ó�� �Ҽ� ������ �ض�
        return score == 2 * targetScore;
    }
}

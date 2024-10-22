using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreText : MonoBehaviour
{
    public ScoreButton ScoreButton;
    TextMeshProUGUI scoreText;

    private void Awake()
    {
        // �ν����Ϳ��� ������ �� �ִ� ���� ������Ʈ�� �����ͼ� �������!
        // GetComponent�� ����Ѵ� �� ���� ���� �� �ִ�??
        scoreText = GetComponent<TextMeshProUGUI>();
        //ScoreButton.scoreButton.onClick.AddListener(RefreshUI());
        ScoreButton.OnScoreChanged += RefreshUI;
    }

    void RefreshUI(int newScore)
    {
        scoreText.text = $"Score : {newScore.ToString()}";
    }
}

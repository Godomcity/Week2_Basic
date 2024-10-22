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
        // 인스펙터에서 가져올 수 있는 게임 오브젝트는 가져와서 사용하자!
        // GetComponent를 사용한는 것 보다 좋을 수 있다??
        scoreText = GetComponent<TextMeshProUGUI>();
        //ScoreButton.scoreButton.onClick.AddListener(RefreshUI());
        ScoreButton.OnScoreChanged += RefreshUI;
    }

    void RefreshUI(int newScore)
    {
        scoreText.text = $"Score : {newScore.ToString()}";
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public ScoreButton ScoreButton;
    TextMeshProUGUI scoreText;

    private void Awake()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
        ScoreButton.scoreButton.onClick.AddListener(RefreshUI);
    }

    void RefreshUI()
    {
        scoreText.text = $"Score : {ScoreButton.score.ToString()}";
    }
}

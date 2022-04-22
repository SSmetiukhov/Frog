using System;
using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    private static int _score;
    public TextMeshProUGUI scoreText;


    public void Start()
    {
        _score = 0;
    }

    private void Update()
    {
        scoreText.text = _score.ToString();
    }

    public static void AddScore(int scoreAdded)
    {
        _score += scoreAdded;
    }

    public static void RemoveScore()
    {
        _score = 0;
    }
}
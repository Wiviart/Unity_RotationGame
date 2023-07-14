using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static Score instance;
    public TextMeshProUGUI text;
    public int score;
    void Awake()
    {
        instance = this;
    }
    void Start()
    {
        ResetScore();
    }

    void Update()
    {

    }
    public void ScoreIncrease(int amount)
    {
        score += amount;

        DisplayScore();
    }
    void DisplayScore()
    {
        text.text = $"{score}";
    }
    void ResetScore()
    {
        score = 0;

        DisplayScore();
    }
}

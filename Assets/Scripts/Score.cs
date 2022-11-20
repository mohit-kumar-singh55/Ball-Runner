using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text finalScoreText;

    private int myScore = 0;

    public void AddScore(int score)
    {
        myScore += score;
        scoreText.text = myScore.ToString();
        finalScoreText.text = "Score is " + myScore.ToString();
    }
}

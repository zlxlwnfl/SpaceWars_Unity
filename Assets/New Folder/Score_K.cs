using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_K : MonoBehaviour {

    public Text score;

    public int score1 = 0;

    public static Score_K instance;

    void Awake()
    {
        if (Score_K.instance == null)
            Score_K.instance = this;

		score.text = "0";
    }

    public void AddScore(int enemyScore)
    {
        score1 += enemyScore;
        print(score1);

        score.text = score1.ToString();
    }
}

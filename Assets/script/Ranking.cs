using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ranking : MonoBehaviour {
    public Text ranking1;
    public int score2;
    public static Ranking instance;

    static int[] ranking = new int[3] { 0, 0, 0 };
    // Use this for initialization

    void Awake()
    {
        if (Ranking.instance == null)
            Ranking.instance = this;
    }
    public static void InsertScore(int score)
    {
        for (int i = 0; i < 3; i++)
        {
            
                if (score > ranking[i])
                {
                    for (int j = 2; j > i; j--)
                    {
                        ranking[j] = ranking[j - 1];
                    }
                    ranking[i] = score;
                    break;
                }
        }
    }

    void Start()
    {
        
        ranking1.text = "Ranking\n" +
            "1. " + ranking[0].ToString() + "\n" +
            "2. " + ranking[1].ToString() + "\n" +
            "3. " + ranking[2].ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingNormal : MonoBehaviour {

    public Text ranking2;


    static int[] ranking3 = new int[3] { 0, 0, 0 };
    // Use this for initialization

    public static void InsertScore(int score)
    {
        for (int i = 0; i < 3; i++)
        {

            if (score > ranking3[i])
            {
                for (int j = 2; j > i; j--)
                {
                    ranking3[j] = ranking3[j - 1];
                }
                ranking3[i] = score;
                break;
            }
        }
    }

    void Start()
    {

        ranking2.text = "Ranking\n" +
            "1. " + ranking3[0].ToString() + "\n" +
            "2. " + ranking3[1].ToString() + "\n" +
            "3. " + ranking3[2].ToString();
    }
}

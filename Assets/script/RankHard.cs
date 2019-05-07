using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankHard : MonoBehaviour {

    public Text ranking6;


    static int[] ranking7 = new int[3] { 0, 0, 0 };
    // Use this for initialization

    public static void InsertScore(int score)
    {
        for (int i = 0; i < 3; i++)
        {

            if (score > ranking7[i])
            {
                for (int j = 2; j > i; j--)
                {
                    ranking7[j] = ranking7[j - 1];
                }
                ranking7[i] = score;
                break;
            }
        }
    }

    void Start()
    {

        ranking6.text = "Ranking\n" +
            "1. " + ranking7[0].ToString() + "\n" +
            "2. " + ranking7[1].ToString() + "\n" +
            "3. " + ranking7[2].ToString();
    }
}

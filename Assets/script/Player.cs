using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int HP;
    public int score;
    private Player_Data playerData;
    public int number;
	public Special special;
	public bool specialBool = false;
	public float TimeCost;

	public GameObject heart1;
	public GameObject heart2;
	public GameObject heart3;

    // Use this for initialization
    void Start()
    {
		TimeCost = 0f;
        playerData = new Player_Data(HP);
        Debug.Log(gameObject.name + "의 체력 : " + playerData.getHP());
    }

    void Update()
    {
        if (playerData.getHP() <= 0)
        {
            Debug.Log("파괴!!!");
            Destroy(gameObject);
            score = Score_K.instance.score1;
            if (number == 1)
            {
                Ranking.InsertScore(score);
            }
            else if (number == 2)
            {
                RankingNormal.InsertScore(score);
            }
            else if (number == 3)
            {
                RankHard.InsertScore(score);
            }

            SceneManager.LoadScene("gameover");
        }

		if (special.GetComponent<Special> ().SpecialCurrent == 100f) {
			specialBool = true;
			Special ();

			TimeCost += Time.deltaTime;

			if (TimeCost > 5) {
				special.GetComponent<Special> ().SpecialCurrent = 0f;
				specialBool = false;
				Original ();

				TimeCost = 0;
			}
		}
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
		if (specialBool == true && collision.CompareTag("Enemy"))
		{
			Debug.Log("(스페셜)적과 충돌");
			Destroy(collision.gameObject);
            Score_K.instance.AddScore(100);
            Debug.Log(gameObject.name + "의 현재 체력 : " + playerData.getHP());
			return;
		}
		if (specialBool == true && collision.CompareTag("enemy Missile"))
		{
			Debug.Log("(스페셜)미사일과 충돌");
			Destroy(collision.gameObject);
			Debug.Log(gameObject.name + "의 현재 체력 : " + playerData.getHP());
			return;
		}

        if (collision.CompareTag("Enemy"))
        {
            Debug.Log("적과 충돌");
            Destroy(collision.gameObject);
            playerData.decreaseHP();
			Heart ();
            Debug.Log(gameObject.name + "의 현재 체력 : " + playerData.getHP());
        }
        if (collision.CompareTag("enemy Missile"))
        {
            Debug.Log("미사일과 충돌");
            playerData.decreaseHP();
			Heart ();
            Debug.Log(gameObject.name + "의 현재 체력 : " + playerData.getHP());
        }

    }

	void Special()
	{
		GetComponent<SpriteRenderer> ().sprite = Resources.Load (("보호막우주선"), typeof(Sprite)) as Sprite;
	}

	void Original()
	{
		GetComponent<SpriteRenderer> ().sprite = Resources.Load (("아군기체"), typeof(Sprite)) as Sprite;
	}

	void Heart() {
		if (playerData.getHP () == 2) {
			heart3.SetActive (false);
		} else if (playerData.getHP () == 1) {
			heart2.SetActive (false);
		} else if (playerData.getHP () == 0) {
			heart1.SetActive (false);
		} 
	}
}

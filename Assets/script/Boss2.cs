using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss2 : MonoBehaviour {

	public int HP;
	private Enemy_Data enemyData;
	public GameObject Item;
	public Transform ItemLocation;
	public int score;
	public int killscore = 500;
	public int number;

	// Use this for initialization
	void Start()
	{
		enemyData = new Enemy_Data(HP);

	}

	void Update()
	{
		if (enemyData.getHP() <= 0)
		{
			Debug.Log("파괴!!!");
			Destroy(gameObject);
			Score_K.instance.AddScore(killscore);
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
			//랜덤한 위치와, 화면 제일 위에서 Enemy를 하나 생성해줍니다.
			SceneManager.LoadScene ("Ending");
		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.CompareTag("Player Missile"))
		{
			Debug.Log("미사일과 충돌");
			enemyData.decreaseHP();
			Debug.Log(gameObject.name + "의 현재 체력 : " + enemyData.getHP());

		}
	}

}

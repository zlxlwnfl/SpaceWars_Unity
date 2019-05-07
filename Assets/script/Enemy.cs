using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public static int score;
    public int HP;
    private Enemy_Data enemyData;
    public GameObject Item;
    public Transform ItemLocation;

    // Use this for initialization
    void Start () {
        enemyData = new Enemy_Data(HP);
        
	}

    void Update()
    {
        if (enemyData.getHP() <= 0)
        {
            Debug.Log("파괴!!!");
            Destroy(gameObject);
			score += 100;
			Debug.Log(score);

            Score_K.instance.AddScore(100);
             //랜덤한 위치와, 화면 제일 위에서 Enemy를 하나 생성해줍니다.
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player Missile"))
        {
            Debug.Log("미사일과 충돌");
            enemyData.decreaseHP();
            Debug.Log(gameObject.name + "의 현재 체력 : " + enemyData.getHP());     
        }
    }

    // Update is called once per frame
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : MonoBehaviour {

    public int HP;
    private enemy2_data enemyData;
    public GameObject Item;
    public Transform ItemLocation;

    // Use this for initialization
    void Start()
    {
        enemyData = new enemy2_data(HP);

    }

    void Update()
    {
        if (enemyData.getHP() <= 0)
        {
            Debug.Log("파괴!!!");
            Destroy(gameObject);
            Instantiate(Item, ItemLocation.position, ItemLocation.rotation);
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

    // Update is called once per frame

}

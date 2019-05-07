using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour {

    public const float moveSpeed = 2f;
    private Missile_Move2 enemyData;
    //상수로 움직일 속도를 지정해 줍니다.
    void Start()
    {

    }
    void Update()
    {
        transform.Translate(Vector2.down * moveSpeed * Time.deltaTime);
        //프레임이 변화할때 마다 움직임을 관리해주는 함수를 호출해줍시다.
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {

            Missile2.setMissileState(true);
            Destroy(gameObject);
        }

    }

}

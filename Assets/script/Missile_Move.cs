using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile_Move : MonoBehaviour {

    public float MoveSpeed;
    public float DestroyYPos;
    
    // Use this for initialization

    // Update is called once per frame
    void Update () {
        transform.Translate(Vector2.up * MoveSpeed * Time.deltaTime);
        if(transform.position.y >= DestroyYPos)
        {
            Destroy(gameObject);
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            Debug.Log("적기체와 충돌");
            Destroy(gameObject);
        }

        if (collision.CompareTag("boss1_enemy"))
        {
            Debug.Log("적기체와 충돌");
            Destroy(gameObject);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_MissileMove : MonoBehaviour {

    public float MoveSpeed;
    public float DestroyYPos;
    // Use this for initialization

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * MoveSpeed * Time.deltaTime);
        if (transform.position.y <= DestroyYPos)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            Debug.Log("아군기체와 충돌");
            Destroy(gameObject);
        }
    }
}

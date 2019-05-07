using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_MissileMove2 : MonoBehaviour {

    public float MoveSpeed;
    public float DestroyYPos;
    static float a = Mathf.Sqrt(26);
    Vector2 v1 = new Vector2(-1/a,-5/a);



    // Use this for initialization

    // Update is called once per frame
    void Update()
    {
        transform.Translate(v1 * MoveSpeed * Time.deltaTime);
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

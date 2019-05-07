using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class E_MissileMove5 : MonoBehaviour {

    public float MoveSpeed;
    public float DestroyYPos;
    Vector2 v1 = new Vector2(1, -2);



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
}

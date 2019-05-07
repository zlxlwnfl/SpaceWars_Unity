using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    public float Speed = 3f;

    void Update()
    {
        Move1();
        MoveClamp();
    }

    private void Move1()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * Speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector2.down * Speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * Speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {

            transform.Translate(Vector2.left * Speed * Time.deltaTime);
        }
    }
	// Use this for initialization

    private void MoveClamp()
    {
        Vector2 left = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 right = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        Vector2 player = transform.position;

        player.x = Mathf.Clamp(player.x, left.x + 0.8F, right.x - 0.8F);
        player.y = Mathf.Clamp(player.y, left.y + 1, right.y - 1);

        transform.position = player;
    }
	
}

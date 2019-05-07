using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Data {

    private int HP;
    int damage = 1;
    public Player_Data(int _HP)
    {
        HP = _HP;
    }

    public void decreaseHP()
    {
        HP -= damage;
    }

    public int getHP()
    {
        return HP;
    }
}

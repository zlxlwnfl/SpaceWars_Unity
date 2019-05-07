using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Data{
    private int HP;
    public int damage = 1;
    public Enemy_Data(int _HP)
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

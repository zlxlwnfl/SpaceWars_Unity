using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2_data : MonoBehaviour {

    private int HP;
    public int damage = 1;
    public enemy2_data(int _HP)
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_Missile : MonoBehaviour {
    public GameObject EnemyMissile;
    public Transform E_MissileLocation;
    public float E_MissileDelay;
    private bool E_MissileState;
    // Use this for initialization
    void Start () {
        E_MissileState = true;
    }
	
	// Update is called once per frame
	void Update () {
        E_Missile();

    }

    private void E_Missile()
    {
        if(E_MissileState)
        {
            StartCoroutine(TimerStart());
            if (EnemyMissile == null || E_MissileLocation==null || E_MissileLocation.rotation==null)
                return;
            Instantiate(EnemyMissile, E_MissileLocation.position, E_MissileLocation.rotation);
        }
    }

    IEnumerator TimerStart()
    {

                E_MissileState = false;
                yield return new WaitForSeconds(E_MissileDelay);
                E_MissileState = true;
         
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour {

    public GameObject PlayerMissile;
    public Transform MissileLocation;
    public float MissileDelay;
    private bool MissileState;
	// Use this for initialization
	void Start () {
        MissileState = true;
	}
	
	// Update is called once per frame
	void Update () {
        playerMissile();
	}

    private void playerMissile()
    {
        if(MissileState)
        {
            if (PlayerMissile == null || MissileLocation == null || MissileLocation.rotation == null)
                return;
            if (Input.GetKey(KeyCode.A))
            {
                
                StartCoroutine(MissileCycleControl());
                Instantiate(PlayerMissile, MissileLocation.position, MissileLocation.rotation);
            }
        }
    }

    IEnumerator MissileCycleControl()
    {
        MissileState = false;
        yield return new WaitForSeconds(MissileDelay);
        MissileState = true;
    }
}

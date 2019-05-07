using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DontDestory : MonoBehaviour {

    public int count = Camera.allCameras.Length;
    void Example()
    {
        print("We've got" + count + "cameras");
    }

    // Use this for initialization
    void Start () {
        Example();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

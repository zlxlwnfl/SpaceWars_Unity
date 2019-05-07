using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EasyButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void Button()
    {
        Invoke("startgame", .3f);
    }
    private void startgame()
    {
        SceneManager.LoadScene("hyfgyu");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

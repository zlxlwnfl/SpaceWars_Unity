using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public void Button()
    {
        Invoke("startgame", .3f);
    }
    private void startgame()
    {
        SceneManager.LoadScene("menu");
    }

    // Update is called once per frame
    void Update () {
		
	}
}

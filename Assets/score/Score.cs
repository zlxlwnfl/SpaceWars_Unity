using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	int t;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		Text uiText = GetComponent<Text> ();
		t = Enemy.score;
		uiText.text = t.ToString() + "점";
	}
}

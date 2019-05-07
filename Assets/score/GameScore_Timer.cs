using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScore_Timer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		int t = Timer.time;
		Text uiText = GetComponent<Text> ();
		uiText.text = t.ToString() + 's';
	}
}

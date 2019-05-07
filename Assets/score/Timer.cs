using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//SpaceWars

public class Timer : MonoBehaviour {

	public float TimeCost;
	public static int time;

	// Use this for initialization
	void Start () {
		TimeCost = 0f;
	}

	// Update is called once per frame
	void Update () {
		TimeCost += Time.deltaTime;

		int t = Mathf.FloorToInt (TimeCost);
		Text uiText = GetComponent<Text> ();
		uiText.text = t.ToString() + 's';
		time = t;
	}
}

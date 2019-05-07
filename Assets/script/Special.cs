using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Special : MonoBehaviour {

	public Image SpecialIn;

	public float SpecialMax = 100f;
	public float SpecialCurrent = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (SpecialCurrent < 100)
			InvokeRepeating ("SpecialPlus", 3, 5);

		if (SpecialCurrent > 100) {
			SpecialCurrent = 100;
			CancelInvoke ("SpecialPlus");
		}
		

		SpecialIn.fillAmount = (float)SpecialCurrent / (float)SpecialMax;
	}

	void SpecialPlus() {
		SpecialCurrent += 0.1f;
	}
}

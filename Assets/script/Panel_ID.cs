using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Panel_ID : MonoBehaviour {

    private Text Text_ID;

    public void Awake()
    {
        Text_ID = GetComponent<Text>();
        Text_ID.text = Input_ID.input_ID.charID;
        Debug.Log("pannel_ID OK" + Input_ID.input_ID.charID);
    }

    /*
    public InputField ID;

    private string charID;

    public void OnOK(Text text)
    {
        charID = ID.text;

        text.text = ID.text;

        Debug.Log("You selected" + charID);
    }
    */

}

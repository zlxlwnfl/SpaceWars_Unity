using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input_ID : MonoBehaviour {

    public static Input_ID input_ID;
    public InputField ID;
    public string charID;

    private void Awake()
    {
        if (input_ID == null)
        {
            
            input_ID = this;
            DontDestroyOnLoad(gameObject);
            Debug.Log("input_ID OK" + input_ID.charID);
        }
        else Destroy(gameObject);
    }

    private void Update()
    {
        Debug.Log("input_ID.charID : " + input_ID.charID);
        Debug.Log("ID.text :" + ID.text);

        if (charID != ID.text)
        {
            charID = ID.text;
            

        }
        else Debug.Log("input_ID No");
    }

/*  
    public void OnOK(Text text)
    {
        charID = ID.GetComponent<InputField>().text;

        text.text = ID.text;

        Debug.Log("You selected" + charID);
    }
    */
}

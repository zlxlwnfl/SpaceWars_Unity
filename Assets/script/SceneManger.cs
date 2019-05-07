using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManger : MonoBehaviour {

    void Start()
    {
        Screen.SetResolution(500, 750, false);
    }
    public void StartGUI()
	{
		Debug.Log("OK");
		SceneManager.LoadScene("Intro");
	}

    public void MainGUI()
    {
        Debug.Log("OK");
        SceneManager.LoadScene("Main");
    }

    public void ChangeGUI()
    {
        Debug.Log("Change");
        SceneManager.LoadScene("ID_Make");
    }

    public void EasyGUI()
    {
        Debug.Log("Easy");
        SceneManager.LoadScene("Easy");
    }

    public void NormalGUI()
    {
        Debug.Log("Normal");
        SceneManager.LoadScene("Normal");

    }

    public void HardGUI()
    {
        Debug.Log("Hard");
        SceneManager.LoadScene("Hard");
    }

    public void RankGUI()
    {
        Debug.Log("Ranking");
        SceneManager.LoadScene("Ranking");
    }

    public void ExitGUI()
    {
        Debug.Log("Exit");
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameSceneManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {

    }

    public void Play()
    {
        SceneManager.LoadScene("Game");
    }

    public void Exit()
    {
            Application.Quit();
 
    }

    public void Open()
    {
        Application.OpenURL("http://ssgames.ir/");
    }

    public void BacktoMenu()
    {
        SceneManager.LoadScene("Start");
    }

    public void Theend()
    {
        SceneManager.LoadScene("End");



    }

}

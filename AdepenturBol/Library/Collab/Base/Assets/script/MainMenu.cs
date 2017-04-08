using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MainMenu : MonoBehaviour {
    public Text highscore;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
       
    }

    public void LoadScene()
    {
       SceneManager.LoadScene("scene1");
        highscore.text = "Highscore: " + ((int)PlayerPrefs.GetFloat("Score")).ToString();

    }

    public void doquit()
    { 
        Debug.Log("has quit game");
        Application.Quit();
    }

    public void about()
    {
        SceneManager.LoadScene("about");
    }
    public void loadmain()
    {
        SceneManager.LoadScene("mainmenu");

    }
}

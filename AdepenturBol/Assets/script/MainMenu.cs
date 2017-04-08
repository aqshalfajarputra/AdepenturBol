using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;



public class MainMenu : MonoBehaviour {
    public Text highscore;
    public GameObject backmen, Text, bek, resam, panel;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
       if (Input.GetKeyDown(KeyCode.Escape))
        {
            sure();
        }
    }

    public void LoadScene()
    {
       SceneManager.LoadScene("scene1");
       highscore.text = "Highscore: " + ((int)PlayerPrefs.GetInt("Highscore")).ToString();

    }

    public void sure()
    {
        Time.timeScale = 0;
        Text.SetActive(true);
        bek.SetActive(true);
        resam.SetActive(true);
        panel.SetActive(true);
    }

    public void nay()
    {
        Time.timeScale = 1;
        Text.SetActive(false);
        bek.SetActive(false);
        resam.SetActive(false);
        panel.SetActive(false);
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

    public void herupu()
    {
        SceneManager.LoadScene("helpi");
    }
    public void loadmain()
    {
        SceneManager.LoadScene("mainmenu");

    }
    public void yes()
    {
        SceneManager.LoadScene("about");

    }
}

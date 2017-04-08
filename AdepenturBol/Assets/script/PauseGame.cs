using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour {
    public Transform pausebg;
    public bool paused;
    public GameObject Text, bek, resam, panel;

    // Use this for initialization
    void Start () {
        paused = false;
    }
	
	// Update is called once per frame
	void Update () {
	}

    public void Pause()
    {
        paused = !paused;
        if (paused)
        {
            Time.timeScale = 0;
            AudioListener.pause = true;
            Text.SetActive(true);
            bek.SetActive(true);
            resam.SetActive(true);
            panel.SetActive(true);
        }
        else if (!paused)
        {
            Time.timeScale = 1;
            AudioListener.pause = false;
            Text.SetActive(false);
            bek.SetActive(false);
            resam.SetActive(false);
            panel.SetActive(false);
        }
    }
    public void Mainmenu()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Time.timeScale = 1;
            AudioListener.pause = false;
            Text.SetActive(false);
            bek.SetActive(false);
            resam.SetActive(false);
            panel.SetActive(false);
            SceneManager.LoadScene("mainmenu");
        }
    }

    public void Resume()
    {
        if(Input.GetKey(KeyCode.Mouse0))
        {
                Time.timeScale = 1;
                AudioListener.pause = false;
                Text.SetActive(false);
                bek.SetActive(false);
                resam.SetActive(false);
                 panel.SetActive(false);
        }
    }
}

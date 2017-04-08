using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class enemy : MonoBehaviour {
    public score scorea;
    public Text highscoreText;
    public AudioClip hover;
    public AudioClip click;
    private AudioClip sound;
    public AudioSource source;

    public LevelManager levelManager;
    gerak KomponenGerak;

    // Use this for initialization
    void Start () {
        KomponenGerak = GameObject.Find("ball").GetComponent<gerak>();
        levelManager = FindObjectOfType<LevelManager>();
        gameObject.AddComponent<AudioSource>();
        source.clip = sound;
        source.playOnAwake = false;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.transform.tag == "Player")
        {
            //Destroy(KomponenGerak.gameObject);
            //kalah.SetActive(true);
            //time.SetActive(false);
            //resetbtn.SetActive(true);
            source.PlayOneShot(sound);
            levelManager.RespawnPlayer();
            

        }
    }

    public void resetea()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            PlayerPrefs.SetFloat("Highscore", scorea.highscore);
        }
    }

    public void loadmain()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            SceneManager.LoadScene("mainmenu");
        }
    }
}

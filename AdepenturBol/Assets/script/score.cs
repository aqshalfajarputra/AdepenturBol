using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score : MonoBehaviour
{
    public countDownTimer countdowntimer;
    public static int sisa;
    public Text scoreText;
    public Text highscoreText;
    public GameObject menang, reset, backmen, scoring;

    public static int scoreCount;
    public int highscore;

    // Use this for initialization
    void Start()
    {

        if (PlayerPrefs.HasKey("Highscore"))
        {
            highscore = PlayerPrefs.GetInt("Highscore");
        }
    }

    // Update is called once per frame
    void Update()
    {
        sisa = countdowntimer.timeLeft;

        scoreCount = sisa * 3;
        if (menang.active == true)
        {
            if (scoreCount > highscore)
            {
                highscore = scoreCount;
                PlayerPrefs.SetInt("Highscore", highscore);
            }
            else
            {
                PlayerPrefs.SetInt("Highscore", highscore);
            }
        }

        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        highscoreText.text = "Highscore: " + Mathf.Round(highscore);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            menang.SetActive(true);
            reset.SetActive(true);
            backmen.SetActive(true);
            scoring.SetActive(true);
            //StopCoroutine("LoseTime");
        }
    }
    public void btnreset(float highscore)
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            PlayerPrefs.SetFloat("Highscore", highscore);
            highscoreText.text = "Highscore: " + Mathf.Round(highscore);
        }
    }
}

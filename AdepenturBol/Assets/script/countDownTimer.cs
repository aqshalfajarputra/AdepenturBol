using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countDownTimer : MonoBehaviour
{
    public bool lol;
    public int timeLeft = 5;
    public Text countdownText;
    public Text highscoreText;
    public GameObject menang, kalah, reset, kanan, kiri, atas, bola, backmen;
    // Use this for initialization
    public int highscore;
    public static int hitung;

    void Start()
    {
        hitung = score.scoreCount;
        StartCoroutine("LoseTime");
        lol = false;
        if (PlayerPrefs.HasKey("Highscore"))
        {
            highscore = PlayerPrefs.GetInt("Highscore");
        }
    }

    // Update is called once per frame 
    void Update()
    {
        countdownText.text = ("Time Left = " + timeLeft);
        if (menang.active == true)
        {
            StopCoroutine("LoseTime"); backmen.SetActive(true);
            countdownText.text = ("Time Left = " + timeLeft);
            if (hitung > highscore)
            {
                highscore = hitung;
                PlayerPrefs.SetInt("Highscore", highscore);
            }
            else
            {
                PlayerPrefs.SetInt("Highscore", highscore);
            }
        }
        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            countdownText.text = ("Time Left = " + timeLeft);
            kalah.SetActive(true); backmen.SetActive(true);
            reset.SetActive(true);
            atas.SetActive(false);
            kanan.SetActive(false);
            kiri.SetActive(false);
            bola.SetActive(false);
            PlayerPrefs.SetInt("Highscore", highscore);
        }
    }

    IEnumerator LoseTime()
    {

        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            menang.SetActive(true);
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
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countDownTimer : MonoBehaviour {
    public bool lol;
    public int timeLeft = 5;
    public Text countdownText;
    public GameObject menang, kalah, reset, kanan, kiri, atas, bola;
    // Use this for initialization


    void Start()
    {
        StartCoroutine("LoseTime");
        lol = false;
    }

    // Update is called once per frame 
    void Update()
    {
        countdownText.text = ("Time Left = " + timeLeft);
        if (menang.active == true)
        {
            StopCoroutine("LoseTime");
            countdownText.text = ("Score = " + timeLeft);
        }
        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            countdownText.text = ("Time Left = " + timeLeft);
            kalah.SetActive(true);
            reset.SetActive(true);
            atas.SetActive(false);
            kanan.SetActive(false);
            kiri.SetActive(false);
            bola.SetActive(false);
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

    
}

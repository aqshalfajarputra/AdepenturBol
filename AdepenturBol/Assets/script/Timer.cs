using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    //int score=0; int timer = 0;
    public int timeLeft = 5;
    public Text countdownText;
    public GameObject menang, kalah, reset;
    // Use this for initialization
    public Text score1; public bool check = false;
    public Text Time1; public bool check1 = false;

    void Start() 
    {
        score1.GetComponent<Text>();
        Time1.GetComponent<Text>();
    }

    // Update is called once per frame 
    void Update()
    {
        if (check == false)
        {
          //  StartCoroutine(Score_delay());
         //  
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

    public void btnreset()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Application.LoadLevel(Application.loadedLevel);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gantiGambar : MonoBehaviour {

    public Button b1;
    public Sprite[] s1;
    public GameObject hoh;

    int count = 0;

    // Use this for initialization
    void Awake()
    {
        s1 = Resources.LoadAll<Sprite>("about");
    }

    // Update is called once per frame
    public void On_click()
    {
        count++;

        if (count == s1.Length)
        {
            count = 0;
        }
        b1.image.sprite = s1[count];        
    }
}

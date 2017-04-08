using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class change: MonoBehaviour
{

    // Use this for initialization

    public Sprite[] s1;
    public Button b1;

    int count = 0;


    void Awake()
    {
        s1 = Resources.LoadAll<Sprite>("help");
    }

    // Update is called once per frame


    public void On_Click_Button()
    {
        count++;

        if (count == s1.Length)
        {
            count = 0;
        }

        b1.image.sprite = s1[count];
    }
}

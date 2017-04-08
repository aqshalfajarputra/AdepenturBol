using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gerak : MonoBehaviour {
        // Use this for initialization

    // Use this for initialization
    public int kecepatan,pwlompat;
    Rigidbody2D lompat;

    public bool tanah;
    public LayerMask targetlayer;
    public Transform deteksitanah;
    public float jangkauan; 
	public bool tombolkiri,tombolkanan;
    public Text highscoreText;
    public GameObject menang, kalah, reset, backmen;
    public float highscore;


    void Start () {
        lompat = GetComponent<Rigidbody2D>();
        gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {

        tanah = Physics2D.OverlapCircle(deteksitanah.position, jangkauan, targetlayer);
        if (menang.active == false)
        {
            if (Input.GetKey(KeyCode.D) || (tombolkanan == true))
            {
                transform.Translate(Vector2.right * kecepatan * Time.deltaTime);
            }
            else if (Input.GetKey(KeyCode.A) || (tombolkiri == true))
            {
                transform.Translate(Vector2.right * -kecepatan * Time.deltaTime);
            }

            //        if (tanah== true && (Input.GetKey (KeyCode.Mouse0)))
            //        {
            //            lompat.AddForce(new Vector2(0, pwlompat));
            //        }

        }
    }

	public void tekankiri() {
		tombolkiri = true;
	}
	public void lepaskiri() {
		tombolkiri = false;
	}
	public void tekankanan() {
		tombolkanan = true;
	}
	public void lepaskanan() {
		tombolkanan = false;
	}
	public void loncat() {
		if (tanah== true && (Input.GetKey (KeyCode.Mouse0)))
	 {
	    lompat.AddForce(new Vector2(0, pwlompat));
        }
	}

}

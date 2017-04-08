using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gerak : MonoBehaviour {

    // Use this for initialization
    public int kecepatan,pwlompat;
    Rigidbody2D lompat;

    public bool tanah;
    public LayerMask targetlayer;
    public Transform deteksitanah;
    public float jangkauan;
    private BoxCollider2D groundCollider;
    private float groundHorizontalLength;

	void Start () {
        lompat = GetComponent<Rigidbody2D>();
        groundCollider = GetComponent<BoxCollider2D>();
        groundHorizontalLength = groundCollider.size.x;

	}

    // Update is called once per frame
    void Update()
    {
        tanah = Physics2D.OverlapCircle(deteksitanah.position, jangkauan, targetlayer);

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * kecepatan * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.right * -kecepatan * Time.deltaTime);
        }

        if (tanah == true && (Input.GetKey(KeyCode.Mouse0)))
        {
            lompat.AddForce(new Vector2(0, pwlompat));
        }
        if (transform.position.x < -groundHorizontalLength)
        {
            RepositionBackground();
        }
    }

        private void RepositionBackground()
    {
        Vector2 groundOffset = new Vector2(groundHorizontalLength * 2f, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}

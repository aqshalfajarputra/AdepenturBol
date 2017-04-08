using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject currentCheckpoint;

    gerak KomponenGerak;
    // Use this for initialization
	void Start () {
        KomponenGerak = GameObject.Find("ball").GetComponent<gerak>();
        //objRef = GameObject.FindGameObjectsWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
	}

    public void RespawnPlayer()
    {
        Debug.Log("Respawn");
        KomponenGerak.transform.position = currentCheckpoint.transform.position;
    }
}

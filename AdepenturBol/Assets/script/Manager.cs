using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    public AudioClip hover;
    public AudioClip click;

    private AudioClip sound;

    private Button button { get { return GetComponent<Button>(); } }
    public AudioSource source { get { return GetComponent<AudioSource>(); } }

    // Use this for initialization

    void Start()
    {
        gameObject.AddComponent<AudioSource>();
        source.clip = sound;
        source.playOnAwake = false;

        button.onClick.AddListener(() => PlaySound());
    }

    // Update is called once per frame
    void PlaySound()
    {
        source.PlayOneShot(sound);
    }

    /*public void Onclick()
    {
        source.PlayOneShot(hover);
    }*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip npc1;
    //public AudioClip aud11;
    //public AudioClip aud12;

    public AudioClip npc2;
    //public AudioClip aud21;
    //public AudioClip aud22;

    public AudioClip npc3;
    //public AudioClip aud31;
    //public AudioClip aud32;

    public AudioClip npc4;
    //public AudioClip aud41;
    //public AudioClip aud42;

    public AudioClip npc5;
    //public AudioClip aud51;
    //public AudioClip aud52;

    public AudioClip npc6;
    public AudioClip npc7;
    public AudioClip npc8;
    public AudioClip npc9;
    public AudioClip npc10;
    public AudioClip npc11;
    public AudioClip npc12;
    public AudioClip npc13;
    public AudioClip npc14;
    //public AudioClip aud61;
    //public AudioClip aud62;


    public bool answer0;

    public bool answer11;
    public bool answer12;

    public bool answer21;
    public bool answer22;

    public bool answer31;
    public bool answer32;

    public bool answer41;
    public bool answer42;

    public bool answer51;
    public bool answer52;

    public bool answer61;
    public bool answer62;

    public bool answer71;
    public bool answer72;

    public bool answer81;
    public bool answer82;

    private float clipEnd;
    public GameObject scriptCam;

    // Start is called before the first frame update
    void Awake()
    {
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

        if (answer0 == true && !audioSource.isPlaying)
        {
            Debug.Log("Play");
            audioSource.PlayOneShot(npc1);
            answer0 = false;

        }

        if (answer11 == true && !audioSource.isPlaying)
        {
            Debug.Log("Play");
            audioSource.PlayOneShot(npc2);
            answer11 = false;

        }



        if (answer12 == true && !audioSource.isPlaying)
        {
            Debug.Log("Play");
            audioSource.PlayOneShot(npc3);
            answer12 = false;
        }

        if (answer21 == true && !audioSource.isPlaying)
        {
            Debug.Log("Play");
            audioSource.PlayOneShot(npc4);
            answer21 = false;
        }

        if (answer22 == true && !audioSource.isPlaying)
        {
            Debug.Log("Play");
            audioSource.PlayOneShot(npc5);
            answer22 = false;
        }


        if (answer31 == true && !audioSource.isPlaying)
        {
            Debug.Log("Play");
            audioSource.PlayOneShot(npc6);
            answer31 = false;
        }

        if (answer32 == true && !audioSource.isPlaying)
        {
            Debug.Log("Play");
            audioSource.PlayOneShot(npc8);
            answer32 = false;
        }

        if (answer41 == true && !audioSource.isPlaying)
        {
            Debug.Log("Play");
            audioSource.PlayOneShot(npc9);
            answer41 = false;
        }

        if (answer51 == true && !audioSource.isPlaying)
        {
            Debug.Log("Play");
            audioSource.PlayOneShot(npc10);
            answer51 = false;
        }

    }


}

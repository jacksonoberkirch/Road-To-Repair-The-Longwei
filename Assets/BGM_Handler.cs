using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM_Handler : MonoBehaviour
{
    public AudioSource intro;

    public AudioSource loop;

    // Start is called before the first frame update
    void Start()
    {
        intro.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (intro.isPlaying == false && loop.isPlaying == false)
        {
            loop.Play();
        }
    }
}

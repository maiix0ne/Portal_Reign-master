using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class GunLaser : MonoBehaviour
{


    private AudioSource audioSound;

    void Start()
    {
        audioSound = gameObject.GetComponent<AudioSource>();
    }
    void Update()
    {
        if (audioSound)
        {
            ProcessFiring();
        }
    }
    void ProcessFiring()
    {

        if (CrossPlatformInputManager.GetButton("Fire"))
        {
            audioSound.Play();
        }
    }
}

 
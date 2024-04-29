using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource bg;
    private AudioSource sfx;

    private void Awake()
    {
        bg = GetComponent<AudioSource>();
    }
}

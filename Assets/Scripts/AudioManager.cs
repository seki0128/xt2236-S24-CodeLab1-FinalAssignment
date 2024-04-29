using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bg;
    public AudioSource sfx;
    public AudioClip note;
    public Melody currentMelody;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayMelody(currentMelody);
        }
    }

    void PlayMelody(Melody melody)
    {
        float timeGap = 1.0f;
        float timer = 0;

        if (timer <= timeGap)
        {
            timer += Time.deltaTime;
        }
        else
        {
            timer = 0;
            PlayOneNote((melody.melody.Peek()));
        }
    }
    
    void PlayOneNote(char i)
    {
        switch (i)
        {
            case '1':
                sfx.pitch = 1;
                break;
            case '2':
                sfx.pitch = 2;
                break;
            case '3':
                sfx.pitch = 3;
                break;
            case '4':
                sfx.pitch = 4;
                break;
            case '5':
                sfx.pitch = 5;
                break;
            case '6':
                sfx.pitch = 6;
                break;
            case '7':
                sfx.pitch = 7;
                break;
        }
        sfx.PlayOneShot(note);
    }
}

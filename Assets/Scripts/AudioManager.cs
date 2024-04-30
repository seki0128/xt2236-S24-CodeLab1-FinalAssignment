using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource sfx;
    public AudioClip note;
    public Melody currentMelody;

    public bool playMode;
    public float timeGap = 0.8f;
    float timer = 0;

    private TextMeshProUGUI playStageUI;

    private void Awake()
    {
        playStageUI = GameObject.Find("PlayStageUI").GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            playMode = true;
            currentMelody.CreateQueue(); // Create the play queue based on melody string
            GameManager.instance.inputRecorder.recordMelody = currentMelody.melody.ToArray(); // Copy the queue in the recorder
        }

        if (playMode)
        {
            PlayMelody(currentMelody);
            playStageUI.text = "Playing ...";
        }
        else
        {
            playStageUI.text = "";
        }
    }

    void PlayMelody(Melody melody)
    {
        
        if (timer <= timeGap)
        {
            timer += Time.deltaTime;
        }
        else
        {
            if (melody.melody.Count != 0)
            {
                PlayOneNote((melody.melody.Dequeue())); // Pop up the first note and play it
            }
            else
            {
                playMode = false;
            }
            timer = 0;
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

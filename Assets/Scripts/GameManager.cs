using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public AudioManager audioManager;
    public InputRecorder inputRecorder;
    

    private void Awake()
    {
        audioManager = GetComponentInChildren<AudioManager>();
        inputRecorder = GetComponentInChildren<InputRecorder>();
        
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (audioManager.currentMelody.next != null)
            {
                if (inputRecorder.nextMelody.IsActive())
                {
                    inputRecorder.ResetUI();
                    inputRecorder.progress = 0;
                    audioManager.currentMelody = audioManager.currentMelody.next;
                }
            }
            else
            {
                
            }

        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Note : MonoBehaviour
{
    public int pitch = 1;
    
    private void OnDestroy()
    {
        GameManager.instance.audioManager.sfx.pitch = pitch;
        GameManager.instance.audioManager.sfx.PlayOneShot(GameManager.instance.audioManager.note);
        
        char pitchChar = Convert.ToChar(pitch.ToString());
        if (GameManager.instance.audioManager.currentMelody.melody != null)
        {
            GameManager.instance.inputRecorder.PrintCurrentRecord();
            GameManager.instance.inputRecorder.CompareNote(pitchChar);
        }
    }
}

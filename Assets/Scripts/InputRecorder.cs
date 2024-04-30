using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InputRecorder : MonoBehaviour
{
    public char[] recordMelody;

    public GameObject[] UIObjects;

    public int progress =0;
    public TextMeshProUGUI nextMelody;
    
    public void Awake()
    {
        // Initialize the variables
        recordMelody = new char[6];
        ResetUI();
    }
    public void PrintCurrentRecord()
    {
        string record = "";
        foreach (var i in recordMelody)
        {
            Debug.Log(i);
            record += i;
        }
    }

    public void CompareNote(char chari)
    {
        if (progress < 6)
        {
            if (chari == recordMelody[progress])
            {
                UIObjects[progress].SetActive(true);
                progress++;
            }
        }
        else
        {
            nextMelody.gameObject.SetActive(true);
        }
        
    }

    public void ResetUI()
    {
        foreach (var i in UIObjects)
        {
            i.gameObject.SetActive(false);
            nextMelody.gameObject.SetActive(false);
        }
    }
}

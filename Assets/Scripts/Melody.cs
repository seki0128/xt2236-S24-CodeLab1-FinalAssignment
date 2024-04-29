using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Melody : ScriptableObject
{
    public string name;
    public string melodyInfo;
    public Queue<char> melody;
    
    
    Queue<char> CreateQueue()
    {
        foreach (char i in melodyInfo)
        {
            melody.Enqueue(i);
        }


        return melody;
    }


    void PlayMelody()
    {
        foreach (var i in melody)
        {
            PlaySingleNote(i);
        }

    }
    
    void PlaySingleNote(char i)
    {
        AudioClip note;
        switch (i)
        {
            case '1':
                break;
            case '2':
                break;
            case '3':
                break;
            case '4':
                break;
            case '5':
                break;
            case '6':
                break;
            case '7':
                break;
        }
    }
}

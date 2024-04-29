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
        //foreach (var i in melody)


    }
    

}

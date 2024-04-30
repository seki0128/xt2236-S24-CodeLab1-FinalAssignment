using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Melody : ScriptableObject
{
    public string name;
    public string melodyInfo;
    public Queue<char> melody;

    public Melody next;
    
    
    public Queue<char> CreateQueue()
    {
        melody = new Queue<char>();
        foreach (char i in melodyInfo)
        {
            melody.Enqueue(i);
        }
        
        Debug.Log(melody.Peek());
        return melody;
    }
}

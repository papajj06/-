using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dsystem : MonoBehaviour
{

    public Text TxtName;
    public Text TxtSentence;

    Queue<string> sentences = new Queue<string>();

    public void Begin(Dia info)
    {
        sentences.Clear();

        TxtName.text = info.name;

        foreach (var sentence in info.sentences)
        {
            sentences.Enqueue(sentence);
        }
        Next();
    }

    public void Next()
    {
        if (sentences.Count == 0)
        {
            End();
            return;
        }

        TxtSentence.text = sentences.Dequeue();
    }

    private void End()
    {
        Debug.Log("End");
    }
}



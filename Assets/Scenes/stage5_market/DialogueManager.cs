using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text Txtsentence;
    public Text Txtname;


 Queue<string> sentences = new Queue<string>();

public void Begin(Dialogue info)
{
    sentences.Clear();

    Txtname.text = info.name;

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
        Txtsentence.text = sentences.Dequeue();
       /* Txtsentence.text = string.Empty;
        StopAllCoroutinues();
        StartCoroutine(TypeSentence(sentence.Dequeue()));
        */
}
    IEnumerator TypeSentence(string sentence)
    {
        foreach(var letter in sentence)
        {
            Txtsentence.text += letter;
            yield return new WaitForSeconds(0.1f);
        }
    }
private void End()
{
    Debug.Log("End");
}

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class talkSystem : MonoBehaviour
{
    public StageManager StageManager;

    public Text TTxtsentence;
    public Text TTxtname;

    Queue<string> sentences = new Queue<string>();
    

  
    public void Begin(talkDia info)
    {
        sentences.Clear();

        TTxtname.text = info.name;

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
        TTxtsentence.text = sentences.Dequeue();
        /* Txtsentence.text = string.Empty;
         StopAllCoroutinues();
         StartCoroutine(TypeSentence(sentence.Dequeue()));
         */
    }
    IEnumerator TypeSentence(string sentence)
    {
        foreach (var letter in sentence)
        {
            TTxtsentence.text += letter;
            yield return new WaitForSeconds(0.1f);
        }
    }
    private void End()
    {
        Debug.Log("End");
    }


}

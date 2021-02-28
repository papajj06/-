using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class answerTalk : MonoBehaviour
{
    public Text Txt;

    public void Onclick()
    {  
        //heart.SetActive(true);
        Txt.text = "나도 좋아!";
    }

    public void Onclick2()
    {
        Txt.text = "나는 별로야.....싫어!";
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MissionClick : MonoBehaviour
{
    public NextQuiz NextQuiz;
    public GameObject correct;
    public GameObject incorrect;

    public int total = 0;

    void Start()
    {
        this.NextQuiz = GameObject.Find("footCanvas").transform.Find("nextAnimal").gameObject.GetComponent<NextQuiz>();
        //Score.text = "0/3";
    }

    public void correctClick()
    {
        correct = GameObject.Find("footCanvas").transform.Find("correct").gameObject;
        correct.SetActive(true);
        NextQuiz.score++;
        Invoke("closeDelay", 0.2f);
        Invoke("correctFalse", 0.4f);
    }

    public void incorrectClick()
    {
        incorrect = GameObject.Find("footCanvas").transform.Find("incorrect").gameObject;
        incorrect.SetActive(true);
        Invoke("closeDelay", 0.2f);
        Invoke("incorrectFalse", 0.4f);
    }

    void correctFalse()
    {
        correct.SetActive(false);
    }

    void incorrectFalse()
    {
        incorrect.SetActive(false);
    }

    void closeDelay()
    {
        NextQuiz.QuizClose(NextQuiz.num);
    }
}
